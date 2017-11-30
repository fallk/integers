using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A258982
{
public static readonly long[] Value={ 0L,3L,7L,7L,0L,7L,6L,7L,2L,9L,8L,4L,8L,4L,7L,5L,4L,4L,0L,1L,1L,3L,0L,4L,7L,8L,2L,2L,9L,3L,6L,5L,9L,9L,1L,4L,8L,2L,2L,6L,0L,1L,3L,1L,9L,4L,1L,5L,2L,7L,7L,5L,2L,4L,0L,1L,2L,6L,4L,5L,0L,7L,7L,8L,0L,3L,9L,1L,0L,9L,3L,8L,7L,5L,5L,5L,0L,7L,2L,1L,9L,8L,9L,1L,3L,8L,3L,6L,0L,2L,9L,8L,1L,9L,0L,7L,7L,0L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258982Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258982.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258982Inst : IEnumerable<long>
{
public static readonly long[] Value=A258982.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258982.Bytes);
public long this[int i]=>Value[i];

public static A258982Inst Instance=new A258982Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258983
{
public static readonly long[] Value={ 2L,2L,8L,8L,1L,0L,3L,9L,7L,6L,0L,3L,3L,5L,3L,7L,5L,9L,7L,6L,8L,7L,4L,6L,1L,4L,8L,9L,4L,1L,6L,8L,8L,7L,9L,1L,9L,3L,2L,5L,0L,9L,3L,4L,2L,7L,1L,9L,8L,8L,2L,1L,6L,0L,2L,2L,9L,4L,0L,7L,1L,0L,2L,6L,9L,3L,2L,2L,5L,3L,5L,8L,6L,1L,5L,2L,6L,4L,4L,5L,8L,0L,2L,6L,9L,1L,6L,0L,3L,1L,5L,0L,1L,0L,1L,5L,4L,7L,2L,0L,2L,8L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258983Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258983.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258983Inst : IEnumerable<long>
{
public static readonly long[] Value=A258983.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258983.Bytes);
public long this[int i]=>Value[i];

public static A258983Inst Instance=new A258983Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258984
{
public static readonly long[] Value={ 0L,8L,8L,4L,8L,3L,3L,8L,2L,4L,5L,4L,3L,6L,8L,7L,1L,4L,2L,9L,4L,3L,2L,7L,8L,3L,9L,0L,8L,5L,7L,6L,0L,4L,5L,6L,6L,4L,7L,9L,7L,8L,7L,5L,2L,3L,8L,6L,7L,5L,0L,5L,9L,1L,6L,7L,4L,8L,8L,9L,2L,7L,6L,5L,5L,9L,4L,7L,4L,2L,7L,8L,9L,2L,8L,7L,4L,3L,5L,7L,1L,4L,5L,5L,8L,2L,7L,7L,9L,4L,6L,0L,0L,4L,7L,0L,5L,8L,6L,6L,1L,9L,5L,5L,9L,6L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258984Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258984.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258984Inst : IEnumerable<long>
{
public static readonly long[] Value=A258984.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258984.Bytes);
public long this[int i]=>Value[i];

public static A258984Inst Instance=new A258984Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258985
{
public static readonly long[] Value={ 0L,3L,8L,5L,7L,5L,1L,2L,4L,3L,4L,2L,7L,5L,3L,2L,5L,5L,5L,0L,5L,9L,2L,5L,4L,6L,4L,3L,7L,2L,9L,9L,5L,5L,7L,0L,0L,1L,9L,7L,3L,4L,8L,4L,1L,6L,9L,8L,9L,0L,9L,0L,0L,8L,3L,3L,1L,0L,4L,9L,3L,7L,2L,9L,3L,3L,5L,8L,2L,3L,6L,5L,9L,1L,0L,8L,4L,5L,3L,8L,3L,6L,5L,5L,6L,8L,4L,8L,8L,2L,9L,4L,6L,4L,5L,6L,4L,7L,3L,1L,5L,5L,6L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258985Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258985.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258985Inst : IEnumerable<long>
{
public static readonly long[] Value=A258985.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258985.Bytes);
public long this[int i]=>Value[i];

public static A258985Inst Instance=new A258985Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258986
{
public static readonly long[] Value={ 7L,1L,1L,5L,6L,6L,1L,9L,7L,5L,5L,0L,5L,7L,2L,4L,3L,2L,0L,9L,6L,9L,7L,3L,8L,0L,6L,0L,8L,6L,4L,0L,2L,6L,1L,2L,0L,9L,2L,5L,6L,1L,2L,0L,4L,4L,3L,8L,3L,3L,9L,2L,3L,6L,4L,9L,2L,2L,2L,2L,4L,9L,6L,4L,5L,7L,6L,8L,6L,0L,8L,5L,7L,4L,5L,0L,5L,8L,2L,6L,5L,1L,1L,5L,4L,2L,5L,2L,3L,4L,4L,6L,3L,6L,0L,0L,7L,9L,8L,9L,6L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258986Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258986.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258986Inst : IEnumerable<long>
{
public static readonly long[] Value=A258986.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258986.Bytes);
public long this[int i]=>Value[i];

public static A258986Inst Instance=new A258986Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258987
{
public static readonly long[] Value={ 2L,1L,3L,7L,9L,8L,8L,6L,8L,2L,2L,4L,5L,9L,2L,5L,4L,7L,0L,9L,9L,5L,8L,3L,5L,7L,4L,5L,0L,8L,0L,3L,3L,6L,4L,9L,6L,4L,0L,9L,5L,8L,9L,5L,7L,8L,6L,5L,5L,1L,7L,5L,5L,6L,1L,4L,4L,5L,1L,2L,7L,4L,8L,9L,4L,7L,1L,2L,5L,8L,3L,6L,6L,1L,4L,6L,9L,8L,1L,0L,2L,0L,4L,1L,7L,0L,9L,5L,6L,0L,2L,8L,9L,9L,9L,1L,1L,5L,5L,0L,6L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258987Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258987.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258987Inst : IEnumerable<long>
{
public static readonly long[] Value=A258987.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258987.Bytes);
public long this[int i]=>Value[i];

public static A258987Inst Instance=new A258987Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258988
{
public static readonly long[] Value={ 0L,8L,5L,1L,5L,9L,8L,2L,2L,5L,3L,4L,8L,3L,3L,6L,5L,1L,4L,0L,6L,8L,0L,6L,0L,1L,8L,8L,7L,2L,3L,6L,7L,3L,4L,5L,9L,5L,7L,3L,3L,9L,5L,0L,8L,5L,8L,6L,8L,7L,7L,3L,2L,0L,4L,6L,7L,1L,0L,3L,4L,3L,2L,0L,5L,3L,3L,0L,8L,5L,7L,6L,7L,5L,0L,8L,7L,1L,7L,6L,6L,5L,1L,1L,1L,7L,3L,3L,8L,6L,7L,5L,8L,1L,8L,5L,0L,2L,0L,7L,2L,0L,5L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258988Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258988.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258988Inst : IEnumerable<long>
{
public static readonly long[] Value=A258988.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258988.Bytes);
public long this[int i]=>Value[i];

public static A258988Inst Instance=new A258988Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258989
{
public static readonly long[] Value={ 6L,7L,4L,5L,2L,3L,9L,1L,4L,0L,3L,3L,9L,6L,8L,1L,4L,0L,4L,9L,1L,5L,6L,0L,6L,0L,8L,2L,5L,7L,4L,2L,9L,9L,3L,9L,2L,7L,8L,3L,8L,4L,3L,6L,5L,1L,3L,7L,8L,8L,9L,5L,7L,9L,7L,0L,6L,9L,1L,7L,2L,2L,1L,4L,4L,3L,7L,7L,4L,8L,5L,8L,2L,4L,7L,7L,2L,4L,8L,5L,1L,9L,5L,6L,2L,5L,2L,6L,8L,8L,8L,5L,3L,4L,3L,0L,7L,9L,1L,2L,7L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258989Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258989.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258989Inst : IEnumerable<long>
{
public static readonly long[] Value=A258989.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258989.Bytes);
public long this[int i]=>Value[i];

public static A258989Inst Instance=new A258989Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258990
{
public static readonly long[] Value={ 2L,0L,7L,5L,0L,5L,0L,1L,4L,6L,1L,5L,7L,3L,2L,0L,9L,5L,9L,0L,7L,8L,0L,7L,6L,0L,5L,4L,9L,4L,6L,7L,1L,4L,6L,5L,4L,4L,1L,8L,2L,8L,6L,7L,9L,5L,5L,0L,6L,0L,6L,1L,9L,0L,4L,1L,9L,5L,1L,7L,8L,9L,6L,5L,6L,9L,7L,1L,0L,1L,1L,9L,9L,7L,1L,6L,0L,7L,8L,0L,0L,7L,8L,0L,9L,8L,6L,6L,4L,3L,6L,3L,3L,0L,5L,2L,3L,0L,2L,0L,2L,9L,6L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258990Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258990.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258990Inst : IEnumerable<long>
{
public static readonly long[] Value=A258990.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258990.Bytes);
public long this[int i]=>Value[i];

public static A258990Inst Instance=new A258990Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258991
{
public static readonly long[] Value={ 0L,8L,3L,6L,7L,3L,1L,1L,3L,0L,1L,6L,4L,9L,5L,3L,6L,1L,6L,1L,4L,8L,9L,0L,4L,3L,6L,5L,4L,2L,3L,8L,7L,7L,0L,5L,4L,3L,8L,2L,4L,6L,7L,3L,2L,5L,5L,4L,1L,5L,4L,1L,6L,8L,3L,6L,0L,7L,5L,9L,1L,8L,3L,5L,5L,4L,3L,8L,1L,9L,1L,2L,7L,1L,4L,5L,6L,2L,4L,0L,1L,1L,9L,9L,6L,0L,7L,2L,6L,9L,1L,9L,7L,6L,9L,7L,6L,6L,4L,2L,6L,0L,3L,7L,6L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258991Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258991.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258991Inst : IEnumerable<long>
{
public static readonly long[] Value=A258991.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258991.Bytes);
public long this[int i]=>Value[i];

public static A258991Inst Instance=new A258991Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258992
{
public static readonly long[] Value={ 5L,7L,11L,17L,19L,23L,31L,37L,53L,67L,101L,103L,149L,163L,173L,191L,227L,229L,241L,257L,269L,271L,313L,347L,353L,359L,367L,373L,383L,431L,467L,479L,487L,523L,541L,563L,577L,599L,613L,619L,647L,653L,661L,733L,761L,773L,823L,829L,859L,863L,919L,941L,1061L,1087L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258992Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258992.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258992Inst : IEnumerable<long>
{
public static readonly long[] Value=A258992.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258992.Bytes);
public long this[int i]=>Value[i];

public static A258992Inst Instance=new A258992Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258993
{
public static readonly long[] Value={ 1L,1L,3L,1L,6L,5L,1L,10L,15L,7L,1L,15L,35L,28L,9L,1L,21L,70L,84L,45L,11L,1L,28L,126L,210L,165L,66L,13L,1L,36L,210L,462L,495L,286L,91L,15L,1L,45L,330L,924L,1287L,1001L,455L,120L,17L,1L,55L,495L,1716L,3003L,3003L,1820L,680L,153L,19L,1L,66L,715L,3003L,6435L,8008L,6188L,3060L,969L,190L,21L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258993Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258993.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258993Inst : IEnumerable<long>
{
public static readonly long[] Value=A258993.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258993.Bytes);
public long this[int i]=>Value[i];

public static A258993Inst Instance=new A258993Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258994
{
public static readonly BigInteger[] Value={ 1L,2L,12L,192L,4272L,124992L,4531392L,195869952L,9832326912L,562125837312L,36056880110592L,2564230500421632L,200237330428342272L,17032391106795159552UL,BigInteger.Parse("1567547894591436275712"),BigInteger.Parse("155196096043697480466432"),BigInteger.Parse("16447362605632117421309952"),BigInteger.Parse("1857733260790463501532659712") };
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
public class A258994Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258994.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258994Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A258994.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A258994.Bytes);
public BigInteger this[int i]=>Value[i];

public static A258994Inst Instance=new A258994Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258995
{
public static readonly long[] Value={ 0L,5L,11L,10L,4L,29L,35L,41L,14L,431L,599L,78L,15L,38L,201L,191L,25L,382L,186L,43L,19L,65L,94L,3001L,535L,22L,42L,633L,317L,4397L,21L,141L,8L,74L,574L,214L,1286L,61L,253L,247L,1417L,163L,115L,217L,66L,546L,138L,10631L,1997L,51L,12097L,12301L,362L,26L,563L,1013L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258995Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258995.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258995Inst : IEnumerable<long>
{
public static readonly long[] Value=A258995.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258995.Bytes);
public long this[int i]=>Value[i];

public static A258995Inst Instance=new A258995Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258996
{
public static readonly long[] Value={ 1L,2L,3L,6L,7L,4L,5L,10L,11L,8L,9L,14L,15L,12L,13L,26L,27L,24L,25L,30L,31L,28L,29L,18L,19L,16L,17L,22L,23L,20L,21L,42L,43L,40L,41L,46L,47L,44L,45L,34L,35L,32L,33L,38L,39L,36L,37L,58L,59L,56L,57L,62L,63L,60L,61L,50L,51L,48L,49L,54L,55L,52L,53L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258996Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258996.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258996Inst : IEnumerable<long>
{
public static readonly long[] Value=A258996.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258996.Bytes);
public long this[int i]=>Value[i];

public static A258996Inst Instance=new A258996Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258997
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,4L,2L,0L,0L,0L,12L,12L,4L,0L,0L,0L,32L,54L,32L,3L,0L,0L,0L,80L,216L,192L,30L,7L,0L,0L,0L,192L,810L,1024L,225L,84L,4L,0L,0L,0L,448L,2916L,5120L,1500L,756L,56L,12L,0L,0L,0L,1024L,10206L,24576L,9375L,6048L,588L,192L,12L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258997Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258997.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258997Inst : IEnumerable<long>
{
public static readonly long[] Value=A258997.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258997.Bytes);
public long this[int i]=>Value[i];

public static A258997Inst Instance=new A258997Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258998
{
public static readonly long[] Value={ 0L,1L,0L,0L,-1L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,-1L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258998Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258998.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258998Inst : IEnumerable<long>
{
public static readonly long[] Value=A258998.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258998.Bytes);
public long this[int i]=>Value[i];

public static A258998Inst Instance=new A258998Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A258999
{
public static readonly long[] Value={ 512L,6271L,55760L,225215L,219424L,292814L,73734L,112980L,204210L,373950L,691648L,1293909L,2450704L,4696800L,9101720L,17813333L,35142090L,69765156L,139164158L,278562651L,558960096L,1123499142L,2260769566L,4552609547L,9172064656L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A258999Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A258999.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A258999Inst : IEnumerable<long>
{
public static readonly long[] Value=A258999.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A258999.Bytes);
public long this[int i]=>Value[i];

public static A258999Inst Instance=new A258999Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259000
{
public static readonly long[] Value={ 2444L,6271L,21073L,59549L,130296L,263417L,459014L,746902L,1157855L,1747626L,2526699L,3525095L,4828668L,6585115L,8782352L,11515630L,14947529L,19367769L,24856946L,31586776L,39913937L,50417363L,63364419L,79232160L,98809224L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259000Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259000.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259000Inst : IEnumerable<long>
{
public static readonly long[] Value=A259000.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259000.Bytes);
public long this[int i]=>Value[i];

public static A259000Inst Instance=new A259000Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259001
{
public static readonly long[] Value={ 9374L,18341L,55760L,116098L,142316L,191035L,134036L,138255L,135282L,125066L,136926L,137549L,144388L,157396L,164184L,173168L,185086L,194970L,199468L,222173L,221824L,227101L,257586L,254779L,269678L,292721L,283212L,305637L,337320L,325206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259001Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259001.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259001Inst : IEnumerable<long>
{
public static readonly long[] Value=A259001.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259001.Bytes);
public long this[int i]=>Value[i];

public static A259001Inst Instance=new A259001Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259002
{
public static readonly long[] Value={ 34698L,50654L,159480L,225215L,177118L,174655L,49839L,44035L,31798L,31346L,33359L,29874L,33443L,30974L,36017L,28870L,34352L,39506L,30399L,36536L,31808L,32858L,35797L,32346L,35933L,33482L,38527L,31382L,36866L,42022L,32917L,39056L,34330L,35382L,38323L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259002Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259002.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259002Inst : IEnumerable<long>
{
public static readonly long[] Value=A259002.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259002.Bytes);
public long this[int i]=>Value[i];

public static A259002Inst Instance=new A259002Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259003
{
public static readonly long[] Value={ 113474L,131557L,397152L,402742L,219424L,210946L,35404L,30072L,23070L,28125L,28868L,27162L,31876L,24996L,25262L,23934L,28976L,39602L,26248L,29360L,24542L,29960L,30788L,29082L,33796L,26916L,27182L,25854L,30896L,41522L,28168L,31280L,26462L,31880L,32708L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259003Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259003.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259003Inst : IEnumerable<long>
{
public static readonly long[] Value=A259003.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259003.Bytes);
public long this[int i]=>Value[i];

public static A259003Inst Instance=new A259003Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259004
{
public static readonly long[] Value={ 330684L,317141L,915452L,780329L,321144L,292814L,49717L,42876L,35111L,36146L,36695L,38298L,39684L,36974L,37838L,36576L,39450L,40036L,39480L,40734L,38626L,39770L,40339L,41946L,43332L,40622L,41486L,40224L,43098L,43684L,43128L,44382L,42274L,43418L,43987L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259004Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259004.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259004Inst : IEnumerable<long>
{
public static readonly long[] Value=A259004.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259004.Bytes);
public long this[int i]=>Value[i];

public static A259004Inst Instance=new A259004Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259005
{
public static readonly long[] Value={ 914320L,701282L,2005182L,1284465L,431280L,390714L,73734L,61001L,59336L,60827L,60804L,61979L,62070L,63065L,63258L,63274L,64258L,64949L,65852L,66119L,65838L,67774L,67880L,69079L,69174L,70169L,70362L,70378L,71362L,72053L,72956L,73223L,72942L,74878L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259005Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259005.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259005Inst : IEnumerable<long>
{
public static readonly long[] Value=A259005.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259005.Bytes);
public long this[int i]=>Value[i];

public static A259005Inst Instance=new A259005Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259006
{
public static readonly long[] Value={ 512L,2444L,2444L,9374L,6271L,9374L,34698L,18341L,21073L,34698L,113474L,50654L,55760L,59549L,113474L,330684L,131557L,159480L,116098L,130296L,330684L,914320L,317141L,397152L,225215L,142316L,263417L,914320L,2433544L,701282L,915452L,402742L,177118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259006Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259006.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259006Inst : IEnumerable<long>
{
public static readonly long[] Value=A259006.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259006.Bytes);
public long this[int i]=>Value[i];

public static A259006Inst Instance=new A259006Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259007
{
public static readonly long[] Value={ 2444L,6271L,18341L,50654L,131557L,317141L,701282L,1467387L,2896645L,5442921L,9816954L,17096392L,28757926L,47075958L,75218973L,117547715L,179888422L,270566220L,400421776L,584035872L,840159021L,1193892062L,1677629192L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259007Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259007.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259007Inst : IEnumerable<long>
{
public static readonly long[] Value=A259007.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259007.Bytes);
public long this[int i]=>Value[i];

public static A259007Inst Instance=new A259007Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259008
{
public static readonly long[] Value={ 9374L,21073L,55760L,159480L,397152L,915452L,2005182L,4136140L,8078000L,15207697L,27992566L,49262392L,85034718L,144739230L,240912192L,392252878L,631489978L,1002303755L,1565538282L,2411206601L,3673018438L,5530443094L,8228004970L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259008Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259008.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259008Inst : IEnumerable<long>
{
public static readonly long[] Value=A259008.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259008.Bytes);
public long this[int i]=>Value[i];

public static A259008Inst Instance=new A259008Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259009
{
public static readonly long[] Value={ 34698L,59549L,116098L,225215L,402742L,780329L,1284465L,2218382L,3724801L,6307988L,10527894L,17501266L,28940280L,47007866L,75374462L,120165915L,189056785L,293834152L,452340776L,689561240L,1040594004L,1555721598L,2303970789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259009Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259009.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259009Inst : IEnumerable<long>
{
public static readonly long[] Value=A259009.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259009.Bytes);
public long this[int i]=>Value[i];

public static A259009Inst Instance=new A259009Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259010
{
public static readonly long[] Value={ 113474L,130296L,142316L,177118L,219424L,321144L,431280L,628483L,873376L,1362527L,2214712L,3756703L,6398572L,10966607L,18800158L,32013305L,53987880L,90110374L,148705866L,242375398L,390080654L,620094616L,973886800L,1511517279L,2319238662L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259010Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259010.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259010Inst : IEnumerable<long>
{
public static readonly long[] Value=A259010.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259010.Bytes);
public long this[int i]=>Value[i];

public static A259010Inst Instance=new A259010Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259011
{
public static readonly long[] Value={ 330684L,263417L,191035L,174655L,210946L,292814L,390714L,533771L,758616L,1186813L,1933322L,3197780L,5530284L,9922590L,17959560L,32374598L,58050493L,103106308L,180570323L,311315383L,528596275L,884088170L,1456631403L,2365347197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259011Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259011.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259011Inst : IEnumerable<long>
{
public static readonly long[] Value=A259011.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259011.Bytes);
public long this[int i]=>Value[i];

public static A259011Inst Instance=new A259011Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259012
{
public static readonly long[] Value={ 914320L,459014L,134036L,49839L,35404L,49717L,73734L,133352L,251774L,493203L,985500L,1990343L,4028838L,8113534L,16154696L,31673619L,60993464L,115221230L,213437204L,387765033L,691277518L,1210138735L,2081956120L,3523173264L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259012Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259012.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259012Inst : IEnumerable<long>
{
public static readonly long[] Value=A259012.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259012.Bytes);
public long this[int i]=>Value[i];

public static A259012Inst Instance=new A259012Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259013
{
public static readonly long[] Value={ 4L,16L,44L,88L,144L,208L,320L,408L,512L,672L,788L,948L,1096L,1288L,1552L,1768L,1960L,2208L,2456L,2708L,3028L,3384L,3648L,3964L,4348L,4728L,5076L,5448L,5884L,6308L,6708L,7176L,7644L,8240L,8664L,9132L,9764L,10276L,10816L,11404L,11992L,12516L,13264L,13816L,14388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259013Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259013.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259013Inst : IEnumerable<long>
{
public static readonly long[] Value=A259013.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259013.Bytes);
public long this[int i]=>Value[i];

public static A259013Inst Instance=new A259013Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259014
{
public static readonly long[] Value={ 845729L,952649L,1272101L,1313231L,1418681L,2407289L,2948651L,3071561L,3401009L,3672101L,3795011L,4036751L,4041389L,4164299L,5112329L,5514701L,5725859L,6126221L,6202199L,6436379L,6693839L,7433891L,7624769L,7727669L,7767269L,7939259L,8031581L,8421971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259014Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259014.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259014Inst : IEnumerable<long>
{
public static readonly long[] Value=A259014.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259014.Bytes);
public long this[int i]=>Value[i];

public static A259014Inst Instance=new A259014Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259015
{
public static readonly BigInteger[] Value={ 0L,1L,214L,21225L,1688424L,125055400L,9178531200L,687848686448L,53435249786880L,4336107249936384L,368887991492608000L,BigInteger.Parse("32948013484980000000"),BigInteger.Parse("3090086319932923969536"),BigInteger.Parse("304136142049322287011840"),BigInteger.Parse("31382704663810285705887744"),BigInteger.Parse("3390841628447041935421747200"),BigInteger.Parse("383124440688361472000000000000") };
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
public class A259015Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259015.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259015Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259015.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259015.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259015Inst Instance=new A259015Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259016
{
public static readonly long[] Value={ 0L,0L,1L,0L,2L,2L,0L,3L,3L,3L,0L,5L,5L,5L,4L,0L,11L,11L,11L,4L,5L,0L,10L,10L,10L,4L,11L,6L,0L,29L,29L,29L,4L,10L,13L,7L,0L,78L,78L,78L,4L,29L,41L,6L,8L,0L,141L,141L,141L,4L,78L,35L,13L,19L,9L,0L,266L,266L,266L,4L,141L,38L,41L,15L,23L,10L,0L,147L,147L,147L,4L,266L,163L,35L,14L,83L,29L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259016Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259016.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259016Inst : IEnumerable<long>
{
public static readonly long[] Value=A259016.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259016.Bytes);
public long this[int i]=>Value[i];

public static A259016Inst Instance=new A259016Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259017
{
public static readonly BigInteger[] Value={ 0L,1L,172L,17041L,1382400L,104454120L,7801139200L,593322510704L,46672464052224L,3827977546598400L,328664453612830720L,BigInteger.Parse("29590252898580000000"),BigInteger.Parse("2794588822832496508928"),BigInteger.Parse("276747699113763664091136"),BigInteger.Parse("28712738456619366481920000"),BigInteger.Parse("3117500646133634877355274240"),BigInteger.Parse("353783948741967872000000000000") };
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
public class A259017Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259017.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259017Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259017.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259017.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259017Inst Instance=new A259017Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259018
{
public static readonly long[] Value={ 0L,1L,2L,6L,3L,5L,4L,7L,8L,9L,10L,21L,11L,30L,12L,13L,14L,16L,15L,18L,17L,19L,20L,50L,22L,32L,23L,60L,24L,45L,25L,28L,26L,75L,27L,34L,29L,36L,31L,35L,33L,38L,37L,92L,39L,100L,40L,43L,41L,74L,42L,47L,44L,57L,46L,48L,49L,84L,51L,52L,53L,90L,54L,55L,56L,58L,93L,59L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259018Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259018.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259018Inst : IEnumerable<long>
{
public static readonly long[] Value=A259018.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259018.Bytes);
public long this[int i]=>Value[i];

public static A259018Inst Instance=new A259018Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259019
{
public static readonly long[] Value={ 0L,2L,1L,4L,3L,5L,6L,11L,7L,9L,8L,13L,10L,15L,12L,16L,14L,23L,17L,20L,18L,25L,19L,21L,22L,31L,24L,30L,26L,29L,27L,35L,28L,34L,32L,38L,33L,48L,36L,37L,39L,41L,40L,44L,42L,53L,43L,50L,45L,46L,47L,55L,49L,52L,51L,57L,54L,66L,56L,60L,58L,63L,59L,62L,61L,78L,64L,84L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259019Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259019.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259019Inst : IEnumerable<long>
{
public static readonly long[] Value=A259019.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259019.Bytes);
public long this[int i]=>Value[i];

public static A259019Inst Instance=new A259019Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259020
{
public static readonly long[] Value={ 1L,6L,10L,14L,26L,74L,94L,134L,146L,206L,314L,326L,386L,466L,576L,634L,674L,1094L,1174L,1294L,1306L,1354L,1366L,1546L,1654L,1766L,1774L,1894L,1966L,2026L,2126L,2174L,2326L,2594L,2654L,2746L,2916L,2974L,2986L,3046L,3106L,3134L,3136L,3214L,3254L,3274L,3314L,3326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259020Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259020.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259020Inst : IEnumerable<long>
{
public static readonly long[] Value=A259020.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259020.Bytes);
public long this[int i]=>Value[i];

public static A259020Inst Instance=new A259020Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259021
{
public static readonly long[] Value={ 1L,6L,10L,14L,26L,74L,94L,134L,146L,206L,314L,326L,386L,466L,634L,674L,1094L,1174L,1294L,1306L,1354L,1366L,1546L,1654L,1766L,1774L,1894L,1966L,2026L,2126L,2174L,2326L,2594L,2654L,2746L,2974L,2986L,3046L,3106L,3134L,3214L,3254L,3274L,3314L,3326L,3334L,3446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259021Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259021.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259021Inst : IEnumerable<long>
{
public static readonly long[] Value=A259021.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259021.Bytes);
public long this[int i]=>Value[i];

public static A259021Inst Instance=new A259021Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259022
{
public static readonly long[] Value={ 1L,-1L,-1L,1L,0L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,0L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,0L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,0L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,0L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,0L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,0L,-1L,1L,1L,-1L,1L,-1L,-1L,1L,0L,-1L,1L,1L,-1L,1L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259022Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259022.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259022Inst : IEnumerable<long>
{
public static readonly long[] Value=A259022.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259022.Bytes);
public long this[int i]=>Value[i];

public static A259022Inst Instance=new A259022Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259023
{
public static readonly long[] Value={ 24L,54L,56L,88L,154L,174L,238L,248L,266L,296L,328L,374L,378L,430L,442L,472L,488L,494L,498L,510L,568L,582L,584L,680L,710L,730L,742L,786L,856L,874L,894L,918L,962L,986L,1038L,1246L,1270L,1406L,1434L,1442L,1446L,1542L,1558L,1586L,1598L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259023Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259023.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259023Inst : IEnumerable<long>
{
public static readonly long[] Value=A259023.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259023.Bytes);
public long this[int i]=>Value[i];

public static A259023Inst Instance=new A259023Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259024
{
public static readonly long[] Value={ 1L,0L,-1L,1L,-1L,0L,1L,0L,0L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,1L,-1L,-1L,0L,-1L,0L,1L,0L,0L,1L,-1L,0L,1L,0L,1L,0L,-1L,0L,1L,0L,-1L,0L,-1L,0L,1L,-1L,0L,0L,-1L,-1L,1L,0L,1L,1L,-1L,0L,1L,0L,-1L,0L,-1L,1L,1L,0L,0L,1L,-1L,0L,1L,-1L,1L,0L,-1L,0L,1L,0L,-1L,1L,-1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259024Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259024.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259024Inst : IEnumerable<long>
{
public static readonly long[] Value=A259024.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259024.Bytes);
public long this[int i]=>Value[i];

public static A259024Inst Instance=new A259024Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259025
{
public static readonly long[] Value={ 420L,1050L,2028L,2730L,3582L,4230L,4242L,4272L,4338L,6090L,6132L,6690L,6792L,8220L,11058L,11160L,11970L,12252L,15288L,19542L,19698L,21588L,21600L,26892L,27540L,28098L,28308L,29400L,30840L,30870L,31080L,32412L,42072L,45318L,47808L,48120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259025Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259025.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259025Inst : IEnumerable<long>
{
public static readonly long[] Value=A259025.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259025.Bytes);
public long this[int i]=>Value[i];

public static A259025Inst Instance=new A259025Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259026
{
public static readonly long[] Value={ 1L,2L,6L,8L,18L,21L,24L,26L,28L,30L,33L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259026Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259026.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259026Inst : IEnumerable<long>
{
public static readonly long[] Value=A259026.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259026.Bytes);
public long this[int i]=>Value[i];

public static A259026Inst Instance=new A259026Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259027
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,5L,2L,3L,1L,19L,1L,5L,7L,85L,1L,323L,1L,479L,11L,9L,1L,7855L,4L,11L,64L,3849L,1L,533387L,1L,22229L,19L,15L,23L,2144111L,1L,17L,23L,12790847L,1L,53953727L,1L,153845L,23146L,21L,1L,2785982603L,6L,269757L,31L,861171L,1L,110066119L,39L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259027Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259027.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259027Inst : IEnumerable<long>
{
public static readonly long[] Value=A259027.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259027.Bytes);
public long this[int i]=>Value[i];

public static A259027Inst Instance=new A259027Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259028
{
public static readonly long[] Value={ 25L,29L,12L,26L,131L,42L,106L,8L,63L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259028Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259028.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259028Inst : IEnumerable<long>
{
public static readonly long[] Value=A259028.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259028.Bytes);
public long this[int i]=>Value[i];

public static A259028Inst Instance=new A259028Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259029
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,1L,1L,1L,0L,-1L,0L,0L,1L,2L,1L,1L,2L,1L,0L,0L,-1L,-1L,0L,0L,0L,1L,0L,0L,1L,1L,2L,2L,1L,1L,2L,2L,1L,1L,0L,0L,1L,0L,0L,0L,-1L,-2L,-1L,-1L,0L,1L,0L,0L,1L,1L,0L,0L,-1L,0L,1L,1L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,2L,2L,1L,2L,1L,1L,2L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259029Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259029.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259029Inst : IEnumerable<long>
{
public static readonly long[] Value=A259029.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259029.Bytes);
public long this[int i]=>Value[i];

public static A259029Inst Instance=new A259029Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259030
{
public static readonly long[] Value={ 1L,-1L,-1L,0L,0L,1L,-1L,-1L,1L,0L,1L,0L,-1L,1L,0L,0L,-1L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,0L,1L,0L,1L,-1L,-1L,1L,0L,0L,-1L,-1L,1L,0L,1L,-1L,-1L,0L,0L,1L,-1L,0L,1L,0L,1L,0L,-1L,1L,0L,1L,-1L,-1L,1L,0L,1L,-1L,-1L,0L,0L,1L,-1L,0L,1L,0L,1L,-1L,-1L,1L,0L,0L,-1L,-1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259030Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259030.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259030Inst : IEnumerable<long>
{
public static readonly long[] Value=A259030.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259030.Bytes);
public long this[int i]=>Value[i];

public static A259030Inst Instance=new A259030Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259031
{
public static readonly long[] Value={ 3L,1L,16L,192L,768L,3072L,12288L,49152L,196608L,786432L,3145728L,12582912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259031Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259031.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259031Inst : IEnumerable<long>
{
public static readonly long[] Value=A259031.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259031.Bytes);
public long this[int i]=>Value[i];

public static A259031Inst Instance=new A259031Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259032
{
public static readonly long[] Value={ 29L,38L,40L,44L,49L,80L,143L,148L,166L,191L,197L,233L,251L,269L,272L,283L,305L,314L,326L,335L,364L,371L,373L,389L,425L,427L,431L,461L,470L,497L,515L,517L,553L,557L,562L,602L,614L,616L,625L,634L,638L,647L,652L,656L,659L,661L,677L,683L,692L,731L,749L,758L,800L,812L,845L,863L,908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259032Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259032.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259032Inst : IEnumerable<long>
{
public static readonly long[] Value=A259032.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259032.Bytes);
public long this[int i]=>Value[i];

public static A259032Inst Instance=new A259032Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259033
{
public static readonly long[] Value={ 1L,6L,23L,76L,221L,584L,1443L,3368L,7497L,16046L,33190L,66628L,130288L,248858L,465387L,853836L,1539425L,2731462L,4775703L,8236856L,14027754L,23609794L,39301171L,64747876L,105638153L,170778512L,273704800L,435079524L,686237877L,1074405242L,1670333294L,2579418528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259033Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259033.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259033Inst : IEnumerable<long>
{
public static readonly long[] Value=A259033.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259033.Bytes);
public long this[int i]=>Value[i];

public static A259033Inst Instance=new A259033Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259034
{
public static readonly long[] Value={ 170669145704411L,597655503030737L,1209758169609917L,1529543606818727L,1980326398382819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259034Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259034.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259034Inst : IEnumerable<long>
{
public static readonly long[] Value=A259034.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259034.Bytes);
public long this[int i]=>Value[i];

public static A259034Inst Instance=new A259034Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259035
{
public static readonly long[] Value={ 2L,9L,20L,49L,66L,169L,306L,437L,460L,609L,682L,999L,1066L,1247L,1410L,1537L,1770L,2257L,2814L,2911L,3504L,3871L,3984L,4183L,5432L,7575L,7622L,8239L,8502L,9379L,9398L,10611L,10960L,11537L,11920L,12231L,12874L,12877L,14028L,14359L,15036L,17557L,17954L,19107L,20488L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259035Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259035.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259035Inst : IEnumerable<long>
{
public static readonly long[] Value=A259035.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259035.Bytes);
public long this[int i]=>Value[i];

public static A259035Inst Instance=new A259035Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259036
{
public static readonly long[] Value={ 1L,2L,5L,5L,17L,13L,37L,10L,13L,41L,101L,61L,29L,17L,197L,113L,257L,29L,25L,181L,401L,26L,97L,53L,577L,313L,677L,73L,157L,421L,53L,37L,41L,109L,89L,613L,1297L,137L,85L,761L,1601L,58L,353L,50L,149L,1013L,73L,65L,461L,1201L,61L,1301L,541L,281L,2917L,89L,3137L,65L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259036Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259036.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259036Inst : IEnumerable<long>
{
public static readonly long[] Value=A259036.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259036.Bytes);
public long this[int i]=>Value[i];

public static A259036Inst Instance=new A259036Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259037
{
public static readonly long[] Value={ 48L,56L,192L,248L,252L,328L,448L,496L,768L,1016L,1792L,2032L,3240L,6462L,7936L,8128L,11616L,11808L,17412L,20538L,49152L,65528L,114688L,131056L,507904L,524224L,786432L,1048568L,1835008L,2080768L,2096896L,2097136L,3145728L,4194296L,7340032L,8126464L,8388544L,8388592L,32505856L,33292288L,33554176L,33554368L,133169152L,134217472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259037Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259037.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259037Inst : IEnumerable<long>
{
public static readonly long[] Value=A259037.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259037.Bytes);
public long this[int i]=>Value[i];

public static A259037Inst Instance=new A259037Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259038
{
public static readonly long[] Value={ 48L,192L,252L,448L,768L,1792L,3240L,7936L,11616L,11808L,49152L,114688L,507904L,786432L,1835008L,2080768L,3145728L,7340032L,8126464L,32505856L,33292288L,133169152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259038Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259038.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259038Inst : IEnumerable<long>
{
public static readonly long[] Value=A259038.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259038.Bytes);
public long this[int i]=>Value[i];

public static A259038Inst Instance=new A259038Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259039
{
public static readonly long[] Value={ 56L,248L,328L,496L,1016L,2032L,6462L,8128L,17412L,20538L,65528L,131056L,524224L,1048568L,2097136L,2096896L,4194296L,8388592L,8388544L,33554368L,33554176L,134217472L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259039Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259039.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259039Inst : IEnumerable<long>
{
public static readonly long[] Value=A259039.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259039.Bytes);
public long this[int i]=>Value[i];

public static A259039Inst Instance=new A259039Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259040
{
public static readonly long[] Value={ 12L,15L,21L,33L,60L,75L,84L,93L,123L,186L,264L,327L,384L,519L,651L,654L,678L,726L,753L,762L,771L,807L,831L,852L,870L,897L,924L,975L,993L,1023L,1029L,1056L,1110L,1122L,1128L,1149L,1194L,1203L,1248L,1257L,1272L,1290L,1302L,1308L,1317L,1347L,1407L,1437L,1443L,1464L,1482L,1524L,1527L,1533L,1554L,1581L,1644L,1662L,1677L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259040Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259040.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259040Inst : IEnumerable<long>
{
public static readonly long[] Value=A259040.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259040.Bytes);
public long this[int i]=>Value[i];

public static A259040Inst Instance=new A259040Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259041
{
public static readonly long[] Value={ 26L,31L,58L,71L,89L,107L,112L,116L,157L,161L,193L,211L,247L,310L,337L,395L,458L,490L,503L,535L,580L,584L,620L,688L,769L,778L,841L,850L,859L,868L,872L,877L,895L,949L,985L,989L,1034L,1070L,1079L,1102L,1106L,1133L,1138L,1142L,1192L,1201L,1210L,1214L,1219L,1232L,1255L,1277L,1282L,1295L,1300L,1327L,1412L,1493L,1511L,1538L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259041Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259041.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259041Inst : IEnumerable<long>
{
public static readonly long[] Value=A259041.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259041.Bytes);
public long this[int i]=>Value[i];

public static A259041Inst Instance=new A259041Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259042
{
public static readonly long[] Value={ 0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L,1L,0L,1L,1L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259042Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259042.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259042Inst : IEnumerable<long>
{
public static readonly long[] Value=A259042.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259042.Bytes);
public long this[int i]=>Value[i];

public static A259042Inst Instance=new A259042Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259043
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,1L,3L,5L,7L,9L,11L,13L,15L,17L,10L,2L,4L,6L,8L,10L,12L,14L,16L,9L,12L,3L,5L,7L,9L,11L,13L,15L,8L,11L,14L,4L,6L,8L,10L,12L,14L,7L,10L,13L,16L,5L,7L,9L,11L,13L,6L,9L,12L,15L,18L,6L,8L,10L,12L,5L,8L,11L,14L,17L,20L,7L,9L,11L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259043Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259043.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259043Inst : IEnumerable<long>
{
public static readonly long[] Value=A259043.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259043.Bytes);
public long this[int i]=>Value[i];

public static A259043Inst Instance=new A259043Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259044
{
public static readonly long[] Value={ 0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L,1L,0L,1L,0L,1L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259044Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259044.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259044Inst : IEnumerable<long>
{
public static readonly long[] Value=A259044.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259044.Bytes);
public long this[int i]=>Value[i];

public static A259044Inst Instance=new A259044Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259045
{
public static readonly long[] Value={ 7L,9L,11L,17L,21L,27L,29L,39L,43L,45L,67L,145L,173L,613L,833L,1449L,1703L,1719L,2673L,19661L,36095L,37837L,37845L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259045Inst : IEnumerable<long>
{
public static readonly long[] Value=A259045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259045.Bytes);
public long this[int i]=>Value[i];

public static A259045Inst Instance=new A259045Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259046
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,19L,15L,25L,16L,26L,17L,27L,18L,59L,78L,69L,88L,79L,98L,89L,108L,99L,509L,618L,609L,718L,709L,818L,809L,918L,909L,5009L,6018L,6009L,7018L,7009L,8018L,8009L,9018L,9009L,50009L,60018L,60009L,70018L,70009L,80018L,80009L,90018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259046Inst : IEnumerable<long>
{
public static readonly long[] Value=A259046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259046.Bytes);
public long this[int i]=>Value[i];

public static A259046Inst Instance=new A259046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259047
{
public static readonly long[] Value={ 28749L,21757820799L,4373079629403L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259047Inst : IEnumerable<long>
{
public static readonly long[] Value=A259047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259047.Bytes);
public long this[int i]=>Value[i];

public static A259047Inst Instance=new A259047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259048
{
public static readonly BigInteger[] Value={ 1L,2L,4L,12L,92L,6636L,42839036L,1834614576635532L,BigInteger.Parse("3365810487617338033584723922844"),BigInteger.Parse("11328680238554850474377984661704304183660014108982249765031212") };
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
public class A259048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259048Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259048.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259048.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259048Inst Instance=new A259048Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259049
{
public static readonly BigInteger[] Value={ 1L,4L,400L,960400L,54218191104L,71410553858811024L,BigInteger.Parse("2186315392560559723530496"),BigInteger.Parse("1552832545847343203950118294425600"),BigInteger.Parse("25554649541466337940020968722797075170918400"),BigInteger.Parse("9736551559782513812975251884508283964266367033264640000") };
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
public class A259049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259049Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259049.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259049.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259049Inst Instance=new A259049Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259050
{
public static readonly long[] Value={ 1L,2L,4L,6L,94L,160L,360L,1470L,2898L,3094L,3112L,15698L,17956L,42262L,111032L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259050Inst : IEnumerable<long>
{
public static readonly long[] Value=A259050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259050.Bytes);
public long this[int i]=>Value[i];

public static A259050Inst Instance=new A259050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259051
{
public static readonly long[] Value={ 1L,1L,4L,1L,18L,27L,1L,68L,288L,256L,1L,250L,2250L,5000L,3125L,1L,922L,15795L,65880L,97200L,46656L,1L,3430L,105987L,739508L,1932805L,2117682L,823543L,1L,12868L,696864L,7653632L,31539200L,59179008L,51380224L,16777216L,1L,48618L,4540968L,75687696L,461828790L,1320099444L,1919564892L,1377495072L,387420489L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259051Inst : IEnumerable<long>
{
public static readonly long[] Value=A259051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259051.Bytes);
public long this[int i]=>Value[i];

public static A259051Inst Instance=new A259051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259052
{
public static readonly long[] Value={ 3L,4L,4L,4L,5L,6L,8L,6L,5L,6L,8L,13L,12L,13L,8L,6L,7L,10L,19L,20L,26L,20L,19L,10L,7L,8L,12L,26L,30L,45L,40L,45L,30L,26L,12L,8L,9L,14L,34L,42L,71L,70L,90L,70L,71L,42L,34L,14L,9L,10L,16L,43L,56L,105L,112L,161L,140L,161L,112L,105L,56L,43L,16L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259052Inst : IEnumerable<long>
{
public static readonly long[] Value=A259052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259052.Bytes);
public long this[int i]=>Value[i];

public static A259052Inst Instance=new A259052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259053
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,0L,3L,2L,4L,1L,11L,2L,17L,6L,8L,9L,32L,6L,42L,12L,22L,15L,64L,12L,56L,25L,49L,25L,107L,12L,124L,51L,64L,45L,86L,27L,180L,59L,91L,45L,225L,30L,250L,81L,96L,87L,302L,55L,263L,82L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259053Inst : IEnumerable<long>
{
public static readonly long[] Value=A259053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259053.Bytes);
public long this[int i]=>Value[i];

public static A259053Inst Instance=new A259053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259054
{
public static readonly long[] Value={ 19L,27L,43L,67L,99L,139L,187L,243L,307L,379L,459L,547L,643L,747L,859L,979L,1107L,1243L,1387L,1539L,1699L,1867L,2043L,2227L,2419L,2619L,2827L,3043L,3267L,3499L,3739L,3987L,4243L,4507L,4779L,5059L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259054Inst : IEnumerable<long>
{
public static readonly long[] Value=A259054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259054.Bytes);
public long this[int i]=>Value[i];

public static A259054Inst Instance=new A259054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259055
{
public static readonly long[] Value={ 7L,34L,79L,142L,223L,322L,439L,574L,727L,898L,1087L,1294L,1519L,1762L,2023L,2302L,2599L,2914L,3247L,3598L,3967L,4354L,4759L,5182L,5623L,6082L,6559L,7054L,7567L,8098L,8647L,9214L,9799L,10402L,11023L,11662L,12319L,12994L,13687L,14398L,15127L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259055Inst : IEnumerable<long>
{
public static readonly long[] Value=A259055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259055.Bytes);
public long this[int i]=>Value[i];

public static A259055Inst Instance=new A259055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259056
{
public static readonly long[] Value={ 1L,-3L,-16L,60L,384L,-1680L,-12288L,60480L,491520L,-2661120L,-23592960L,138378240L,1321205760L,-8302694400L,-84557168640L,564583219200L,6088116142080L,-42908324659200L,-487049291366400L,3604299271372800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259056Inst : IEnumerable<long>
{
public static readonly long[] Value=A259056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259056.Bytes);
public long this[int i]=>Value[i];

public static A259056Inst Instance=new A259056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259057
{
public static readonly BigInteger[] Value={ -1L,20L,-560L,20160L,-887040L,46126080L,-2767564800L,188194406400L,-14302774886400L,1201433090457600L,-110531844322099200L,11053184432209920000UL,BigInteger.Parse("-1193743918678671360000"),BigInteger.Parse("138474294566725877760000"),BigInteger.Parse("-17170812526274008842240000") };
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
public class A259057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259057Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259057.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259057.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259057Inst Instance=new A259057Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259058
{
public static readonly long[] Value={ 454L,530L,614L,706L,806L,914L,1030L,1154L,1286L,1426L,1574L,1730L,1894L,2066L,2246L,2434L,2630L,2834L,3046L,3266L,3494L,3730L,3974L,4226L,4486L,4754L,5030L,5314L,5606L,5906L,6214L,6530L,6854L,7186L,7526L,7874L,8230L,8594L,8966L,9346L,9734L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259058Inst : IEnumerable<long>
{
public static readonly long[] Value=A259058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259058.Bytes);
public long this[int i]=>Value[i];

public static A259058Inst Instance=new A259058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259059
{
public static readonly long[] Value={ 227L,265L,307L,353L,403L,457L,515L,577L,643L,713L,787L,865L,947L,1033L,1123L,1217L,1315L,1417L,1523L,1633L,1747L,1865L,1987L,2113L,2243L,2377L,2515L,2657L,2803L,2953L,3107L,3265L,3427L,3593L,3763L,3937L,4115L,4297L,4483L,4673L,4867L,5065L,5267L,5473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259059Inst : IEnumerable<long>
{
public static readonly long[] Value=A259059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259059.Bytes);
public long this[int i]=>Value[i];

public static A259059Inst Instance=new A259059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259060
{
public static readonly long[] Value={ 6426L,7900L,9614L,11592L,13858L,16436L,19350L,22624L,26282L,30348L,34846L,39800L,45234L,51172L,57638L,64656L,72250L,80444L,89262L,98728L,108866L,119700L,131254L,143552L,156618L,170476L,185150L,200664L,217042L,234308L,252486L,271600L,291674L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259060Inst : IEnumerable<long>
{
public static readonly long[] Value=A259060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259060.Bytes);
public long this[int i]=>Value[i];

public static A259060Inst Instance=new A259060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259061
{
public static readonly long[] Value={ 40L,60L,20L,30L,10L,410L,430L,420L,460L,440L,640L,660L,620L,630L,610L,210L,230L,220L,260L,240L,340L,360L,320L,330L,310L,710L,730L,720L,760L,740L,540L,560L,520L,530L,510L,110L,130L,120L,160L,140L,4140L,4160L,4120L,4130L,4110L,4510L,4530L,4520L,4560L,4540L,4740L,4760L,4720L,4730L,4710L,4310L,4330L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259061Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259061.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259061Inst : IEnumerable<long>
{
public static readonly long[] Value=A259061.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259061.Bytes);
public long this[int i]=>Value[i];

public static A259061Inst Instance=new A259061Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259062
{
public static readonly BigInteger[] Value={ 1L,4L,42L,728L,17630L,548532L,20852370L,936655792L,48540537702L,2850727359500L,187107038833946L,13572973331551944L,1078343465147156910L,BigInteger.Parse("93119965280416893028"),BigInteger.Parse("8684514946963752624930"),BigInteger.Parse("869915871265946242868576"),BigInteger.Parse("93146889134541855185069942"),BigInteger.Parse("10617155946603647157142073916") };
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
public class A259062Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259062.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259062Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259062.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259062.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259062Inst Instance=new A259062Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259063
{
public static readonly BigInteger[] Value={ 1L,4L,54L,1208L,37810L,1521252L,74800558L,4346473840L,291409650378L,22142153337500L,1880332153123270L,176486211108436968L,18142303135426278562UL,BigInteger.Parse("2027140583610836224468"),BigInteger.Parse("244622970048028087152990"),BigInteger.Parse("31706140285613089502561504"),BigInteger.Parse("4392907300768938557656691194"),BigInteger.Parse("647905974466168686991684285836") };
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
public class A259063Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259063.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259063Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259063.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259063.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259063Inst Instance=new A259063Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259064
{
public static readonly BigInteger[] Value={ 1L,6L,117L,3792L,172005L,10030248L,714843885L,60207412128L,5850995291397L,644410711219800L,79322681596610661L,10791841135527454896UL,BigInteger.Parse("1608054016025580893445"),BigInteger.Parse("260445389091217967677992"),BigInteger.Parse("45557042043723212142506205"),BigInteger.Parse("8559094926999510089793332544"),BigInteger.Parse("1718950045690606262911636792677") };
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
public class A259064Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259064.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259064Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259064.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259064.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259064Inst Instance=new A259064Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259065
{
public static readonly BigInteger[] Value={ 1L,8L,204L,8656L,514100L,39254904L,3663341724L,404021632928L,51413304278916L,7414832746025800L,1195170934203398636L,BigInteger.Parse("212923233266007511152"),BigInteger.Parse("41545466670049713766356"),BigInteger.Parse("8811212141812890158250776"),BigInteger.Parse("2018230889016461893216938300"),BigInteger.Parse("496523506149784085749952075584"),BigInteger.Parse("130578628540561635331879674437156") };
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
public class A259065Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259065.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259065Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259065.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259065.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259065Inst Instance=new A259065Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259066
{
public static readonly BigInteger[] Value={ 1L,10L,315L,16520L,1212775L,114465780L,13204213435L,1800094703440L,283154358503295L,50478562633826300L,10057594831485171355UL,BigInteger.Parse("2214859039031666012760"),BigInteger.Parse("534202513174577053611415"),BigInteger.Parse("140048168049127802257998820"),BigInteger.Parse("39652657811418543065286846075"),BigInteger.Parse("12058716801545122639605896216480") };
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
public class A259066Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259066.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259066Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259066.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259066.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259066Inst Instance=new A259066Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259067
{
public static readonly long[] Value={ 5L,11L,16L,13L,14L,11L,5L,11L,11L,14L,14L,16L,8L,7L,14L,11L,17L,17L,16L,19L,20L,13L,16L,14L,16L,13L,22L,13L,14L,13L,19L,23L,14L,16L,16L,14L,17L,13L,14L,17L,14L,20L,23L,10L,11L,16L,17L,19L,20L,20L,23L,23L,23L,11L,13L,20L,13L,20L,17L,19L,10L,19L,13L,14L,16L,20L,10L,10L,13L,10L,13L,10L,13L,13L,19L,17L,13L,11L,14L,14L,14L,22L,16L,19L,20L,16L,20L,19L,20L,19L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259067Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259067.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259067Inst : IEnumerable<long>
{
public static readonly long[] Value=A259067.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259067.Bytes);
public long this[int i]=>Value[i];

public static A259067Inst Instance=new A259067Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259068
{
public static readonly long[] Value={ 0L,0L,5L,3L,7L,8L,5L,7L,6L,3L,5L,7L,7L,7L,4L,3L,0L,1L,1L,4L,4L,4L,1L,6L,9L,7L,4L,2L,1L,0L,4L,1L,3L,8L,4L,2L,8L,9L,5L,6L,6L,4L,4L,3L,9L,7L,4L,2L,2L,9L,5L,5L,0L,7L,0L,5L,9L,4L,4L,7L,0L,2L,3L,2L,2L,3L,3L,2L,4L,5L,0L,1L,9L,9L,7L,9L,2L,4L,0L,6L,9L,5L,8L,6L,0L,9L,5L,1L,0L,3L,8L,7L,0L,8L,2L,5L,6L,8L,3L,2L,6L,7L,1L,2L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259068Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259068.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259068Inst : IEnumerable<long>
{
public static readonly long[] Value=A259068.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259068.Bytes);
public long this[int i]=>Value[i];

public static A259068Inst Instance=new A259068Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259069
{
public static readonly long[] Value={ 0L,0L,7L,9L,8L,3L,8L,1L,1L,4L,5L,0L,2L,6L,8L,6L,2L,4L,2L,8L,0L,6L,9L,6L,6L,7L,0L,7L,9L,8L,7L,8L,9L,3L,0L,3L,9L,0L,5L,2L,3L,7L,6L,9L,3L,3L,6L,2L,2L,9L,8L,8L,7L,6L,4L,1L,7L,7L,0L,4L,7L,3L,9L,7L,1L,4L,0L,2L,8L,7L,4L,0L,2L,8L,1L,8L,7L,8L,6L,5L,7L,9L,5L,2L,5L,4L,3L,9L,6L,1L,9L,6L,9L,2L,8L,6L,9L,8L,2L,0L,3L,9L,6L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259069Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259069.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259069Inst : IEnumerable<long>
{
public static readonly long[] Value=A259069.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259069.Bytes);
public long this[int i]=>Value[i];

public static A259069Inst Instance=new A259069Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259070
{
public static readonly long[] Value={ 0L,0L,0L,5L,7L,2L,9L,8L,5L,9L,8L,0L,1L,9L,8L,6L,3L,5L,2L,0L,4L,9L,9L,0L,9L,9L,4L,1L,4L,8L,8L,3L,3L,8L,7L,4L,5L,1L,3L,2L,5L,3L,9L,8L,7L,2L,9L,1L,1L,9L,9L,5L,2L,1L,2L,1L,7L,8L,2L,0L,7L,9L,1L,8L,8L,0L,9L,9L,7L,7L,3L,5L,0L,3L,1L,3L,5L,0L,8L,3L,1L,2L,5L,7L,8L,6L,5L,3L,9L,9L,3L,4L,2L,3L,8L,5L,7L,0L,0L,5L,0L,6L,0L,0L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259070Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259070.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259070Inst : IEnumerable<long>
{
public static readonly long[] Value=A259070.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259070.Bytes);
public long this[int i]=>Value[i];

public static A259070Inst Instance=new A259070Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259071
{
public static readonly long[] Value={ 0L,0L,5L,8L,9L,9L,7L,5L,9L,1L,4L,3L,5L,1L,5L,9L,3L,7L,4L,5L,0L,6L,2L,9L,8L,7L,7L,4L,0L,8L,3L,9L,2L,0L,2L,5L,5L,7L,9L,8L,0L,1L,5L,3L,4L,6L,2L,0L,1L,5L,7L,1L,9L,5L,8L,6L,5L,2L,3L,9L,3L,9L,2L,2L,0L,6L,3L,5L,9L,7L,0L,3L,7L,5L,9L,4L,2L,4L,9L,0L,5L,7L,2L,3L,0L,2L,3L,8L,6L,3L,0L,0L,7L,5L,4L,2L,2L,5L,8L,3L,8L,5L,3L,6L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259071Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259071.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259071Inst : IEnumerable<long>
{
public static readonly long[] Value=A259071.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259071.Bytes);
public long this[int i]=>Value[i];

public static A259071Inst Instance=new A259071Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259072
{
public static readonly long[] Value={ 0L,0L,0L,7L,2L,8L,6L,4L,2L,6L,8L,0L,1L,5L,9L,2L,4L,0L,6L,5L,2L,4L,6L,7L,2L,3L,3L,3L,5L,4L,6L,5L,0L,3L,6L,0L,6L,1L,1L,9L,0L,2L,8L,8L,7L,7L,2L,0L,9L,2L,5L,4L,1L,8L,3L,1L,8L,6L,3L,6L,3L,8L,6L,1L,5L,4L,1L,4L,2L,5L,9L,7L,5L,4L,5L,5L,2L,7L,3L,0L,9L,9L,1L,3L,0L,2L,3L,2L,4L,6L,4L,4L,1L,6L,8L,0L,4L,4L,9L,3L,7L,9L,6L,0L,6L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259072Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259072.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259072Inst : IEnumerable<long>
{
public static readonly long[] Value=A259072.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259072.Bytes);
public long this[int i]=>Value[i];

public static A259072Inst Instance=new A259072Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259073
{
public static readonly long[] Value={ 0L,0L,8L,3L,1L,6L,1L,6L,1L,9L,8L,5L,6L,0L,2L,2L,4L,7L,3L,5L,9L,5L,2L,4L,4L,2L,6L,5L,1L,0L,5L,3L,4L,2L,1L,4L,2L,2L,5L,6L,7L,4L,1L,2L,2L,9L,1L,8L,8L,2L,9L,9L,9L,9L,0L,4L,0L,2L,1L,0L,5L,3L,2L,7L,5L,3L,0L,5L,6L,9L,1L,7L,4L,0L,7L,8L,8L,1L,2L,3L,5L,3L,8L,3L,4L,8L,3L,4L,5L,2L,5L,1L,4L,5L,2L,4L,4L,0L,3L,5L,1L,7L,4L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259073Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259073.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259073Inst : IEnumerable<long>
{
public static readonly long[] Value=A259073.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259073.Bytes);
public long this[int i]=>Value[i];

public static A259073Inst Instance=new A259073Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259074
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,3L,3L,1L,2L,4L,6L,4L,1L,3L,7L,10L,10L,5L,1L,4L,12L,18L,20L,15L,6L,1L,5L,19L,33L,39L,35L,21L,7L,1L,7L,28L,58L,76L,75L,56L,28L,8L,1L,10L,42L,96L,144L,156L,132L,84L,36L,9L,1L,14L,64L,156L,260L,315L,294L,217L,120L,45L,10L,1L,19L,97L,253L,455L,610L,630L,518L,338L,165L,55L,11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259074Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259074.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259074Inst : IEnumerable<long>
{
public static readonly long[] Value=A259074.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259074.Bytes);
public long this[int i]=>Value[i];

public static A259074Inst Instance=new A259074Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259075
{
public static readonly long[] Value={ 17L,26L,18L,148L,239L,249L,423L,28L,63L,374L,117L,787L,2059L,1085L,655L,4586L,4153L,3147L,10056L,4559L,2092L,18692L,19487L,3018L,19343L,14285L,164L,31469L,6817L,7916L,16128L,4505L,18768L,2752L,26664L,16717L,129702L,46171L,1040L,3608L,9479L,4840L,42348L,14128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259075Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259075.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259075Inst : IEnumerable<long>
{
public static readonly long[] Value=A259075.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259075.Bytes);
public long this[int i]=>Value[i];

public static A259075Inst Instance=new A259075Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259076
{
public static readonly BigInteger[] Value={ 1L,80L,6400L,512000L,40960000L,3276800000L,262144000000L,20971520000000L,1677721600000000L,134217728000000000L,10737418240000000000UL,BigInteger.Parse("858993459200000000000"),BigInteger.Parse("68719476736000000000000") };
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
public class A259076Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259076.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259076Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259076.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259076.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259076Inst Instance=new A259076Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259077
{
public static readonly long[] Value={ 366L,663L,3245L,3685L,5423L,5863L,8178L,8718L,14269L,15167L,16237L,18449L,18977L,36679L,73261L,76151L,77981L,94481L,96241L,97663L,140941L,149041L,150251L,152051L,196891L,198691L,302363L,308459L,319853L,335148L,358913L,363203L,841533L,921239L,932129L,954803L,958099L,990859L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259077Inst : IEnumerable<long>
{
public static readonly long[] Value=A259077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259077.Bytes);
public long this[int i]=>Value[i];

public static A259077Inst Instance=new A259077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259078
{
public static readonly BigInteger[] Value={ 6426L,9875715583923L,BigInteger.Parse("15176968126834688342280"),BigInteger.Parse("23323916081375479417207129139097"),BigInteger.Parse("35844119643974208514403771705730853759974"),BigInteger.Parse("55085128439364942192092971212729781713850848998511"),BigInteger.Parse("84654649223375294035879228202426981713600292140166013136308") };
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
public class A259078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259078Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259078.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259078.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259078Inst Instance=new A259078Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259079
{
public static readonly BigInteger[] Value={ 280L,373212840L,497012764340408L,BigInteger.Parse("661878856450449219400"),BigInteger.Parse("881433339438556519000044120"),BigInteger.Parse("1173817118196415977287174306335208"),BigInteger.Parse("1563188689740940473437573487667885475320"),BigInteger.Parse("2081720262768492984525248323578863263574296200") };
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
public class A259079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259079Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A259079.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A259079.Bytes);
public BigInteger this[int i]=>Value[i];

public static A259079Inst Instance=new A259079Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259080
{
public static readonly long[] Value={ 1001L,2101L,21301L,222101L,2304401L,23553101L,244153501L,2520607101L,25937424601L,267120945101L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259080Inst : IEnumerable<long>
{
public static readonly long[] Value=A259080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259080.Bytes);
public long this[int i]=>Value[i];

public static A259080Inst Instance=new A259080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A259081
{
public static readonly long[] Value={ 68L,43L,59L,84L,106L,91L,104L,101L,100L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A259081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A259081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A259081Inst : IEnumerable<long>
{
public static readonly long[] Value=A259081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A259081.Bytes);
public long this[int i]=>Value[i];

public static A259081Inst Instance=new A259081Inst();

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