using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A198105
{
public static readonly long[] Value={ 5L,0L,1L,0L,4L,1L,1L,8L,6L,4L,4L,6L,4L,9L,0L,3L,8L,3L,3L,1L,5L,1L,4L,1L,7L,7L,9L,0L,6L,6L,3L,4L,6L,4L,9L,7L,8L,6L,0L,8L,4L,9L,9L,1L,4L,5L,4L,4L,5L,0L,9L,0L,6L,7L,8L,0L,4L,3L,2L,0L,5L,8L,4L,4L,4L,6L,2L,6L,3L,3L,0L,2L,7L,0L,5L,5L,2L,4L,7L,0L,5L,3L,4L,5L,8L,4L,0L,1L,6L,9L,4L,5L,2L,2L,4L,9L,1L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198105Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198105.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198105Inst : IEnumerable<long>
{
public static readonly long[] Value=A198105.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198105.Bytes);
public long this[int i]=>Value[i];

public static A198105Inst Instance=new A198105Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198106
{
public static readonly long[] Value={ 2L,1L,9L,8L,5L,6L,1L,3L,3L,5L,4L,6L,8L,1L,6L,1L,8L,8L,2L,3L,3L,0L,7L,6L,4L,3L,6L,7L,1L,0L,9L,0L,6L,3L,1L,8L,3L,0L,2L,6L,1L,2L,8L,5L,2L,9L,8L,7L,8L,1L,7L,3L,2L,7L,1L,0L,0L,7L,3L,4L,5L,3L,2L,0L,2L,7L,0L,9L,1L,8L,0L,3L,5L,6L,3L,0L,6L,6L,1L,0L,7L,8L,5L,2L,9L,2L,4L,7L,7L,7L,3L,9L,5L,0L,9L,6L,9L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198106Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198106.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198106Inst : IEnumerable<long>
{
public static readonly long[] Value=A198106.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198106.Bytes);
public long this[int i]=>Value[i];

public static A198106Inst Instance=new A198106Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198107
{
public static readonly long[] Value={ 6L,5L,2L,5L,7L,3L,2L,5L,1L,5L,3L,3L,3L,9L,7L,4L,2L,4L,4L,4L,1L,2L,6L,2L,3L,4L,5L,3L,4L,6L,4L,8L,8L,2L,4L,9L,7L,6L,4L,9L,9L,2L,8L,7L,6L,1L,0L,9L,1L,8L,7L,1L,1L,5L,3L,0L,9L,2L,9L,0L,6L,7L,8L,2L,2L,7L,6L,5L,4L,4L,2L,1L,9L,9L,0L,9L,5L,6L,9L,3L,7L,0L,1L,4L,2L,1L,0L,8L,9L,9L,5L,5L,2L,0L,4L,1L,9L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198107Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198107.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198107Inst : IEnumerable<long>
{
public static readonly long[] Value=A198107.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198107.Bytes);
public long this[int i]=>Value[i];

public static A198107Inst Instance=new A198107Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198108
{
public static readonly long[] Value={ 2L,0L,7L,2L,1L,9L,1L,3L,0L,2L,7L,1L,1L,8L,0L,9L,3L,2L,7L,3L,7L,9L,6L,8L,2L,2L,9L,0L,0L,2L,7L,0L,0L,3L,7L,2L,6L,5L,6L,8L,7L,2L,0L,3L,7L,5L,9L,3L,5L,8L,9L,1L,6L,2L,5L,2L,8L,7L,0L,1L,4L,3L,3L,8L,1L,2L,1L,1L,8L,3L,7L,7L,0L,3L,9L,0L,6L,6L,3L,2L,8L,1L,3L,6L,2L,5L,0L,3L,7L,1L,3L,5L,7L,3L,6L,6L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198108Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198108.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198108Inst : IEnumerable<long>
{
public static readonly long[] Value=A198108.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198108.Bytes);
public long this[int i]=>Value[i];

public static A198108Inst Instance=new A198108Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198109
{
public static readonly long[] Value={ 7L,6L,5L,7L,2L,6L,4L,4L,2L,9L,2L,0L,5L,4L,0L,7L,1L,7L,4L,8L,3L,1L,0L,1L,0L,4L,9L,2L,3L,9L,4L,4L,9L,9L,3L,8L,2L,5L,9L,3L,8L,8L,0L,0L,4L,2L,0L,4L,9L,6L,3L,7L,0L,7L,0L,8L,5L,2L,1L,5L,1L,7L,2L,8L,8L,4L,5L,8L,6L,9L,4L,9L,7L,5L,8L,1L,7L,4L,9L,7L,9L,4L,2L,2L,8L,3L,9L,2L,5L,1L,1L,7L,8L,8L,9L,2L,8L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198109Inst : IEnumerable<long>
{
public static readonly long[] Value=A198109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198109.Bytes);
public long this[int i]=>Value[i];

public static A198109Inst Instance=new A198109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198110
{
public static readonly long[] Value={ 6L,3L,4L,5L,5L,9L,9L,4L,5L,5L,2L,6L,6L,2L,2L,7L,4L,0L,0L,6L,7L,7L,6L,8L,3L,4L,3L,7L,6L,9L,8L,5L,4L,4L,8L,0L,3L,0L,7L,5L,7L,1L,6L,7L,8L,2L,2L,5L,1L,8L,8L,3L,6L,2L,1L,7L,7L,0L,5L,1L,5L,4L,1L,6L,2L,5L,6L,9L,3L,7L,6L,9L,2L,8L,9L,1L,9L,5L,4L,3L,1L,2L,9L,7L,3L,0L,1L,4L,0L,1L,9L,5L,5L,1L,3L,1L,8L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198110Inst : IEnumerable<long>
{
public static readonly long[] Value=A198110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198110.Bytes);
public long this[int i]=>Value[i];

public static A198110Inst Instance=new A198110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198111
{
public static readonly long[] Value={ 9L,4L,0L,3L,4L,9L,9L,6L,5L,3L,5L,5L,0L,5L,3L,8L,8L,8L,2L,2L,9L,3L,9L,3L,6L,8L,7L,6L,1L,4L,9L,6L,8L,9L,0L,9L,7L,7L,0L,7L,2L,7L,6L,0L,7L,4L,2L,6L,4L,6L,4L,3L,9L,3L,6L,8L,6L,1L,6L,4L,4L,5L,1L,6L,3L,1L,8L,3L,0L,4L,5L,5L,1L,7L,4L,7L,9L,6L,9L,1L,4L,9L,4L,6L,8L,9L,3L,4L,4L,0L,1L,1L,2L,0L,1L,0L,3L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198111Inst : IEnumerable<long>
{
public static readonly long[] Value=A198111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198111.Bytes);
public long this[int i]=>Value[i];

public static A198111Inst Instance=new A198111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198112
{
public static readonly long[] Value={ 8L,7L,0L,3L,1L,6L,3L,4L,1L,1L,7L,7L,4L,8L,7L,5L,3L,8L,6L,7L,2L,4L,0L,5L,2L,9L,2L,3L,4L,8L,1L,5L,0L,6L,1L,5L,2L,5L,6L,1L,6L,0L,7L,0L,2L,9L,9L,6L,8L,3L,2L,4L,5L,5L,8L,8L,1L,6L,7L,6L,2L,7L,6L,7L,6L,7L,2L,5L,5L,6L,9L,1L,4L,2L,2L,9L,5L,1L,2L,4L,2L,5L,4L,7L,8L,9L,3L,4L,4L,4L,8L,8L,5L,8L,5L,3L,5L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198112Inst : IEnumerable<long>
{
public static readonly long[] Value=A198112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198112.Bytes);
public long this[int i]=>Value[i];

public static A198112Inst Instance=new A198112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198113
{
public static readonly long[] Value={ 4L,6L,3L,9L,0L,2L,3L,8L,2L,5L,9L,7L,4L,1L,1L,9L,0L,9L,7L,5L,6L,7L,0L,3L,1L,6L,9L,5L,3L,5L,3L,5L,0L,5L,8L,9L,7L,2L,0L,7L,5L,7L,5L,8L,2L,7L,1L,2L,0L,1L,4L,2L,0L,1L,5L,3L,6L,2L,2L,5L,6L,8L,9L,2L,6L,5L,2L,5L,9L,5L,3L,1L,9L,5L,9L,9L,6L,0L,9L,6L,9L,0L,7L,4L,0L,1L,1L,9L,4L,4L,2L,7L,3L,8L,0L,3L,6L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198113Inst : IEnumerable<long>
{
public static readonly long[] Value=A198113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198113.Bytes);
public long this[int i]=>Value[i];

public static A198113Inst Instance=new A198113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198114
{
public static readonly long[] Value={ 1L,0L,1L,7L,0L,5L,4L,9L,0L,0L,6L,7L,5L,0L,6L,0L,9L,6L,9L,3L,3L,1L,1L,6L,5L,5L,8L,3L,6L,1L,7L,7L,4L,5L,8L,9L,4L,7L,7L,1L,6L,2L,8L,8L,7L,5L,9L,6L,6L,0L,1L,0L,6L,6L,4L,6L,7L,9L,0L,5L,9L,1L,1L,4L,9L,3L,0L,8L,5L,1L,5L,3L,9L,2L,6L,3L,6L,1L,5L,3L,4L,6L,0L,6L,7L,0L,2L,4L,6L,8L,6L,9L,6L,7L,9L,5L,3L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198114Inst : IEnumerable<long>
{
public static readonly long[] Value=A198114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198114.Bytes);
public long this[int i]=>Value[i];

public static A198114Inst Instance=new A198114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198115
{
public static readonly long[] Value={ 6L,6L,9L,9L,6L,8L,1L,6L,9L,0L,4L,6L,9L,3L,3L,1L,9L,1L,7L,5L,0L,9L,3L,9L,2L,8L,9L,5L,6L,2L,1L,6L,6L,2L,8L,7L,2L,9L,5L,4L,9L,4L,3L,5L,5L,1L,3L,5L,9L,1L,9L,9L,5L,8L,3L,7L,3L,0L,9L,3L,3L,7L,4L,7L,0L,7L,4L,6L,7L,7L,9L,1L,4L,4L,7L,9L,6L,2L,4L,3L,1L,3L,5L,0L,2L,7L,7L,8L,0L,6L,1L,6L,6L,2L,4L,5L,8L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198115Inst : IEnumerable<long>
{
public static readonly long[] Value=A198115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198115.Bytes);
public long this[int i]=>Value[i];

public static A198115Inst Instance=new A198115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198116
{
public static readonly long[] Value={ 1L,1L,0L,6L,6L,9L,5L,8L,9L,2L,8L,6L,3L,5L,0L,3L,1L,2L,3L,6L,0L,5L,9L,4L,5L,6L,7L,5L,9L,2L,0L,8L,2L,0L,8L,0L,2L,3L,1L,2L,9L,0L,8L,0L,2L,1L,7L,5L,4L,9L,9L,6L,7L,8L,5L,5L,3L,0L,1L,5L,2L,5L,0L,9L,8L,6L,6L,6L,8L,0L,9L,5L,3L,5L,3L,2L,9L,3L,1L,6L,5L,5L,2L,8L,1L,8L,1L,9L,3L,3L,2L,0L,6L,8L,3L,5L,1L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198116Inst : IEnumerable<long>
{
public static readonly long[] Value=A198116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198116.Bytes);
public long this[int i]=>Value[i];

public static A198116Inst Instance=new A198116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198117
{
public static readonly long[] Value={ 8L,0L,1L,5L,9L,1L,9L,8L,7L,2L,9L,9L,7L,4L,7L,2L,0L,4L,3L,5L,7L,7L,6L,4L,4L,4L,3L,2L,0L,0L,0L,5L,7L,7L,9L,2L,6L,0L,7L,9L,0L,4L,5L,1L,5L,8L,6L,0L,5L,8L,2L,6L,0L,3L,1L,9L,3L,6L,5L,5L,7L,5L,1L,7L,4L,0L,1L,5L,8L,7L,6L,7L,9L,2L,2L,1L,9L,6L,4L,0L,0L,5L,4L,4L,9L,0L,8L,0L,2L,4L,9L,2L,2L,3L,6L,0L,8L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198117Inst : IEnumerable<long>
{
public static readonly long[] Value=A198117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198117.Bytes);
public long this[int i]=>Value[i];

public static A198117Inst Instance=new A198117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198118
{
public static readonly long[] Value={ 1L,1L,6L,9L,0L,2L,2L,6L,9L,2L,3L,0L,5L,3L,9L,2L,9L,1L,0L,2L,1L,0L,1L,0L,0L,2L,2L,8L,8L,5L,2L,7L,8L,3L,0L,5L,6L,7L,1L,9L,3L,8L,9L,3L,3L,1L,6L,6L,1L,0L,8L,7L,0L,6L,8L,2L,3L,0L,0L,3L,7L,1L,1L,4L,0L,7L,6L,3L,3L,3L,7L,9L,1L,4L,0L,7L,8L,2L,0L,2L,5L,4L,9L,6L,7L,4L,5L,4L,2L,3L,5L,8L,9L,3L,3L,6L,0L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198118Inst : IEnumerable<long>
{
public static readonly long[] Value=A198118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198118.Bytes);
public long this[int i]=>Value[i];

public static A198118Inst Instance=new A198118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198119
{
public static readonly long[] Value={ 8L,9L,5L,6L,5L,2L,3L,8L,1L,3L,5L,8L,4L,2L,8L,9L,0L,1L,2L,1L,8L,1L,7L,6L,4L,7L,2L,1L,3L,5L,3L,7L,1L,4L,7L,5L,8L,5L,7L,2L,8L,2L,6L,9L,1L,0L,7L,0L,9L,1L,2L,9L,4L,1L,6L,6L,7L,0L,7L,1L,1L,4L,7L,3L,5L,4L,5L,1L,6L,6L,9L,0L,9L,7L,0L,1L,9L,2L,6L,0L,7L,5L,9L,3L,8L,2L,1L,7L,1L,4L,6L,6L,9L,5L,4L,8L,4L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198119Inst : IEnumerable<long>
{
public static readonly long[] Value=A198119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198119.Bytes);
public long this[int i]=>Value[i];

public static A198119Inst Instance=new A198119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198120
{
public static readonly long[] Value={ 4L,2L,3L,4L,1L,8L,8L,6L,7L,4L,3L,6L,9L,5L,6L,3L,9L,0L,2L,5L,4L,9L,0L,1L,9L,1L,4L,5L,6L,7L,1L,3L,7L,9L,8L,7L,7L,8L,8L,8L,1L,6L,9L,1L,7L,2L,9L,9L,4L,8L,0L,6L,3L,4L,0L,9L,5L,8L,5L,0L,6L,3L,0L,6L,0L,5L,6L,7L,1L,3L,8L,3L,3L,0L,6L,0L,1L,9L,8L,2L,1L,5L,8L,2L,0L,6L,1L,7L,4L,1L,3L,1L,2L,5L,8L,5L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198120Inst : IEnumerable<long>
{
public static readonly long[] Value=A198120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198120.Bytes);
public long this[int i]=>Value[i];

public static A198120Inst Instance=new A198120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198121
{
public static readonly long[] Value={ 1L,4L,6L,3L,3L,6L,2L,8L,2L,7L,2L,9L,6L,4L,3L,1L,1L,4L,5L,1L,0L,5L,2L,9L,6L,4L,2L,6L,1L,6L,1L,3L,5L,8L,7L,0L,6L,9L,1L,8L,2L,7L,7L,3L,2L,5L,2L,2L,4L,4L,1L,4L,1L,2L,6L,9L,7L,2L,5L,8L,6L,5L,5L,2L,8L,2L,5L,0L,0L,0L,9L,8L,5L,6L,6L,1L,6L,1L,2L,6L,5L,6L,7L,7L,4L,7L,4L,2L,9L,8L,4L,9L,2L,8L,9L,7L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198121Inst : IEnumerable<long>
{
public static readonly long[] Value=A198121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198121.Bytes);
public long this[int i]=>Value[i];

public static A198121Inst Instance=new A198121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198122
{
public static readonly long[] Value={ 2L,7L,9L,3L,2L,0L,7L,7L,9L,7L,3L,8L,1L,6L,5L,0L,6L,1L,2L,8L,0L,5L,9L,3L,3L,9L,6L,6L,5L,5L,3L,9L,5L,5L,4L,5L,6L,2L,2L,7L,5L,8L,0L,0L,4L,5L,9L,7L,1L,7L,5L,0L,7L,1L,9L,7L,1L,5L,7L,2L,0L,3L,7L,7L,8L,7L,0L,6L,0L,4L,7L,5L,9L,8L,5L,5L,1L,2L,1L,8L,5L,0L,1L,1L,8L,3L,3L,3L,0L,1L,4L,4L,5L,1L,7L,5L,3L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198122Inst : IEnumerable<long>
{
public static readonly long[] Value=A198122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198122.Bytes);
public long this[int i]=>Value[i];

public static A198122Inst Instance=new A198122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198123
{
public static readonly long[] Value={ 2L,1L,2L,3L,6L,3L,3L,3L,3L,4L,5L,1L,9L,9L,8L,2L,3L,9L,4L,1L,9L,8L,7L,7L,0L,2L,4L,6L,4L,1L,1L,0L,6L,1L,4L,6L,7L,9L,0L,2L,8L,1L,7L,3L,9L,1L,0L,9L,6L,7L,7L,3L,4L,1L,9L,2L,3L,6L,9L,5L,8L,2L,4L,7L,6L,4L,8L,6L,0L,7L,5L,3L,6L,7L,3L,0L,0L,4L,0L,4L,0L,3L,9L,0L,5L,4L,2L,9L,6L,4L,9L,6L,8L,8L,6L,0L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198123Inst : IEnumerable<long>
{
public static readonly long[] Value=A198123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198123.Bytes);
public long this[int i]=>Value[i];

public static A198123Inst Instance=new A198123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198124
{
public static readonly long[] Value={ 1L,1L,6L,7L,8L,7L,3L,1L,5L,2L,7L,3L,8L,5L,6L,7L,1L,9L,7L,9L,3L,0L,8L,1L,2L,2L,4L,2L,7L,6L,9L,9L,6L,3L,0L,8L,1L,7L,5L,4L,3L,1L,1L,3L,5L,6L,7L,0L,9L,6L,3L,3L,5L,0L,8L,3L,6L,5L,3L,9L,2L,4L,5L,1L,0L,0L,6L,7L,5L,4L,6L,9L,5L,2L,1L,7L,2L,6L,9L,0L,0L,0L,3L,0L,3L,1L,4L,3L,2L,3L,5L,5L,8L,4L,9L,8L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198124Inst : IEnumerable<long>
{
public static readonly long[] Value=A198124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198124.Bytes);
public long this[int i]=>Value[i];

public static A198124Inst Instance=new A198124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198125
{
public static readonly long[] Value={ 3L,4L,8L,4L,9L,5L,0L,4L,8L,1L,7L,3L,8L,4L,2L,9L,1L,6L,5L,5L,6L,6L,8L,4L,1L,8L,4L,7L,1L,9L,9L,0L,5L,9L,9L,3L,9L,6L,1L,7L,9L,0L,4L,1L,3L,8L,9L,4L,7L,5L,1L,8L,9L,5L,3L,6L,0L,4L,1L,6L,1L,8L,2L,0L,6L,2L,1L,8L,2L,5L,6L,7L,0L,2L,6L,2L,9L,1L,6L,0L,5L,9L,4L,5L,9L,2L,4L,8L,6L,5L,3L,5L,4L,0L,3L,6L,1L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198125Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198125.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198125Inst : IEnumerable<long>
{
public static readonly long[] Value=A198125.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198125.Bytes);
public long this[int i]=>Value[i];

public static A198125Inst Instance=new A198125Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198126
{
public static readonly long[] Value={ 1L,3L,0L,3L,6L,8L,8L,2L,3L,6L,0L,8L,2L,7L,3L,1L,2L,3L,6L,1L,5L,7L,9L,4L,2L,3L,4L,9L,2L,0L,1L,7L,3L,1L,5L,8L,1L,7L,1L,3L,6L,6L,2L,5L,6L,7L,7L,7L,5L,0L,6L,2L,3L,8L,8L,1L,7L,3L,8L,3L,0L,4L,5L,9L,1L,1L,6L,0L,2L,7L,0L,3L,4L,3L,4L,5L,4L,9L,4L,8L,7L,8L,0L,3L,8L,4L,4L,5L,0L,8L,7L,1L,0L,4L,7L,6L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198126Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198126.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198126Inst : IEnumerable<long>
{
public static readonly long[] Value=A198126.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198126.Bytes);
public long this[int i]=>Value[i];

public static A198126Inst Instance=new A198126Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198127
{
public static readonly long[] Value={ 6L,8L,7L,2L,2L,8L,2L,9L,2L,2L,5L,2L,5L,4L,8L,8L,5L,4L,0L,1L,5L,3L,6L,6L,7L,6L,6L,9L,9L,7L,6L,1L,9L,0L,5L,2L,1L,7L,1L,1L,1L,6L,2L,1L,1L,9L,2L,3L,5L,6L,6L,2L,5L,0L,8L,5L,0L,8L,0L,1L,0L,4L,6L,0L,3L,6L,6L,6L,7L,9L,0L,0L,1L,1L,4L,7L,5L,2L,4L,3L,9L,0L,6L,9L,9L,0L,9L,2L,7L,7L,9L,3L,6L,1L,8L,3L,3L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198127Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198127.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198127Inst : IEnumerable<long>
{
public static readonly long[] Value=A198127.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198127.Bytes);
public long this[int i]=>Value[i];

public static A198127Inst Instance=new A198127Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198128
{
public static readonly long[] Value={ 2L,7L,1L,8L,3L,1L,8L,5L,1L,8L,9L,5L,8L,0L,5L,9L,0L,7L,1L,8L,6L,8L,8L,2L,0L,3L,3L,3L,5L,8L,8L,3L,9L,7L,6L,2L,7L,5L,0L,2L,0L,4L,9L,6L,5L,7L,2L,7L,6L,0L,5L,9L,5L,0L,8L,2L,5L,3L,0L,1L,4L,3L,8L,9L,5L,8L,6L,4L,8L,6L,0L,0L,8L,2L,1L,5L,1L,5L,5L,6L,7L,9L,0L,9L,3L,5L,2L,1L,7L,2L,9L,6L,5L,7L,5L,2L,0L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198128Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198128.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198128Inst : IEnumerable<long>
{
public static readonly long[] Value=A198128.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198128.Bytes);
public long this[int i]=>Value[i];

public static A198128Inst Instance=new A198128Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198129
{
public static readonly long[] Value={ 1L,5L,1L,7L,5L,3L,8L,9L,8L,0L,6L,6L,1L,4L,8L,2L,2L,4L,4L,8L,3L,2L,7L,4L,6L,9L,8L,6L,3L,9L,0L,8L,1L,1L,5L,0L,8L,0L,9L,9L,5L,0L,7L,1L,0L,7L,8L,4L,5L,4L,2L,2L,8L,5L,8L,6L,9L,0L,1L,4L,6L,0L,6L,0L,6L,1L,6L,8L,2L,6L,6L,7L,2L,5L,9L,4L,1L,1L,6L,4L,7L,4L,3L,7L,3L,9L,2L,5L,7L,7L,1L,3L,3L,9L,9L,5L,0L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198129Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198129.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198129Inst : IEnumerable<long>
{
public static readonly long[] Value=A198129.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198129.Bytes);
public long this[int i]=>Value[i];

public static A198129Inst Instance=new A198129Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198130
{
public static readonly long[] Value={ 1L,5L,2L,7L,9L,9L,9L,7L,1L,2L,0L,3L,6L,8L,4L,0L,6L,3L,3L,5L,2L,0L,8L,3L,6L,6L,9L,3L,8L,8L,8L,9L,0L,4L,6L,6L,3L,6L,7L,6L,3L,7L,5L,9L,3L,9L,9L,4L,1L,6L,2L,5L,9L,9L,2L,0L,8L,7L,2L,7L,8L,7L,3L,2L,5L,4L,0L,3L,7L,9L,1L,6L,5L,3L,5L,9L,8L,1L,0L,2L,5L,1L,2L,5L,7L,5L,0L,2L,9L,4L,2L,8L,6L,0L,8L,7L,8L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198130Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198130.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198130Inst : IEnumerable<long>
{
public static readonly long[] Value=A198130.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198130.Bytes);
public long this[int i]=>Value[i];

public static A198130Inst Instance=new A198130Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198131
{
public static readonly long[] Value={ 4L,5L,8L,0L,6L,1L,0L,8L,6L,8L,3L,0L,8L,3L,8L,0L,4L,8L,9L,0L,4L,1L,5L,6L,4L,9L,0L,0L,2L,3L,1L,2L,5L,5L,1L,2L,7L,0L,2L,4L,9L,8L,7L,8L,6L,0L,0L,9L,3L,5L,4L,9L,1L,0L,7L,2L,4L,6L,7L,3L,8L,6L,2L,7L,8L,9L,3L,1L,6L,8L,3L,4L,2L,1L,8L,1L,7L,8L,3L,0L,4L,3L,6L,0L,4L,6L,3L,6L,2L,8L,4L,6L,3L,6L,3L,6L,6L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198131Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198131.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198131Inst : IEnumerable<long>
{
public static readonly long[] Value=A198131.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198131.Bytes);
public long this[int i]=>Value[i];

public static A198131Inst Instance=new A198131Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198132
{
public static readonly long[] Value={ 1L,5L,3L,4L,9L,8L,6L,3L,2L,2L,6L,2L,0L,3L,0L,7L,2L,0L,5L,9L,6L,9L,6L,6L,2L,5L,2L,0L,2L,0L,1L,4L,1L,4L,6L,4L,6L,5L,4L,0L,8L,2L,1L,6L,5L,4L,7L,0L,5L,9L,7L,1L,6L,5L,0L,7L,7L,5L,9L,7L,1L,3L,7L,3L,8L,6L,3L,2L,5L,9L,7L,9L,0L,1L,2L,8L,7L,4L,8L,9L,8L,8L,8L,9L,7L,7L,8L,2L,4L,6L,8L,0L,7L,1L,3L,5L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198132Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198132.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198132Inst : IEnumerable<long>
{
public static readonly long[] Value=A198132.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198132.Bytes);
public long this[int i]=>Value[i];

public static A198132Inst Instance=new A198132Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198133
{
public static readonly long[] Value={ 5L,9L,3L,7L,8L,0L,8L,1L,2L,6L,7L,9L,1L,5L,9L,0L,3L,7L,6L,6L,0L,8L,1L,6L,4L,5L,5L,6L,1L,0L,9L,9L,4L,7L,8L,4L,6L,8L,2L,5L,0L,7L,3L,4L,4L,8L,9L,8L,0L,6L,8L,7L,9L,9L,6L,6L,1L,0L,5L,7L,3L,4L,5L,7L,0L,3L,4L,7L,3L,5L,1L,7L,4L,8L,9L,9L,2L,7L,6L,1L,0L,6L,0L,3L,6L,9L,0L,2L,9L,3L,1L,1L,7L,3L,8L,6L,8L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198133Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198133.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198133Inst : IEnumerable<long>
{
public static readonly long[] Value=A198133.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198133.Bytes);
public long this[int i]=>Value[i];

public static A198133Inst Instance=new A198133Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198134
{
public static readonly long[] Value={ 1L,5L,3L,9L,9L,9L,5L,2L,2L,7L,2L,6L,6L,8L,3L,9L,0L,8L,1L,8L,0L,5L,9L,8L,8L,5L,8L,0L,2L,0L,4L,0L,5L,4L,2L,5L,3L,5L,5L,4L,3L,3L,5L,8L,2L,9L,2L,4L,3L,1L,7L,9L,4L,9L,6L,0L,9L,4L,6L,6L,9L,4L,6L,6L,3L,8L,4L,5L,0L,1L,2L,5L,0L,3L,2L,8L,3L,5L,1L,3L,8L,9L,7L,0L,5L,5L,5L,3L,7L,9L,3L,3L,0L,0L,3L,6L,7L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198134Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198134.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198134Inst : IEnumerable<long>
{
public static readonly long[] Value=A198134.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198134.Bytes);
public long this[int i]=>Value[i];

public static A198134Inst Instance=new A198134Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198135
{
public static readonly long[] Value={ 6L,9L,7L,5L,3L,4L,5L,5L,5L,2L,2L,8L,4L,1L,2L,9L,9L,3L,7L,9L,5L,1L,7L,4L,0L,6L,6L,2L,5L,2L,1L,2L,9L,8L,8L,7L,4L,6L,5L,4L,7L,9L,0L,3L,6L,1L,1L,5L,3L,4L,4L,7L,5L,7L,6L,5L,0L,6L,4L,9L,3L,5L,8L,6L,6L,2L,0L,1L,5L,2L,5L,6L,1L,6L,3L,4L,3L,2L,5L,0L,2L,2L,8L,7L,2L,3L,3L,1L,4L,5L,0L,3L,7L,7L,5L,7L,0L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198135Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198135.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198135Inst : IEnumerable<long>
{
public static readonly long[] Value=A198135.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198135.Bytes);
public long this[int i]=>Value[i];

public static A198135Inst Instance=new A198135Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198136
{
public static readonly long[] Value={ 8L,5L,8L,7L,6L,9L,7L,1L,3L,6L,9L,7L,6L,1L,4L,4L,2L,1L,1L,9L,3L,1L,0L,4L,3L,2L,1L,8L,1L,0L,5L,3L,3L,0L,8L,6L,1L,1L,8L,5L,6L,5L,7L,7L,3L,4L,6L,8L,7L,1L,4L,7L,4L,5L,8L,5L,1L,7L,3L,6L,1L,6L,4L,0L,8L,0L,2L,9L,2L,2L,0L,6L,4L,7L,4L,8L,6L,2L,6L,4L,9L,1L,8L,3L,9L,5L,6L,3L,6L,3L,9L,4L,4L,5L,2L,3L,6L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198136Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198136.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198136Inst : IEnumerable<long>
{
public static readonly long[] Value=A198136.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198136.Bytes);
public long this[int i]=>Value[i];

public static A198136Inst Instance=new A198136Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198137
{
public static readonly long[] Value={ 2L,4L,7L,6L,6L,1L,6L,9L,7L,4L,0L,6L,6L,8L,1L,7L,0L,8L,1L,0L,1L,9L,2L,7L,2L,6L,4L,1L,7L,3L,2L,2L,4L,7L,7L,4L,8L,4L,0L,2L,1L,0L,1L,7L,7L,8L,4L,7L,1L,8L,8L,6L,3L,1L,2L,1L,4L,1L,4L,7L,7L,7L,8L,9L,2L,1L,6L,0L,7L,4L,0L,2L,1L,6L,0L,6L,7L,7L,5L,5L,2L,1L,6L,4L,6L,7L,3L,7L,0L,4L,4L,9L,7L,2L,1L,9L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198137Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198137.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198137Inst : IEnumerable<long>
{
public static readonly long[] Value=A198137.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198137.Bytes);
public long this[int i]=>Value[i];

public static A198137Inst Instance=new A198137Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198138
{
public static readonly long[] Value={ 1L,4L,4L,7L,0L,5L,7L,1L,5L,1L,0L,4L,1L,6L,5L,5L,0L,7L,8L,7L,7L,9L,4L,7L,1L,6L,8L,1L,4L,4L,9L,8L,8L,0L,6L,2L,7L,5L,0L,5L,7L,7L,2L,9L,3L,2L,5L,5L,0L,6L,3L,6L,8L,9L,6L,4L,8L,9L,5L,3L,3L,6L,2L,9L,5L,4L,9L,4L,1L,3L,3L,4L,8L,1L,0L,8L,7L,4L,9L,3L,3L,3L,4L,4L,2L,9L,6L,6L,7L,5L,8L,2L,5L,8L,1L,5L,7L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198138Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198138.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198138Inst : IEnumerable<long>
{
public static readonly long[] Value=A198138.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198138.Bytes);
public long this[int i]=>Value[i];

public static A198138Inst Instance=new A198138Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198139
{
public static readonly long[] Value={ 5L,8L,1L,7L,2L,0L,0L,7L,9L,7L,3L,1L,6L,5L,9L,7L,2L,2L,8L,4L,2L,8L,6L,5L,9L,2L,3L,2L,7L,1L,4L,8L,8L,2L,7L,4L,9L,0L,7L,5L,9L,9L,1L,9L,8L,4L,9L,2L,8L,9L,2L,5L,9L,8L,6L,9L,8L,4L,4L,3L,4L,7L,2L,5L,8L,1L,1L,3L,0L,3L,7L,5L,4L,1L,9L,5L,2L,2L,4L,1L,8L,7L,9L,2L,9L,8L,8L,4L,1L,3L,4L,0L,5L,2L,8L,0L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198139Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198139.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198139Inst : IEnumerable<long>
{
public static readonly long[] Value=A198139.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198139.Bytes);
public long this[int i]=>Value[i];

public static A198139Inst Instance=new A198139Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198140
{
public static readonly long[] Value={ 1L,2L,5L,3L,6L,1L,0L,6L,2L,9L,1L,6L,6L,5L,3L,9L,5L,8L,6L,3L,0L,7L,8L,4L,2L,4L,6L,6L,9L,4L,5L,2L,8L,3L,6L,2L,9L,0L,4L,8L,3L,2L,4L,7L,5L,0L,4L,3L,8L,3L,7L,1L,0L,9L,8L,0L,1L,6L,4L,0L,4L,1L,5L,6L,2L,6L,9L,3L,3L,9L,6L,8L,3L,2L,5L,3L,3L,8L,1L,0L,4L,3L,4L,3L,6L,1L,8L,3L,7L,6L,4L,0L,4L,0L,0L,9L,1L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198140Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198140.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198140Inst : IEnumerable<long>
{
public static readonly long[] Value=A198140.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198140.Bytes);
public long this[int i]=>Value[i];

public static A198140Inst Instance=new A198140Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198141
{
public static readonly long[] Value={ 2L,9L,9L,1L,5L,5L,6L,4L,2L,3L,8L,9L,7L,8L,6L,3L,5L,6L,2L,5L,7L,2L,7L,2L,2L,6L,4L,8L,2L,4L,8L,2L,2L,0L,3L,1L,6L,6L,9L,8L,5L,0L,9L,3L,6L,1L,0L,2L,4L,7L,3L,4L,2L,9L,4L,1L,6L,9L,7L,2L,9L,1L,2L,9L,6L,6L,4L,2L,0L,4L,8L,6L,1L,7L,9L,0L,1L,0L,8L,8L,4L,7L,2L,4L,5L,1L,2L,0L,5L,8L,3L,1L,8L,1L,3L,8L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198141Inst : IEnumerable<long>
{
public static readonly long[] Value=A198141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198141.Bytes);
public long this[int i]=>Value[i];

public static A198141Inst Instance=new A198141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198142
{
public static readonly long[] Value={ 8L,9L,2L,9L,1L,0L,7L,1L,1L,4L,1L,7L,7L,7L,5L,2L,7L,3L,7L,3L,9L,9L,6L,8L,3L,1L,8L,3L,1L,7L,0L,4L,5L,6L,9L,8L,6L,9L,3L,9L,7L,7L,5L,0L,3L,1L,2L,4L,3L,6L,6L,5L,2L,2L,8L,2L,9L,0L,2L,9L,8L,6L,4L,1L,2L,7L,0L,7L,0L,4L,6L,7L,0L,0L,5L,0L,2L,4L,0L,7L,4L,7L,2L,4L,8L,9L,6L,6L,3L,4L,0L,7L,0L,3L,0L,0L,6L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198142Inst : IEnumerable<long>
{
public static readonly long[] Value=A198142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198142.Bytes);
public long this[int i]=>Value[i];

public static A198142Inst Instance=new A198142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198143
{
public static readonly long[] Value={ 3L,6L,9L,2L,3L,4L,7L,7L,7L,3L,9L,2L,7L,9L,8L,9L,8L,6L,0L,1L,8L,2L,8L,4L,7L,7L,0L,6L,2L,9L,9L,4L,0L,1L,0L,4L,9L,8L,7L,2L,7L,9L,3L,8L,2L,1L,9L,3L,0L,3L,1L,4L,4L,1L,9L,0L,0L,1L,4L,4L,4L,4L,4L,2L,3L,9L,5L,3L,1L,0L,9L,9L,2L,4L,3L,7L,1L,6L,5L,6L,8L,5L,9L,2L,7L,2L,9L,3L,0L,3L,0L,9L,1L,7L,2L,5L,7L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198143Inst : IEnumerable<long>
{
public static readonly long[] Value=A198143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198143.Bytes);
public long this[int i]=>Value[i];

public static A198143Inst Instance=new A198143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198144
{
public static readonly long[] Value={ 6L,9L,6L,5L,8L,5L,8L,4L,7L,7L,7L,9L,0L,6L,5L,8L,0L,1L,9L,8L,6L,5L,9L,2L,4L,3L,4L,6L,3L,2L,7L,5L,4L,3L,5L,8L,8L,5L,5L,9L,0L,0L,5L,4L,6L,0L,3L,5L,9L,3L,5L,5L,5L,7L,7L,8L,4L,6L,5L,4L,9L,7L,8L,7L,6L,5L,8L,8L,3L,8L,9L,3L,3L,9L,9L,4L,9L,1L,0L,8L,6L,8L,4L,8L,8L,2L,3L,0L,7L,8L,6L,1L,8L,6L,4L,0L,5L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198144Inst : IEnumerable<long>
{
public static readonly long[] Value=A198144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198144.Bytes);
public long this[int i]=>Value[i];

public static A198144Inst Instance=new A198144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198145
{
public static readonly long[] Value={ 4L,2L,8L,8L,0L,4L,7L,6L,2L,3L,7L,0L,3L,1L,3L,6L,5L,7L,8L,7L,4L,5L,8L,0L,0L,0L,2L,7L,8L,7L,8L,9L,3L,6L,9L,7L,4L,6L,5L,9L,5L,3L,7L,8L,2L,3L,7L,0L,2L,3L,6L,5L,0L,1L,5L,5L,8L,5L,6L,6L,2L,1L,8L,9L,2L,2L,3L,3L,0L,1L,5L,6L,0L,6L,6L,1L,5L,1L,5L,5L,9L,1L,5L,4L,8L,6L,9L,7L,8L,7L,5L,4L,5L,1L,9L,7L,5L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198145Inst : IEnumerable<long>
{
public static readonly long[] Value=A198145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198145.Bytes);
public long this[int i]=>Value[i];

public static A198145Inst Instance=new A198145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198146
{
public static readonly long[] Value={ 2293L,2393L,2591L,2693L,2791L,2903L,2957L,5297L,5927L,7297L,7927L,8293L,8923L,9203L,9257L,9323L,9521L,9623L,9721L,9923L,12491L,12497L,12907L,12911L,12967L,12973L,13291L,13921L,14293L,14923L,17291L,17293L,17921L,17923L,19207L,19211L,19267L,19273L,19421L,19427L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198146Inst : IEnumerable<long>
{
public static readonly long[] Value=A198146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198146.Bytes);
public long this[int i]=>Value[i];

public static A198146Inst Instance=new A198146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198147
{
public static readonly long[] Value={ 27L,32L,54L,64L,81L,96L,100L,108L,125L,128L,135L,147L,160L,162L,189L,192L,200L,216L,224L,243L,250L,260L,270L,273L,288L,294L,297L,300L,320L,324L,340L,343L,351L,352L,375L,378L,399L,400L,405L,416L,432L,441L,448L,459L,480L,486L,500L,507L,513L,520L,540L,546L,567L,580L,588L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198147Inst : IEnumerable<long>
{
public static readonly long[] Value=A198147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198147.Bytes);
public long this[int i]=>Value[i];

public static A198147Inst Instance=new A198147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198148
{
public static readonly long[] Value={ 0L,3L,1L,15L,3L,35L,6L,63L,10L,99L,15L,143L,21L,195L,28L,255L,36L,323L,45L,399L,55L,483L,66L,575L,78L,675L,91L,783L,105L,899L,120L,1023L,136L,1155L,153L,1295L,171L,1443L,190L,1599L,210L,1763L,231L,1935L,253L,2115L,276L,2303L,300L,2499L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198148Inst : IEnumerable<long>
{
public static readonly long[] Value=A198148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198148.Bytes);
public long this[int i]=>Value[i];

public static A198148Inst Instance=new A198148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198149
{
public static readonly long[] Value={ 1L,7L,54L,2093L,260917L,108428600L,147146211014L,642756367398421L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198149Inst : IEnumerable<long>
{
public static readonly long[] Value=A198149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198149.Bytes);
public long this[int i]=>Value[i];

public static A198149Inst Instance=new A198149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198150
{
public static readonly long[] Value={ 2L,12L,54L,240L,1170L,5330L,24689L,116890L,549479L,2578328L,12131698L,57065922L,268256602L,1261383897L,5931754425L,27891320698L,131147135601L,616682910805L,2899744304684L,13635001788168L,64114012351029L,301474577118884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198150Inst : IEnumerable<long>
{
public static readonly long[] Value=A198150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198150.Bytes);
public long this[int i]=>Value[i];

public static A198150Inst Instance=new A198150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198151
{
public static readonly long[] Value={ 3L,31L,240L,2093L,17991L,145266L,1255491L,10755887L,91079908L,776489747L,6609595197L,56225308358L,478661740841L,4073710243375L,34669903065204L,295087373696575L,2511459871139255L,21374984840018414L,181923479457037295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198151Inst : IEnumerable<long>
{
public static readonly long[] Value=A198151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198151.Bytes);
public long this[int i]=>Value[i];

public static A198151Inst Instance=new A198151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198152
{
public static readonly long[] Value={ 5L,79L,1170L,17991L,260917L,3964286L,61513749L,932035559L,14154918386L,215575583089L,3280040161825L,49908649333492L,759419186812363L,11555623785446115L,175836452139467978L,2675566091089841463L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198152Inst : IEnumerable<long>
{
public static readonly long[] Value=A198152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198152.Bytes);
public long this[int i]=>Value[i];

public static A198152Inst Instance=new A198152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198153
{
public static readonly BigInteger[] Value={ 8L,186L,5330L,145266L,3964286L,108428600L,2969407571L,81119721484L,2220541431613L,60728204921422L,1660150662376018L,45410172854910038L,1241951689613745110L,BigInteger.Parse("33963196923739786489"),BigInteger.Parse("928843844069002393595") };
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
public class A198153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198153Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198153.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198153.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198153Inst Instance=new A198153Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198154
{
public static readonly BigInteger[] Value={ 13L,465L,24689L,1255491L,61513749L,2969407571L,147146211014L,7259079414491L,356611993766901L,17542851737213231L,863257429585871111L,BigInteger.Parse("42468055861968831263"),BigInteger.Parse("2089291751765730194449"),BigInteger.Parse("102792392272753053884368") };
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
public class A198154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198154Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198154.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198154.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198154Inst Instance=new A198154Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198155
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,12L,12L,3L,5L,31L,54L,31L,5L,8L,79L,240L,240L,79L,8L,13L,186L,1170L,2093L,1170L,186L,13L,21L,465L,5330L,17991L,17991L,5330L,465L,21L,34L,1131L,24689L,145266L,260917L,145266L,24689L,1131L,34L,55L,2776L,116890L,1255491L,3964286L,3964286L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198155Inst : IEnumerable<long>
{
public static readonly long[] Value=A198155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198155.Bytes);
public long this[int i]=>Value[i];

public static A198155Inst Instance=new A198155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198156
{
public static readonly long[] Value={ 1L,4L,10L,116L,2862L,51686L,4052747L,435035530L,65207007652L,27807146172472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198156Inst : IEnumerable<long>
{
public static readonly long[] Value=A198156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198156.Bytes);
public long this[int i]=>Value[i];

public static A198156Inst Instance=new A198156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198157
{
public static readonly long[] Value={ 1L,5L,26L,267L,5802L,244365L,19093622L,2937099281L,866588833018L,491355230014545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198157Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198157.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198157Inst : IEnumerable<long>
{
public static readonly long[] Value=A198157.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198157.Bytes);
public long this[int i]=>Value[i];

public static A198157Inst Instance=new A198157Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198158
{
public static readonly long[] Value={ 1L,2L,17L,113L,2211L,79220L,4456377L,560699301L,127364497803L,52948639902295L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198158Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198158.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198158Inst : IEnumerable<long>
{
public static readonly long[] Value=A198158.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198158.Bytes);
public long this[int i]=>Value[i];

public static A198158Inst Instance=new A198158Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198159
{
public static readonly long[] Value={ 1L,4L,13L,134L,2506L,81923L,5913801L,836958994L,235327275156L,133415063651713L,151040737730161989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198159Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198159.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198159Inst : IEnumerable<long>
{
public static readonly long[] Value=A198159.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198159.Bytes);
public long this[int i]=>Value[i];

public static A198159Inst Instance=new A198159Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198160
{
public static readonly long[] Value={ 1L,1L,13L,54L,846L,25780L,859573L,86163253L,12266096117L,3194757527455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198160Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198160.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198160Inst : IEnumerable<long>
{
public static readonly long[] Value=A198160.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198160.Bytes);
public long this[int i]=>Value[i];

public static A198160Inst Instance=new A198160Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198161
{
public static readonly long[] Value={ 4142135623L,8872420969L,9698078569L,7537694807L,7973799073L,7846210703L,2644121497L,9935831413L,6592750559L,7010955997L,1472851741L,5251407989L,2533965463L,5339654633L,6152583523L,1525835239L,3950547457L,5750287759L,5996172983L,4084988471L,6668713013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198161Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198161.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198161Inst : IEnumerable<long>
{
public static readonly long[] Value=A198161.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198161.Bytes);
public long this[int i]=>Value[i];

public static A198161Inst Instance=new A198161Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198162
{
public static readonly long[] Value={ 41L,13L,23L,37L,73L,67L,71L,53L,37L,73L,31L,17L,67L,79L,97L,73L,37L,79L,73L,47L,53L,43L,41L,73L,13L,23L,29L,97L,83L,73L,37L,41L,97L,83L,31L,41L,13L,59L,59L,79L,11L,71L,47L,59L,97L,71L,59L,97L,53L,59L,47L,17L,41L,89L,19L,23L,29L,23L,43L,71L,43L,83L,97L,79L,79L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198162Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198162.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198162Inst : IEnumerable<long>
{
public static readonly long[] Value=A198162.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198162.Bytes);
public long this[int i]=>Value[i];

public static A198162Inst Instance=new A198162Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198163
{
public static readonly long[] Value={ 421L,373L,887L,569L,967L,769L,317L,797L,379L,907L,107L,503L,641L,157L,727L,229L,149L,709L,659L,557L,571L,701L,109L,599L,997L,971L,919L,523L,839L,397L,251L,463L,331L,829L,523L,239L,547L,457L,877L,599L,617L,983L,557L,337L,857L,701L,113L,997L,503L,277L,823L,929L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198163Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198163.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198163Inst : IEnumerable<long>
{
public static readonly long[] Value=A198163.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198163.Bytes);
public long this[int i]=>Value[i];

public static A198163Inst Instance=new A198163Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198164
{
public static readonly long[] Value={ 5623L,7309L,6967L,7187L,8753L,7537L,3769L,6679L,9907L,4621L,8753L,4327L,4157L,2309L,1229L,2297L,3583L,6659L,5927L,5927L,5011L,7027L,2851L,1741L,8609L,4079L,7253L,7457L,7759L,3557L,2203L,5701L,5437L,4603L,8689L,6899L,8999L,7069L,4027L,7823L,9293L,3691L,6311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198164Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198164.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198164Inst : IEnumerable<long>
{
public static readonly long[] Value=A198164.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198164.Bytes);
public long this[int i]=>Value[i];

public static A198164Inst Instance=new A198164Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198165
{
public static readonly long[] Value={ 56237L,37309L,78569L,67187L,48073L,76679L,66797L,97379L,79907L,50387L,34327L,64157L,15727L,91229L,70249L,73721L,12149L,70999L,35831L,65927L,55927L,55799L,11527L,55997L,59971L,86201L,20147L,28517L,88919L,30871L,14321L,45083L,50839L,62603L,51407L,87253L,72533L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198165Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198165.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198165Inst : IEnumerable<long>
{
public static readonly long[] Value=A198165.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198165.Bytes);
public long this[int i]=>Value[i];

public static A198165Inst Instance=new A198165Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198166
{
public static readonly long[] Value={ 135623L,569671L,480731L,850387L,157273L,384623L,585073L,970999L,927557L,275579L,950501L,686201L,450839L,514079L,989687L,872533L,583523L,750287L,759961L,961729L,983557L,752203L,531857L,857011L,570113L,374603L,340849L,868999L,997069L,970699L,900481L,277903L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198166Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198166.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198166Inst : IEnumerable<long>
{
public static readonly long[] Value=A198166.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198166.Bytes);
public long this[int i]=>Value[i];

public static A198166Inst Instance=new A198166Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198167
{
public static readonly long[] Value={ 3562373L,5048801L,2420969L,5038753L,7534327L,6415727L,5073721L,2126441L,2644121L,9709993L,9935831L,2226659L,9275579L,8206057L,5714701L,7027453L,2851741L,8640889L,2145083L,5835239L,3868999L,8689997L,9970699L,9900481L,2779031L,6311159L,6668713L,6871301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198167Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198167.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198167Inst : IEnumerable<long>
{
public static readonly long[] Value=A198167.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198167.Bytes);
public long this[int i]=>Value[i];

public static A198167Inst Instance=new A198167Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198168
{
public static readonly long[] Value={ 42135623L,98078569L,96718753L,76948073L,69480731L,31766797L,76679737L,24784621L,70388503L,64157273L,22970249L,35831413L,75055927L,82060571L,71470109L,55232923L,21450839L,25835239L,23950547L,57502877L,87759961L,18570113L,54374603L,16038689L,38689997L,99970699L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198168Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198168.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198168Inst : IEnumerable<long>
{
public static readonly long[] Value=A198168.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198168.Bytes);
public long this[int i]=>Value[i];

public static A198168Inst Instance=new A198168Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198169
{
public static readonly long[] Value={ 213562373L,488016887L,688724209L,807856967L,718753769L,376948073L,501384623L,470109559L,609552329L,292304843L,260362799L,396546331L,523950547L,877599617L,172983557L,220337531L,570113543L,160386899L,603868999L,782306849L,684929369L,861249497L,124949771L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198169Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198169.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198169Inst : IEnumerable<long>
{
public static readonly long[] Value=A198169.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198169.Bytes);
public long this[int i]=>Value[i];

public static A198169Inst Instance=new A198169Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198170
{
public static readonly long[] Value={ 653L,643L,433L,383L,419L,197L,971L,937L,751L,307L,421L,211L,821L,823L,647L,709L,223L,317L,359L,811L,701L,193L,521L,211L,229L,881L,109L,659L,593L,461L,823L,233L,337L,271L,821L,607L,491L,127L,587L,631L,881L,881L,829L,409L,643L,367L,113L,521L,941L,151L,433L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198170Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198170.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198170Inst : IEnumerable<long>
{
public static readonly long[] Value=A198170.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198170.Bytes);
public long this[int i]=>Value[i];

public static A198170Inst Instance=new A198170Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198171
{
public static readonly long[] Value={ 1592653L,6535897L,2643383L,5028841L,6939937L,3993751L,1170679L,8086513L,5822317L,1725359L,4930381L,2881097L,4612847L,3165271L,2712019L,1201909L,4914127L,1133053L,3841469L,1469519L,6951941L,9433057L,9326117L,4462379L,2749567L,5272489L,8912279L,8183011L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198171Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198171.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198171Inst : IEnumerable<long>
{
public static readonly long[] Value=A198171.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198171.Bytes);
public long this[int i]=>Value[i];

public static A198171Inst Instance=new A198171Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198172
{
public static readonly long[] Value={ 28841971L,41971693L,82534211L,42117067L,30664709L,31725359L,49303819L,75648233L,37867831L,71201909L,48566923L,26648213L,13393607L,25409171L,57595919L,21861173L,81932611L,79962749L,24891227L,30119491L,40656643L,30860213L,39494639L,39522473L,98609437L,53921717L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198172Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198172.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198172Inst : IEnumerable<long>
{
public static readonly long[] Value=A198172.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198172.Bytes);
public long this[int i]=>Value[i];

public static A198172Inst Instance=new A198172Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198173
{
public static readonly long[] Value={ 795028841L,502884197L,884197169L,971693993L,348253421L,421170679L,306647093L,812848111L,659334461L,233786783L,648566923L,346034861L,326648213L,829254091L,678925903L,959195309L,530921861L,938183011L,298336733L,798609437L,717629317L,320005681L,757789609L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198173Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198173.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198173Inst : IEnumerable<long>
{
public static readonly long[] Value=A198173.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198173.Bytes);
public long this[int i]=>Value[i];

public static A198173Inst Instance=new A198173Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198174
{
public static readonly long[] Value={ 5926535897L,4197169399L,1693993751L,7510582097L,4825342117L,5822317253L,2841027019L,8521105559L,8954930381L,4756482337L,2712019091L,5432664821L,3266482133L,6072602491L,5588174881L,8815209209L,6282925409L,2540917153L,5903600113L,8204665213L,3841469519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198174Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198174.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198174Inst : IEnumerable<long>
{
public static readonly long[] Value=A198174.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198174.Bytes);
public long this[int i]=>Value[i];

public static A198174Inst Instance=new A198174Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198175
{
public static readonly long[] Value={ 31L,41L,59L,53L,89L,97L,79L,23L,43L,83L,79L,41L,19L,97L,71L,37L,97L,59L,23L,89L,53L,11L,17L,67L,79L,13L,23L,47L,23L,31L,17L,53L,59L,11L,11L,17L,41L,19L,11L,59L,29L,89L,19L,97L,59L,61L,47L,23L,37L,67L,83L,31L,71L,19L,23L,61L,43L,13L,41L,73L,37L,31L,17L,29L,17L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198175Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198175.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198175Inst : IEnumerable<long>
{
public static readonly long[] Value=A198175.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198175.Bytes);
public long this[int i]=>Value[i];

public static A198175Inst Instance=new A198175Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198176
{
public static readonly long[] Value={ 1L,6L,168L,26880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198176Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198176.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198176Inst : IEnumerable<long>
{
public static readonly long[] Value=A198176.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198176.Bytes);
public long this[int i]=>Value[i];

public static A198176Inst Instance=new A198176Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198177
{
public static readonly long[] Value={ 1772030917L,4189391137L,6222353693L,7931800607L,5959395829L,5829056383L,3832266131L,6131992829L,6892501711L,9250171169L,1043216269L,3136144381L,7587012203L,7954454749L,8509874339L,4487706647L,1240076521L,7780531531L,5315317141L,1704666599L,7046665991L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198177Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198177.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198177Inst : IEnumerable<long>
{
public static readonly long[] Value=A198177.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198177.Bytes);
public long this[int i]=>Value[i];

public static A198177Inst Instance=new A198177Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198178
{
public static readonly long[] Value={ 1L,4L,9L,59L,2033L,51688L,4522496L,559601114L,174674654015L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198178Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198178.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198178Inst : IEnumerable<long>
{
public static readonly long[] Value=A198178.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198178.Bytes);
public long this[int i]=>Value[i];

public static A198178Inst Instance=new A198178Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198179
{
public static readonly long[] Value={ 0L,4L,3L,8L,16L,21L,56L,70L,171L,256L,516L,905L,1622L,3048L,5293L,9992L,17564L,32517L,58330L,106144L,192767L,348188L,634426L,1145535L,2084360L,3771658L,6847617L,12413706L,22507930L,40835531L,74015802L,134288434L,243440863L,441575714L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198179Inst : IEnumerable<long>
{
public static readonly long[] Value=A198179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198179.Bytes);
public long this[int i]=>Value[i];

public static A198179Inst Instance=new A198179Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198180
{
public static readonly long[] Value={ 1L,3L,9L,25L,77L,148L,395L,866L,2346L,5663L,14065L,34309L,84252L,208413L,513352L,1266410L,3117377L,7679699L,18927327L,46639092L,114949605L,283220762L,697929906L,1719783577L,4237987789L,10443340285L,25734497336L,63415169957L,156267786924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198180Inst : IEnumerable<long>
{
public static readonly long[] Value=A198180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198180.Bytes);
public long this[int i]=>Value[i];

public static A198180Inst Instance=new A198180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198181
{
public static readonly long[] Value={ 2L,8L,25L,59L,331L,883L,3485L,12030L,43774L,155664L,540628L,1936313L,6871687L,24471790L,86551688L,306708029L,1089956129L,3870392120L,13733968845L,48703981505L,172844148554L,613561265167L,2177517194687L,7726401450405L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198181Inst : IEnumerable<long>
{
public static readonly long[] Value=A198181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198181.Bytes);
public long this[int i]=>Value[i];

public static A198181Inst Instance=new A198181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198182
{
public static readonly long[] Value={ 1L,16L,77L,331L,2033L,8298L,48958L,216307L,1155412L,5522239L,28200527L,139401115L,695721892L,3477106364L,17307490471L,86498278609L,430707067503L,2150928384789L,10722364479972L,53497634923663L,266813770707004L,1330929200315097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198182Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198182.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198182Inst : IEnumerable<long>
{
public static readonly long[] Value=A198182.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198182.Bytes);
public long this[int i]=>Value[i];

public static A198182Inst Instance=new A198182Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198183
{
public static readonly long[] Value={ 1L,21L,148L,883L,8298L,51688L,395340L,2639341L,19059216L,135044844L,958174742L,6800519266L,48283678834L,342710822044L,2431565681788L,17263106688089L,122543913785532L,869732001977147L,6173405546650902L,43819646823646105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198183Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198183.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198183Inst : IEnumerable<long>
{
public static readonly long[] Value=A198183.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198183.Bytes);
public long this[int i]=>Value[i];

public static A198183Inst Instance=new A198183Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198184
{
public static readonly long[] Value={ 3L,56L,395L,3485L,48958L,395340L,4522496L,41084248L,441157382L,4292509761L,44051823241L,438360876506L,4438621935572L,44610898968447L,449562512780134L,4527350842044875L,45564682527974566L,459054827920170371L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198184Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198184.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198184Inst : IEnumerable<long>
{
public static readonly long[] Value=A198184.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198184.Bytes);
public long this[int i]=>Value[i];

public static A198184Inst Instance=new A198184Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198185
{
public static readonly long[] Value={ 1L,0L,0L,1L,4L,1L,2L,3L,3L,2L,1L,8L,9L,8L,1L,1L,16L,25L,25L,16L,1L,3L,21L,77L,59L,77L,21L,3L,3L,56L,148L,331L,331L,148L,56L,3L,2L,70L,395L,883L,2033L,883L,395L,70L,2L,4L,171L,866L,3485L,8298L,8298L,3485L,866L,171L,4L,6L,256L,2346L,12030L,48958L,51688L,48958L,12030L,2346L,256L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198185Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198185.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198185Inst : IEnumerable<long>
{
public static readonly long[] Value=A198185.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198185.Bytes);
public long this[int i]=>Value[i];

public static A198185Inst Instance=new A198185Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198186
{
public static readonly long[] Value={ 1L,2L,4L,6L,8L,10L,12L,18L,24L,36L,48L,60L,84L,96L,108L,120L,156L,168L,180L,228L,240L,300L,360L,480L,600L,660L,720L,900L,960L,1080L,1320L,1380L,1440L,1620L,1800L,1920L,2160L,2400L,2520L,3360L,3840L,3960L,4320L,4680L,4800L,4860L,5040L,7560L,10080L,12600L,15120L,17640L,20160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198186Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198186.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198186Inst : IEnumerable<long>
{
public static readonly long[] Value=A198186.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198186.Bytes);
public long this[int i]=>Value[i];

public static A198186Inst Instance=new A198186Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198187
{
public static readonly long[] Value={ 3L,31L,41L,5L,59L,4159L,14159L,314159L,2L,5L,3L,53L,653L,1592653L,5L,89L,141592653589L,7L,97L,5897L,35897L,6535897L,5926535897L,415926535897L,79L,58979L,358979L,3L,589793L,2L,3L,23L,9323L,9265358979323L,2L,3L,43L,643L,462643L,93238462643L,3L,433L,3L,83L,383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198187Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198187.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198187Inst : IEnumerable<long>
{
public static readonly long[] Value=A198187.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198187.Bytes);
public long this[int i]=>Value[i];

public static A198187Inst Instance=new A198187Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198188
{
public static readonly BigInteger[] Value={ 2L,7L,71L,271L,2L,281L,2718281L,2L,5L,59L,5L,2L,3L,23L,523L,4523L,904523L,5L,3L,53L,353L,8284590452353L,2L,7L,360287L,28459045235360287L,7L,47L,8747L,6028747L,BigInteger.Parse("8182845904523536028747"),71L,360287471L,BigInteger.Parse("8281828459045235360287471"),3L,13L,74713L,BigInteger.Parse("82818284590452353602874713") };
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
public class A198188Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198188.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198188Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198188.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198188.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198188Inst Instance=new A198188Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198189
{
public static readonly BigInteger[] Value={ 61L,3L,3L,1618033L,7L,887L,9887L,39887L,339887L,1618033988749L,89L,8874989L,398874989L,803398874989L,61803398874989L,2L,5L,3L,83L,683L,458683L,3L,43L,5L,3L,563L,6563L,36563L,868343656381L,BigInteger.Parse("180339887498948482045868343656381"),11L,811L,58683436563811L };
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
public class A198189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198189Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198189.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198189.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198189Inst Instance=new A198189Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198190
{
public static readonly BigInteger[] Value={ 41L,2L,421L,3L,13L,5L,2L,3L,23L,5623L,135623L,42135623L,4142135623L,7L,37L,56237L,3L,73L,373L,3562373L,213562373L,7309L,37309L,5L,5048801L,BigInteger.Parse("414213562373095048801"),7L,887L,488016887L,BigInteger.Parse("142135623730950488016887"),2L,2L,688724209L,BigInteger.Parse("414213562373095048801688724209") };
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
public class A198190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198190Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198190.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198190.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198190Inst Instance=new A198190Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198191
{
public static readonly long[] Value={ 1L,2L,3L,5L,6L,7L,11L,12L,13L,17L,18L,21L,23L,24L,25L,27L,28L,29L,31L,32L,33L,35L,36L,37L,39L,41L,43L,44L,45L,47L,52L,53L,59L,60L,61L,67L,68L,71L,73L,74L,75L,77L,78L,79L,81L,83L,85L,86L,87L,89L,91L,93L,94L,95L,97L,98L,100L,101L,103L,104L,105L,107L,109L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198191Inst : IEnumerable<long>
{
public static readonly long[] Value=A198191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198191.Bytes);
public long this[int i]=>Value[i];

public static A198191Inst Instance=new A198191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198192
{
public static readonly long[] Value={ 0L,1L,1L,5L,2L,8L,9L,18L,5L,15L,16L,29L,19L,34L,36L,54L,12L,30L,31L,52L,34L,57L,59L,85L,41L,68L,70L,100L,75L,107L,110L,145L,27L,61L,62L,99L,65L,104L,106L,148L,72L,115L,117L,163L,122L,170L,173L,224L,87L,138L,140L,194L,145L,201L,204L,263L,156L,216L,219L,282L,226L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198192Inst : IEnumerable<long>
{
public static readonly long[] Value=A198192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198192.Bytes);
public long this[int i]=>Value[i];

public static A198192Inst Instance=new A198192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198193
{
public static readonly long[] Value={ 0L,1L,2L,5L,4L,8L,11L,18L,8L,15L,18L,28L,23L,35L,39L,54L,16L,30L,33L,50L,38L,57L,61L,83L,47L,70L,74L,100L,81L,109L,114L,145L,32L,61L,64L,96L,69L,103L,107L,144L,78L,116L,120L,161L,127L,170L,175L,221L,95L,141L,145L,194L,152L,203L,208L,262L,165L,220L,225L,283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198193Inst : IEnumerable<long>
{
public static readonly long[] Value=A198193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198193.Bytes);
public long this[int i]=>Value[i];

public static A198193Inst Instance=new A198193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198194
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,4L,5L,5L,5L,5L,6L,6L,6L,6L,7L,7L,7L,7L,7L,7L,7L,8L,8L,8L,8L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,10L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,11L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198194Inst : IEnumerable<long>
{
public static readonly long[] Value=A198194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198194.Bytes);
public long this[int i]=>Value[i];

public static A198194Inst Instance=new A198194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198195
{
public static readonly long[] Value={ 509L,31L,7L,7L,7L,19L,13L,3L,3L,3L,97L,11L,17L,41L,41L,11L,2L,313L,2L,2L,137L,2L,2L,281L,227L,149L,149L,197L,281L,191L,101L,569L,191L,857L,827L,311L,569L,599L,431L,599L,1451L,1091L,809L,1019L,419L,1667L,2237L,4517L,5009L,3671L,1997L,1289L,1451L,3329L,3329L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198195Inst : IEnumerable<long>
{
public static readonly long[] Value=A198195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198195.Bytes);
public long this[int i]=>Value[i];

public static A198195Inst Instance=new A198195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198196
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,79L,151L,199L,233L,251L,317L,863L,971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198196Inst : IEnumerable<long>
{
public static readonly long[] Value=A198196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198196.Bytes);
public long this[int i]=>Value[i];

public static A198196Inst Instance=new A198196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198197
{
public static readonly long[] Value={ 1L,1L,0L,-1L,-1L,-1L,-2L,-3L,-3L,-2L,0L,2L,2L,0L,-1L,2L,8L,12L,11L,8L,7L,7L,5L,2L,1L,2L,4L,7L,7L,-3L,-21L,-34L,-34L,-28L,-28L,-37L,-46L,-42L,-22L,-1L,-1L,-28L,-62L,-75L,-60L,-35L,-16L,1L,25L,53L,77L,93L,97L,90L,91L,121L,165L,175L,129L,70L,64L,127L,213L,267L,273L,261L,278L,329L,340L,225L,11L,-155L,-160L,-50L,25L,-40L,-223L,-406L,-475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198197Inst : IEnumerable<long>
{
public static readonly long[] Value=A198197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198197.Bytes);
public long this[int i]=>Value[i];

public static A198197Inst Instance=new A198197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198198
{
public static readonly BigInteger[] Value={ 1L,1L,1L,4L,25L,216L,1561L,19328L,225681L,3790720L,54595921L,1141489152L,20620975849L,519551642624L,11074307974185L,325796967940096L,8068953248603809L,271784019897188352L,7647972455738262817L,BigInteger.Parse("290140183695205990400"),BigInteger.Parse("9154902981606486123321") };
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
public class A198198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198198Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198198.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198198.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198198Inst Instance=new A198198Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198199
{
public static readonly long[] Value={ 1L,0L,-1L,-2L,-2L,-2L,-1L,2L,5L,6L,7L,10L,12L,8L,-1L,-8L,-11L,-16L,-26L,-38L,-50L,-58L,-52L,-30L,-8L,0L,4L,24L,63L,112L,170L,232L,268L,252L,208L,186L,193L,190L,154L,92L,-5L,-164L,-383L,-630L,-873L,-1062L,-1128L,-1080L,-1055L,-1172L,-1374L,-1508L,-1508L,-1392L,-1139L,-700L,-85L,684L,1627L,2652L,3455L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198199Inst : IEnumerable<long>
{
public static readonly long[] Value=A198199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198199.Bytes);
public long this[int i]=>Value[i];

public static A198199Inst Instance=new A198199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198200
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,6L,10L,16L,28L,48L,79L,130L,215L,356L,587L,960L,1566L,2558L,4176L,6804L,11066L,17978L,29198L,47406L,76916L,124716L,202152L,327600L,530775L,859734L,1392265L,2254336L,3649840L,5908632L,9564377L,15480706L,25055322L,40549980L,65624224L,106199306L,171856555L,278099872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198200Inst : IEnumerable<long>
{
public static readonly long[] Value=A198200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198200.Bytes);
public long this[int i]=>Value[i];

public static A198200Inst Instance=new A198200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198201
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,4L,6L,9L,14L,18L,18L,16L,67L,67L,66L,72L,84L,99L,117L,138L,159L,468L,516L,578L,679L,810L,933L,1018L,1072L,1138L,1262L,1448L,4745L,5196L,5851L,6630L,7382L,8031L,8649L,9405L,10409L,11569L,12649L,13530L,14378L,51022L,55567L,60439L,65906L,71953L,78283L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198201Inst : IEnumerable<long>
{
public static readonly long[] Value=A198201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198201.Bytes);
public long this[int i]=>Value[i];

public static A198201Inst Instance=new A198201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198202
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,5L,8L,13L,22L,31L,32L,89L,115L,126L,122L,118L,127L,150L,178L,198L,653L,747L,835L,921L,1011L,1113L,1236L,1377L,1520L,1661L,1823L,6483L,6894L,7584L,8646L,9906L,11074L,11995L,12787L,13752L,15105L,16742L,18316L,19608L,71188L,78144L,84610L,90794L,97895L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198202Inst : IEnumerable<long>
{
public static readonly long[] Value=A198202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198202.Bytes);
public long this[int i]=>Value[i];

public static A198202Inst Instance=new A198202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198203
{
public static readonly BigInteger[] Value={ 1L,1L,2L,5L,19L,160L,3418L,179705L,19488053L,4590422901L,2738580784946L,3583015072969210L,9255051219746866753UL,BigInteger.Parse("56916338252385095986978"),BigInteger.Parse("871826913772059843867743765"),BigInteger.Parse("26753845554560439025697319191184"),BigInteger.Parse("1695956186616651065722319776300825712") };
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
public class A198203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198203Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A198203.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A198203.Bytes);
public BigInteger this[int i]=>Value[i];

public static A198203Inst Instance=new A198203Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A198204
{
public static readonly long[] Value={ 1L,1L,2L,1L,9L,12L,1L,28L,120L,120L,1L,75L,750L,2100L,1680L,1L,186L,3780L,21840L,45360L,30240L,1L,441L,16856L,176400L,705600L,1164240L,665280L,1L,1016L,69552L,1224720L,8316000L,25280640L,34594560L,17297280L,1L,2295L,272250L,7692300L,82577880L,408648240L,998917920L,1167566400L,518918400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A198204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A198204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A198204Inst : IEnumerable<long>
{
public static readonly long[] Value=A198204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A198204.Bytes);
public long this[int i]=>Value[i];

public static A198204Inst Instance=new A198204Inst();

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