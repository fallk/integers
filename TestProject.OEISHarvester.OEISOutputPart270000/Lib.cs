using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A040612
{
public static readonly long[] Value={ 25L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L,50L,3L,1L,6L,2L,6L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040612Inst : IEnumerable<long>
{
public static readonly long[] Value=A040612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040612.Bytes);
public long this[int i]=>Value[i];

public static A040612Inst Instance=new A040612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040613
{
public static readonly long[] Value={ 25L,3L,1L,1L,2L,4L,4L,1L,4L,1L,4L,4L,2L,1L,1L,3L,50L,3L,1L,1L,2L,4L,4L,1L,4L,1L,4L,4L,2L,1L,1L,3L,50L,3L,1L,1L,2L,4L,4L,1L,4L,1L,4L,4L,2L,1L,1L,3L,50L,3L,1L,1L,2L,4L,4L,1L,4L,1L,4L,4L,2L,1L,1L,3L,50L,3L,1L,1L,2L,4L,4L,1L,4L,1L,4L,4L,2L,1L,1L,3L,50L,3L,1L,1L,2L,4L,4L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040613Inst : IEnumerable<long>
{
public static readonly long[] Value=A040613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040613.Bytes);
public long this[int i]=>Value[i];

public static A040613Inst Instance=new A040613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040614
{
public static readonly long[] Value={ 25L,3L,2L,1L,4L,1L,11L,1L,4L,1L,2L,3L,50L,3L,2L,1L,4L,1L,11L,1L,4L,1L,2L,3L,50L,3L,2L,1L,4L,1L,11L,1L,4L,1L,2L,3L,50L,3L,2L,1L,4L,1L,11L,1L,4L,1L,2L,3L,50L,3L,2L,1L,4L,1L,11L,1L,4L,1L,2L,3L,50L,3L,2L,1L,4L,1L,11L,1L,4L,1L,2L,3L,50L,3L,2L,1L,4L,1L,11L,1L,4L,1L,2L,3L,50L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040614Inst : IEnumerable<long>
{
public static readonly long[] Value=A040614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040614.Bytes);
public long this[int i]=>Value[i];

public static A040614Inst Instance=new A040614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040615
{
public static readonly long[] Value={ 25L,3L,6L,1L,9L,3L,1L,3L,1L,5L,1L,1L,5L,1L,3L,1L,3L,9L,1L,6L,3L,50L,3L,6L,1L,9L,3L,1L,3L,1L,5L,1L,1L,5L,1L,3L,1L,3L,9L,1L,6L,3L,50L,3L,6L,1L,9L,3L,1L,3L,1L,5L,1L,1L,5L,1L,3L,1L,3L,9L,1L,6L,3L,50L,3L,6L,1L,9L,3L,1L,3L,1L,5L,1L,1L,5L,1L,3L,1L,3L,9L,1L,6L,3L,50L,3L,6L,1L,9L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040615Inst : IEnumerable<long>
{
public static readonly long[] Value=A040615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040615.Bytes);
public long this[int i]=>Value[i];

public static A040615Inst Instance=new A040615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040616
{
public static readonly long[] Value={ 25L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L,24L,1L,2L,50L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040616Inst : IEnumerable<long>
{
public static readonly long[] Value=A040616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040616.Bytes);
public long this[int i]=>Value[i];

public static A040616Inst Instance=new A040616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040617
{
public static readonly long[] Value={ 25L,2L,1L,3L,1L,16L,8L,2L,1L,1L,5L,25L,5L,1L,1L,2L,8L,16L,1L,3L,1L,2L,50L,2L,1L,3L,1L,16L,8L,2L,1L,1L,5L,25L,5L,1L,1L,2L,8L,16L,1L,3L,1L,2L,50L,2L,1L,3L,1L,16L,8L,2L,1L,1L,5L,25L,5L,1L,1L,2L,8L,16L,1L,3L,1L,2L,50L,2L,1L,3L,1L,16L,8L,2L,1L,1L,5L,25L,5L,1L,1L,2L,8L,16L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040617Inst : IEnumerable<long>
{
public static readonly long[] Value=A040617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040617.Bytes);
public long this[int i]=>Value[i];

public static A040617Inst Instance=new A040617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040618
{
public static readonly long[] Value={ 25L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L,50L,2L,1L,1L,1L,6L,1L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040618Inst : IEnumerable<long>
{
public static readonly long[] Value=A040618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040618.Bytes);
public long this[int i]=>Value[i];

public static A040618Inst Instance=new A040618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040619
{
public static readonly long[] Value={ 25L,2L,1L,1L,12L,10L,12L,1L,1L,2L,50L,2L,1L,1L,12L,10L,12L,1L,1L,2L,50L,2L,1L,1L,12L,10L,12L,1L,1L,2L,50L,2L,1L,1L,12L,10L,12L,1L,1L,2L,50L,2L,1L,1L,12L,10L,12L,1L,1L,2L,50L,2L,1L,1L,12L,10L,12L,1L,1L,2L,50L,2L,1L,1L,12L,10L,12L,1L,1L,2L,50L,2L,1L,1L,12L,10L,12L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040619Inst : IEnumerable<long>
{
public static readonly long[] Value=A040619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040619.Bytes);
public long this[int i]=>Value[i];

public static A040619Inst Instance=new A040619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040620
{
public static readonly long[] Value={ 25L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L,50L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040620Inst : IEnumerable<long>
{
public static readonly long[] Value=A040620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040620.Bytes);
public long this[int i]=>Value[i];

public static A040620Inst Instance=new A040620Inst();

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

public static class A040637
{
public static readonly long[] Value={ 25L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L,50L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040637Inst : IEnumerable<long>
{
public static readonly long[] Value=A040637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040637.Bytes);
public long this[int i]=>Value[i];

public static A040637Inst Instance=new A040637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040638
{
public static readonly long[] Value={ 25L,1L,3L,3L,5L,2L,2L,1L,1L,2L,1L,5L,1L,2L,1L,1L,2L,2L,5L,3L,3L,1L,50L,1L,3L,3L,5L,2L,2L,1L,1L,2L,1L,5L,1L,2L,1L,1L,2L,2L,5L,3L,3L,1L,50L,1L,3L,3L,5L,2L,2L,1L,1L,2L,1L,5L,1L,2L,1L,1L,2L,2L,5L,3L,3L,1L,50L,1L,3L,3L,5L,2L,2L,1L,1L,2L,1L,5L,1L,2L,1L,1L,2L,2L,5L,3L,3L,1L,50L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040638Inst : IEnumerable<long>
{
public static readonly long[] Value=A040638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040638.Bytes);
public long this[int i]=>Value[i];

public static A040638Inst Instance=new A040638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040639
{
public static readonly long[] Value={ 25L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L,50L,1L,3L,1L,2L,2L,2L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040639Inst : IEnumerable<long>
{
public static readonly long[] Value=A040639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040639.Bytes);
public long this[int i]=>Value[i];

public static A040639Inst Instance=new A040639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040640
{
public static readonly long[] Value={ 25L,1L,4L,5L,1L,1L,6L,1L,4L,1L,6L,1L,1L,5L,4L,1L,50L,1L,4L,5L,1L,1L,6L,1L,4L,1L,6L,1L,1L,5L,4L,1L,50L,1L,4L,5L,1L,1L,6L,1L,4L,1L,6L,1L,1L,5L,4L,1L,50L,1L,4L,5L,1L,1L,6L,1L,4L,1L,6L,1L,1L,5L,4L,1L,50L,1L,4L,5L,1L,1L,6L,1L,4L,1L,6L,1L,1L,5L,4L,1L,50L,1L,4L,5L,1L,1L,6L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040640Inst : IEnumerable<long>
{
public static readonly long[] Value=A040640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040640.Bytes);
public long this[int i]=>Value[i];

public static A040640Inst Instance=new A040640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040641
{
public static readonly long[] Value={ 25L,1L,4L,1L,3L,7L,8L,2L,8L,7L,3L,1L,4L,1L,50L,1L,4L,1L,3L,7L,8L,2L,8L,7L,3L,1L,4L,1L,50L,1L,4L,1L,3L,7L,8L,2L,8L,7L,3L,1L,4L,1L,50L,1L,4L,1L,3L,7L,8L,2L,8L,7L,3L,1L,4L,1L,50L,1L,4L,1L,3L,7L,8L,2L,8L,7L,3L,1L,4L,1L,50L,1L,4L,1L,3L,7L,8L,2L,8L,7L,3L,1L,4L,1L,50L,1L,4L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040641Inst : IEnumerable<long>
{
public static readonly long[] Value=A040641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040641.Bytes);
public long this[int i]=>Value[i];

public static A040641Inst Instance=new A040641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040642
{
public static readonly long[] Value={ 25L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L,12L,2L,5L,1L,50L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040642Inst : IEnumerable<long>
{
public static readonly long[] Value=A040642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040642.Bytes);
public long this[int i]=>Value[i];

public static A040642Inst Instance=new A040642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040643
{
public static readonly long[] Value={ 25L,1L,6L,2L,2L,3L,1L,9L,1L,1L,2L,1L,12L,4L,1L,1L,1L,1L,1L,16L,1L,1L,1L,1L,1L,4L,12L,1L,2L,1L,1L,9L,1L,3L,2L,2L,6L,1L,50L,1L,6L,2L,2L,3L,1L,9L,1L,1L,2L,1L,12L,4L,1L,1L,1L,1L,1L,16L,1L,1L,1L,1L,1L,4L,12L,1L,2L,1L,1L,9L,1L,3L,2L,2L,6L,1L,50L,1L,6L,2L,2L,3L,1L,9L,1L,1L,2L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040643Inst : IEnumerable<long>
{
public static readonly long[] Value=A040643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040643.Bytes);
public long this[int i]=>Value[i];

public static A040643Inst Instance=new A040643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040644
{
public static readonly long[] Value={ 25L,1L,7L,1L,1L,1L,5L,10L,5L,1L,1L,1L,7L,1L,50L,1L,7L,1L,1L,1L,5L,10L,5L,1L,1L,1L,7L,1L,50L,1L,7L,1L,1L,1L,5L,10L,5L,1L,1L,1L,7L,1L,50L,1L,7L,1L,1L,1L,5L,10L,5L,1L,1L,1L,7L,1L,50L,1L,7L,1L,1L,1L,5L,10L,5L,1L,1L,1L,7L,1L,50L,1L,7L,1L,1L,1L,5L,10L,5L,1L,1L,1L,7L,1L,50L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040644Inst : IEnumerable<long>
{
public static readonly long[] Value=A040644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040644.Bytes);
public long this[int i]=>Value[i];

public static A040644Inst Instance=new A040644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040645
{
public static readonly long[] Value={ 25L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L,50L,1L,9L,2L,1L,1L,1L,2L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040645Inst : IEnumerable<long>
{
public static readonly long[] Value=A040645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040645.Bytes);
public long this[int i]=>Value[i];

public static A040645Inst Instance=new A040645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040646
{
public static readonly long[] Value={ 25L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L,1L,50L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040646Inst : IEnumerable<long>
{
public static readonly long[] Value=A040646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040646.Bytes);
public long this[int i]=>Value[i];

public static A040646Inst Instance=new A040646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040647
{
public static readonly long[] Value={ 25L,1L,16L,3L,5L,2L,3L,1L,1L,6L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,6L,1L,1L,3L,2L,5L,3L,16L,1L,50L,1L,16L,3L,5L,2L,3L,1L,1L,6L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,6L,1L,1L,3L,2L,5L,3L,16L,1L,50L,1L,16L,3L,5L,2L,3L,1L,1L,6L,1L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,1L,6L,1L,1L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040647Inst : IEnumerable<long>
{
public static readonly long[] Value=A040647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040647.Bytes);
public long this[int i]=>Value[i];

public static A040647Inst Instance=new A040647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040648
{
public static readonly long[] Value={ 25L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L,1L,50L,1L,24L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040648Inst : IEnumerable<long>
{
public static readonly long[] Value=A040648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040648.Bytes);
public long this[int i]=>Value[i];

public static A040648Inst Instance=new A040648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040649
{
public static readonly long[] Value={ 25L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L,1L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040649Inst : IEnumerable<long>
{
public static readonly long[] Value=A040649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040649.Bytes);
public long this[int i]=>Value[i];

public static A040649Inst Instance=new A040649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040650
{
public static readonly long[] Value={ 26L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040650Inst : IEnumerable<long>
{
public static readonly long[] Value=A040650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040650.Bytes);
public long this[int i]=>Value[i];

public static A040650Inst Instance=new A040650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040651
{
public static readonly long[] Value={ 26L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L,26L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040651Inst : IEnumerable<long>
{
public static readonly long[] Value=A040651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040651.Bytes);
public long this[int i]=>Value[i];

public static A040651Inst Instance=new A040651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040652
{
public static readonly long[] Value={ 26L,17L,2L,1L,5L,8L,1L,1L,25L,1L,1L,8L,5L,1L,2L,17L,52L,17L,2L,1L,5L,8L,1L,1L,25L,1L,1L,8L,5L,1L,2L,17L,52L,17L,2L,1L,5L,8L,1L,1L,25L,1L,1L,8L,5L,1L,2L,17L,52L,17L,2L,1L,5L,8L,1L,1L,25L,1L,1L,8L,5L,1L,2L,17L,52L,17L,2L,1L,5L,8L,1L,1L,25L,1L,1L,8L,5L,1L,2L,17L,52L,17L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040652Inst : IEnumerable<long>
{
public static readonly long[] Value=A040652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040652.Bytes);
public long this[int i]=>Value[i];

public static A040652Inst Instance=new A040652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040653
{
public static readonly long[] Value={ 26L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L,13L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040653Inst : IEnumerable<long>
{
public static readonly long[] Value=A040653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040653.Bytes);
public long this[int i]=>Value[i];

public static A040653Inst Instance=new A040653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040654
{
public static readonly long[] Value={ 26L,10L,2L,2L,1L,1L,2L,6L,7L,3L,2L,1L,16L,1L,2L,3L,7L,6L,2L,1L,1L,2L,2L,10L,52L,10L,2L,2L,1L,1L,2L,6L,7L,3L,2L,1L,16L,1L,2L,3L,7L,6L,2L,1L,1L,2L,2L,10L,52L,10L,2L,2L,1L,1L,2L,6L,7L,3L,2L,1L,16L,1L,2L,3L,7L,6L,2L,1L,1L,2L,2L,10L,52L,10L,2L,2L,1L,1L,2L,6L,7L,3L,2L,1L,16L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040654Inst : IEnumerable<long>
{
public static readonly long[] Value=A040654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040654.Bytes);
public long this[int i]=>Value[i];

public static A040654Inst Instance=new A040654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040655
{
public static readonly long[] Value={ 26L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L,52L,8L,1L,2L,5L,2L,5L,2L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040655Inst : IEnumerable<long>
{
public static readonly long[] Value=A040655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040655.Bytes);
public long this[int i]=>Value[i];

public static A040655Inst Instance=new A040655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040656
{
public static readonly long[] Value={ 26L,7L,2L,4L,3L,1L,1L,25L,1L,1L,3L,4L,2L,7L,52L,7L,2L,4L,3L,1L,1L,25L,1L,1L,3L,4L,2L,7L,52L,7L,2L,4L,3L,1L,1L,25L,1L,1L,3L,4L,2L,7L,52L,7L,2L,4L,3L,1L,1L,25L,1L,1L,3L,4L,2L,7L,52L,7L,2L,4L,3L,1L,1L,25L,1L,1L,3L,4L,2L,7L,52L,7L,2L,4L,3L,1L,1L,25L,1L,1L,3L,4L,2L,7L,52L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040656Inst : IEnumerable<long>
{
public static readonly long[] Value=A040656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040656.Bytes);
public long this[int i]=>Value[i];

public static A040656Inst Instance=new A040656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040657
{
public static readonly long[] Value={ 26L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L,12L,1L,1L,6L,52L,6L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040657Inst : IEnumerable<long>
{
public static readonly long[] Value=A040657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040657.Bytes);
public long this[int i]=>Value[i];

public static A040657Inst Instance=new A040657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040658
{
public static readonly long[] Value={ 26L,5L,1L,3L,1L,12L,3L,2L,2L,3L,12L,1L,3L,1L,5L,52L,5L,1L,3L,1L,12L,3L,2L,2L,3L,12L,1L,3L,1L,5L,52L,5L,1L,3L,1L,12L,3L,2L,2L,3L,12L,1L,3L,1L,5L,52L,5L,1L,3L,1L,12L,3L,2L,2L,3L,12L,1L,3L,1L,5L,52L,5L,1L,3L,1L,12L,3L,2L,2L,3L,12L,1L,3L,1L,5L,52L,5L,1L,3L,1L,12L,3L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040658Inst : IEnumerable<long>
{
public static readonly long[] Value=A040658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040658.Bytes);
public long this[int i]=>Value[i];

public static A040658Inst Instance=new A040658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040659
{
public static readonly long[] Value={ 26L,5L,4L,1L,1L,3L,2L,10L,26L,10L,2L,3L,1L,1L,4L,5L,52L,5L,4L,1L,1L,3L,2L,10L,26L,10L,2L,3L,1L,1L,4L,5L,52L,5L,4L,1L,1L,3L,2L,10L,26L,10L,2L,3L,1L,1L,4L,5L,52L,5L,4L,1L,1L,3L,2L,10L,26L,10L,2L,3L,1L,1L,4L,5L,52L,5L,4L,1L,1L,3L,2L,10L,26L,10L,2L,3L,1L,1L,4L,5L,52L,5L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040659Inst : IEnumerable<long>
{
public static readonly long[] Value=A040659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040659.Bytes);
public long this[int i]=>Value[i];

public static A040659Inst Instance=new A040659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040660
{
public static readonly long[] Value={ 26L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L,16L,1L,2L,1L,4L,52L,4L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040660Inst : IEnumerable<long>
{
public static readonly long[] Value=A040660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040660.Bytes);
public long this[int i]=>Value[i];

public static A040660Inst Instance=new A040660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040661
{
public static readonly long[] Value={ 26L,4L,2L,1L,5L,7L,3L,7L,5L,1L,2L,4L,52L,4L,2L,1L,5L,7L,3L,7L,5L,1L,2L,4L,52L,4L,2L,1L,5L,7L,3L,7L,5L,1L,2L,4L,52L,4L,2L,1L,5L,7L,3L,7L,5L,1L,2L,4L,52L,4L,2L,1L,5L,7L,3L,7L,5L,1L,2L,4L,52L,4L,2L,1L,5L,7L,3L,7L,5L,1L,2L,4L,52L,4L,2L,1L,5L,7L,3L,7L,5L,1L,2L,4L,52L,4L,2L,1L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040661Inst : IEnumerable<long>
{
public static readonly long[] Value=A040661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040661.Bytes);
public long this[int i]=>Value[i];

public static A040661Inst Instance=new A040661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040662
{
public static readonly long[] Value={ 26L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L,4L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040662Inst : IEnumerable<long>
{
public static readonly long[] Value=A040662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040662.Bytes);
public long this[int i]=>Value[i];

public static A040662Inst Instance=new A040662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040663
{
public static readonly long[] Value={ 26L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L,2L,1L,3L,52L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040663Inst : IEnumerable<long>
{
public static readonly long[] Value=A040663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040663.Bytes);
public long this[int i]=>Value[i];

public static A040663Inst Instance=new A040663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040664
{
public static readonly long[] Value={ 26L,3L,2L,17L,10L,2L,5L,2L,1L,2L,1L,4L,1L,1L,8L,4L,1L,1L,1L,25L,1L,1L,1L,4L,8L,1L,1L,4L,1L,2L,1L,2L,5L,2L,10L,17L,2L,3L,52L,3L,2L,17L,10L,2L,5L,2L,1L,2L,1L,4L,1L,1L,8L,4L,1L,1L,1L,25L,1L,1L,1L,4L,8L,1L,1L,4L,1L,2L,1L,2L,5L,2L,10L,17L,2L,3L,52L,3L,2L,17L,10L,2L,5L,2L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040664Inst : IEnumerable<long>
{
public static readonly long[] Value=A040664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040664.Bytes);
public long this[int i]=>Value[i];

public static A040664Inst Instance=new A040664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040665
{
public static readonly long[] Value={ 26L,3L,3L,1L,2L,1L,1L,12L,1L,1L,2L,1L,3L,3L,52L,3L,3L,1L,2L,1L,1L,12L,1L,1L,2L,1L,3L,3L,52L,3L,3L,1L,2L,1L,1L,12L,1L,1L,2L,1L,3L,3L,52L,3L,3L,1L,2L,1L,1L,12L,1L,1L,2L,1L,3L,3L,52L,3L,3L,1L,2L,1L,1L,12L,1L,1L,2L,1L,3L,3L,52L,3L,3L,1L,2L,1L,1L,12L,1L,1L,2L,1L,3L,3L,52L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040665Inst : IEnumerable<long>
{
public static readonly long[] Value=A040665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040665.Bytes);
public long this[int i]=>Value[i];

public static A040665Inst Instance=new A040665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040666
{
public static readonly long[] Value={ 26L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L,3L,52L,3L,12L,1L,4L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040666Inst : IEnumerable<long>
{
public static readonly long[] Value=A040666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040666.Bytes);
public long this[int i]=>Value[i];

public static A040666Inst Instance=new A040666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040667
{
public static readonly long[] Value={ 26L,2L,1L,9L,1L,6L,1L,1L,1L,1L,1L,2L,1L,8L,17L,2L,4L,3L,3L,2L,4L,1L,5L,26L,5L,1L,4L,2L,3L,3L,4L,2L,17L,8L,1L,2L,1L,1L,1L,1L,1L,6L,1L,9L,1L,2L,52L,2L,1L,9L,1L,6L,1L,1L,1L,1L,1L,2L,1L,8L,17L,2L,4L,3L,3L,2L,4L,1L,5L,26L,5L,1L,4L,2L,3L,3L,4L,2L,17L,8L,1L,2L,1L,1L,1L,1L,1L,6L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040667Inst : IEnumerable<long>
{
public static readonly long[] Value=A040667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040667.Bytes);
public long this[int i]=>Value[i];

public static A040667Inst Instance=new A040667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040668
{
public static readonly long[] Value={ 26L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L,10L,3L,1L,2L,52L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040668Inst : IEnumerable<long>
{
public static readonly long[] Value=A040668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040668.Bytes);
public long this[int i]=>Value[i];

public static A040668Inst Instance=new A040668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040685
{
public static readonly long[] Value={ 26L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L,6L,2L,1L,52L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040685Inst : IEnumerable<long>
{
public static readonly long[] Value=A040685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040685.Bytes);
public long this[int i]=>Value[i];

public static A040685Inst Instance=new A040685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040686
{
public static readonly long[] Value={ 26L,1L,2L,2L,1L,4L,6L,2L,6L,4L,1L,2L,2L,1L,52L,1L,2L,2L,1L,4L,6L,2L,6L,4L,1L,2L,2L,1L,52L,1L,2L,2L,1L,4L,6L,2L,6L,4L,1L,2L,2L,1L,52L,1L,2L,2L,1L,4L,6L,2L,6L,4L,1L,2L,2L,1L,52L,1L,2L,2L,1L,4L,6L,2L,6L,4L,1L,2L,2L,1L,52L,1L,2L,2L,1L,4L,6L,2L,6L,4L,1L,2L,2L,1L,52L,1L,2L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040686Inst : IEnumerable<long>
{
public static readonly long[] Value=A040686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040686.Bytes);
public long this[int i]=>Value[i];

public static A040686Inst Instance=new A040686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040687
{
public static readonly long[] Value={ 26L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L,52L,1L,2L,1L,1L,2L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040687Inst : IEnumerable<long>
{
public static readonly long[] Value=A040687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040687.Bytes);
public long this[int i]=>Value[i];

public static A040687Inst Instance=new A040687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040688
{
public static readonly long[] Value={ 26L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L,52L,1L,2L,1L,5L,5L,5L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040688Inst : IEnumerable<long>
{
public static readonly long[] Value=A040688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040688.Bytes);
public long this[int i]=>Value[i];

public static A040688Inst Instance=new A040688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040689
{
public static readonly long[] Value={ 26L,1L,3L,7L,2L,1L,1L,6L,10L,1L,1L,4L,2L,1L,12L,1L,2L,4L,1L,1L,10L,6L,1L,1L,2L,7L,3L,1L,52L,1L,3L,7L,2L,1L,1L,6L,10L,1L,1L,4L,2L,1L,12L,1L,2L,4L,1L,1L,10L,6L,1L,1L,2L,7L,3L,1L,52L,1L,3L,7L,2L,1L,1L,6L,10L,1L,1L,4L,2L,1L,12L,1L,2L,4L,1L,1L,10L,6L,1L,1L,2L,7L,3L,1L,52L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040689Inst : IEnumerable<long>
{
public static readonly long[] Value=A040689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040689.Bytes);
public long this[int i]=>Value[i];

public static A040689Inst Instance=new A040689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040690
{
public static readonly long[] Value={ 26L,1L,3L,2L,12L,1L,16L,1L,12L,2L,3L,1L,52L,1L,3L,2L,12L,1L,16L,1L,12L,2L,3L,1L,52L,1L,3L,2L,12L,1L,16L,1L,12L,2L,3L,1L,52L,1L,3L,2L,12L,1L,16L,1L,12L,2L,3L,1L,52L,1L,3L,2L,12L,1L,16L,1L,12L,2L,3L,1L,52L,1L,3L,2L,12L,1L,16L,1L,12L,2L,3L,1L,52L,1L,3L,2L,12L,1L,16L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040690Inst : IEnumerable<long>
{
public static readonly long[] Value=A040690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040690.Bytes);
public long this[int i]=>Value[i];

public static A040690Inst Instance=new A040690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040691
{
public static readonly long[] Value={ 26L,1L,3L,1L,8L,7L,1L,1L,5L,2L,2L,1L,2L,3L,1L,3L,17L,1L,1L,2L,26L,2L,1L,1L,17L,3L,1L,3L,2L,1L,2L,2L,5L,1L,1L,7L,8L,1L,3L,1L,52L,1L,3L,1L,8L,7L,1L,1L,5L,2L,2L,1L,2L,3L,1L,3L,17L,1L,1L,2L,26L,2L,1L,1L,17L,3L,1L,3L,2L,1L,2L,2L,5L,1L,1L,7L,8L,1L,3L,1L,52L,1L,3L,1L,8L,7L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040691Inst : IEnumerable<long>
{
public static readonly long[] Value=A040691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040691.Bytes);
public long this[int i]=>Value[i];

public static A040691Inst Instance=new A040691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040692
{
public static readonly long[] Value={ 26L,1L,4L,2L,1L,1L,1L,1L,1L,4L,3L,1L,9L,1L,25L,1L,9L,1L,3L,4L,1L,1L,1L,1L,1L,2L,4L,1L,52L,1L,4L,2L,1L,1L,1L,1L,1L,4L,3L,1L,9L,1L,25L,1L,9L,1L,3L,4L,1L,1L,1L,1L,1L,2L,4L,1L,52L,1L,4L,2L,1L,1L,1L,1L,1L,4L,3L,1L,9L,1L,25L,1L,9L,1L,3L,4L,1L,1L,1L,1L,1L,2L,4L,1L,52L,1L,4L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040692Inst : IEnumerable<long>
{
public static readonly long[] Value=A040692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040692.Bytes);
public long this[int i]=>Value[i];

public static A040692Inst Instance=new A040692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040693
{
public static readonly long[] Value={ 26L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L,52L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040693Inst : IEnumerable<long>
{
public static readonly long[] Value=A040693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040693.Bytes);
public long this[int i]=>Value[i];

public static A040693Inst Instance=new A040693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040694
{
public static readonly long[] Value={ 26L,1L,5L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,17L,3L,1L,1L,10L,5L,1L,6L,1L,5L,10L,1L,1L,3L,17L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,5L,1L,52L,1L,5L,1L,2L,1L,2L,1L,1L,1L,1L,1L,1L,17L,3L,1L,1L,10L,5L,1L,6L,1L,5L,10L,1L,1L,3L,17L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,5L,1L,52L,1L,5L,1L,2L,1L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040694Inst : IEnumerable<long>
{
public static readonly long[] Value=A040694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040694.Bytes);
public long this[int i]=>Value[i];

public static A040694Inst Instance=new A040694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040695
{
public static readonly long[] Value={ 26L,1L,6L,1L,2L,3L,2L,26L,2L,3L,2L,1L,6L,1L,52L,1L,6L,1L,2L,3L,2L,26L,2L,3L,2L,1L,6L,1L,52L,1L,6L,1L,2L,3L,2L,26L,2L,3L,2L,1L,6L,1L,52L,1L,6L,1L,2L,3L,2L,26L,2L,3L,2L,1L,6L,1L,52L,1L,6L,1L,2L,3L,2L,26L,2L,3L,2L,1L,6L,1L,52L,1L,6L,1L,2L,3L,2L,26L,2L,3L,2L,1L,6L,1L,52L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040695Inst : IEnumerable<long>
{
public static readonly long[] Value=A040695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040695.Bytes);
public long this[int i]=>Value[i];

public static A040695Inst Instance=new A040695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040696
{
public static readonly long[] Value={ 26L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L,52L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040696Inst : IEnumerable<long>
{
public static readonly long[] Value=A040696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040696.Bytes);
public long this[int i]=>Value[i];

public static A040696Inst Instance=new A040696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040697
{
public static readonly long[] Value={ 26L,1L,9L,1L,3L,1L,1L,2L,1L,4L,5L,1L,3L,3L,3L,17L,1L,1L,1L,2L,1L,12L,1L,2L,1L,1L,1L,17L,3L,3L,3L,1L,5L,4L,1L,2L,1L,1L,3L,1L,9L,1L,52L,1L,9L,1L,3L,1L,1L,2L,1L,4L,5L,1L,3L,3L,3L,17L,1L,1L,1L,2L,1L,12L,1L,2L,1L,1L,1L,17L,3L,3L,3L,1L,5L,4L,1L,2L,1L,1L,3L,1L,9L,1L,52L,1L,9L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040697Inst : IEnumerable<long>
{
public static readonly long[] Value=A040697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040697.Bytes);
public long this[int i]=>Value[i];

public static A040697Inst Instance=new A040697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040698
{
public static readonly long[] Value={ 26L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L,2L,12L,1L,52L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040698Inst : IEnumerable<long>
{
public static readonly long[] Value=A040698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040698.Bytes);
public long this[int i]=>Value[i];

public static A040698Inst Instance=new A040698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040699
{
public static readonly long[] Value={ 26L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L,1L,52L,1L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040699Inst : IEnumerable<long>
{
public static readonly long[] Value=A040699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040699.Bytes);
public long this[int i]=>Value[i];

public static A040699Inst Instance=new A040699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040700
{
public static readonly long[] Value={ 26L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L,1L,52L,1L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040700Inst : IEnumerable<long>
{
public static readonly long[] Value=A040700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040700.Bytes);
public long this[int i]=>Value[i];

public static A040700Inst Instance=new A040700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040717
{
public static readonly long[] Value={ 27L,3L,2L,1L,1L,5L,2L,10L,2L,5L,1L,1L,2L,3L,54L,3L,2L,1L,1L,5L,2L,10L,2L,5L,1L,1L,2L,3L,54L,3L,2L,1L,1L,5L,2L,10L,2L,5L,1L,1L,2L,3L,54L,3L,2L,1L,1L,5L,2L,10L,2L,5L,1L,1L,2L,3L,54L,3L,2L,1L,1L,5L,2L,10L,2L,5L,1L,1L,2L,3L,54L,3L,2L,1L,1L,5L,2L,10L,2L,5L,1L,1L,2L,3L,54L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040717Inst : IEnumerable<long>
{
public static readonly long[] Value=A040717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040717.Bytes);
public long this[int i]=>Value[i];

public static A040717Inst Instance=new A040717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040718
{
public static readonly long[] Value={ 27L,3L,5L,7L,1L,1L,1L,1L,1L,1L,7L,5L,3L,54L,3L,5L,7L,1L,1L,1L,1L,1L,1L,7L,5L,3L,54L,3L,5L,7L,1L,1L,1L,1L,1L,1L,7L,5L,3L,54L,3L,5L,7L,1L,1L,1L,1L,1L,1L,7L,5L,3L,54L,3L,5L,7L,1L,1L,1L,1L,1L,1L,7L,5L,3L,54L,3L,5L,7L,1L,1L,1L,1L,1L,1L,7L,5L,3L,54L,3L,5L,7L,1L,1L,1L,1L,1L,1L,7L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040718Inst : IEnumerable<long>
{
public static readonly long[] Value=A040718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040718.Bytes);
public long this[int i]=>Value[i];

public static A040718Inst Instance=new A040718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040719
{
public static readonly long[] Value={ 27L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L,3L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040719Inst : IEnumerable<long>
{
public static readonly long[] Value=A040719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040719.Bytes);
public long this[int i]=>Value[i];

public static A040719Inst Instance=new A040719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040720
{
public static readonly long[] Value={ 27L,2L,1L,6L,5L,1L,12L,1L,5L,6L,1L,2L,54L,2L,1L,6L,5L,1L,12L,1L,5L,6L,1L,2L,54L,2L,1L,6L,5L,1L,12L,1L,5L,6L,1L,2L,54L,2L,1L,6L,5L,1L,12L,1L,5L,6L,1L,2L,54L,2L,1L,6L,5L,1L,12L,1L,5L,6L,1L,2L,54L,2L,1L,6L,5L,1L,12L,1L,5L,6L,1L,2L,54L,2L,1L,6L,5L,1L,12L,1L,5L,6L,1L,2L,54L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040720Inst : IEnumerable<long>
{
public static readonly long[] Value=A040720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040720.Bytes);
public long this[int i]=>Value[i];

public static A040720Inst Instance=new A040720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040721
{
public static readonly long[] Value={ 27L,2L,1L,2L,1L,1L,4L,2L,1L,1L,13L,10L,1L,6L,1L,10L,13L,1L,1L,2L,4L,1L,1L,2L,1L,2L,54L,2L,1L,2L,1L,1L,4L,2L,1L,1L,13L,10L,1L,6L,1L,10L,13L,1L,1L,2L,4L,1L,1L,2L,1L,2L,54L,2L,1L,2L,1L,1L,4L,2L,1L,1L,13L,10L,1L,6L,1L,10L,13L,1L,1L,2L,4L,1L,1L,2L,1L,2L,54L,2L,1L,2L,1L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040721Inst : IEnumerable<long>
{
public static readonly long[] Value=A040721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040721.Bytes);
public long this[int i]=>Value[i];

public static A040721Inst Instance=new A040721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040722
{
public static readonly long[] Value={ 27L,2L,1L,1L,2L,3L,1L,1L,8L,1L,1L,3L,2L,1L,1L,2L,54L,2L,1L,1L,2L,3L,1L,1L,8L,1L,1L,3L,2L,1L,1L,2L,54L,2L,1L,1L,2L,3L,1L,1L,8L,1L,1L,3L,2L,1L,1L,2L,54L,2L,1L,1L,2L,3L,1L,1L,8L,1L,1L,3L,2L,1L,1L,2L,54L,2L,1L,1L,2L,3L,1L,1L,8L,1L,1L,3L,2L,1L,1L,2L,54L,2L,1L,1L,2L,3L,1L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040722Inst : IEnumerable<long>
{
public static readonly long[] Value=A040722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040722.Bytes);
public long this[int i]=>Value[i];

public static A040722Inst Instance=new A040722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040723
{
public static readonly long[] Value={ 27L,2L,2L,8L,1L,2L,1L,3L,5L,1L,4L,1L,1L,1L,3L,1L,1L,3L,10L,1L,2L,7L,2L,17L,1L,4L,27L,4L,1L,17L,2L,7L,2L,1L,10L,3L,1L,1L,3L,1L,1L,1L,4L,1L,5L,3L,1L,2L,1L,8L,2L,2L,54L,2L,2L,8L,1L,2L,1L,3L,5L,1L,4L,1L,1L,1L,3L,1L,1L,3L,10L,1L,2L,7L,2L,17L,1L,4L,27L,4L,1L,17L,2L,7L,2L,1L,10L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040723Inst : IEnumerable<long>
{
public static readonly long[] Value=A040723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040723.Bytes);
public long this[int i]=>Value[i];

public static A040723Inst Instance=new A040723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040724
{
public static readonly long[] Value={ 27L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L,54L,2L,2L,1L,2L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040724Inst : IEnumerable<long>
{
public static readonly long[] Value=A040724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040724.Bytes);
public long this[int i]=>Value[i];

public static A040724Inst Instance=new A040724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040725
{
public static readonly long[] Value={ 27L,2L,3L,1L,2L,1L,1L,1L,7L,4L,1L,6L,18L,6L,1L,4L,7L,1L,1L,1L,2L,1L,3L,2L,54L,2L,3L,1L,2L,1L,1L,1L,7L,4L,1L,6L,18L,6L,1L,4L,7L,1L,1L,1L,2L,1L,3L,2L,54L,2L,3L,1L,2L,1L,1L,1L,7L,4L,1L,6L,18L,6L,1L,4L,7L,1L,1L,1L,2L,1L,3L,2L,54L,2L,3L,1L,2L,1L,1L,1L,7L,4L,1L,6L,18L,6L,1L,4L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040725Inst : IEnumerable<long>
{
public static readonly long[] Value=A040725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040725.Bytes);
public long this[int i]=>Value[i];

public static A040725Inst Instance=new A040725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040726
{
public static readonly long[] Value={ 27L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L,2L,54L,2L,5L,1L,1L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040726Inst : IEnumerable<long>
{
public static readonly long[] Value=A040726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040726.Bytes);
public long this[int i]=>Value[i];

public static A040726Inst Instance=new A040726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040727
{
public static readonly long[] Value={ 27L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L,2L,54L,2L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040727Inst : IEnumerable<long>
{
public static readonly long[] Value=A040727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040727.Bytes);
public long this[int i]=>Value[i];

public static A040727Inst Instance=new A040727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040728
{
public static readonly long[] Value={ 27L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L,2L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040728Inst : IEnumerable<long>
{
public static readonly long[] Value=A040728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040728.Bytes);
public long this[int i]=>Value[i];

public static A040728Inst Instance=new A040728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040729
{
public static readonly long[] Value={ 27L,1L,1L,17L,1L,5L,5L,1L,17L,1L,1L,54L,1L,1L,17L,1L,5L,5L,1L,17L,1L,1L,54L,1L,1L,17L,1L,5L,5L,1L,17L,1L,1L,54L,1L,1L,17L,1L,5L,5L,1L,17L,1L,1L,54L,1L,1L,17L,1L,5L,5L,1L,17L,1L,1L,54L,1L,1L,17L,1L,5L,5L,1L,17L,1L,1L,54L,1L,1L,17L,1L,5L,5L,1L,17L,1L,1L,54L,1L,1L,17L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040729Inst : IEnumerable<long>
{
public static readonly long[] Value=A040729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040729.Bytes);
public long this[int i]=>Value[i];

public static A040729Inst Instance=new A040729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040730
{
public static readonly long[] Value={ 27L,1L,1L,7L,2L,1L,3L,3L,1L,26L,1L,3L,3L,1L,2L,7L,1L,1L,54L,1L,1L,7L,2L,1L,3L,3L,1L,26L,1L,3L,3L,1L,2L,7L,1L,1L,54L,1L,1L,7L,2L,1L,3L,3L,1L,26L,1L,3L,3L,1L,2L,7L,1L,1L,54L,1L,1L,7L,2L,1L,3L,3L,1L,26L,1L,3L,3L,1L,2L,7L,1L,1L,54L,1L,1L,7L,2L,1L,3L,3L,1L,26L,1L,3L,3L,1L,2L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040730Inst : IEnumerable<long>
{
public static readonly long[] Value=A040730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040730.Bytes);
public long this[int i]=>Value[i];

public static A040730Inst Instance=new A040730Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040731
{
public static readonly long[] Value={ 27L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L,4L,1L,1L,54L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040731Inst : IEnumerable<long>
{
public static readonly long[] Value=A040731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040731.Bytes);
public long this[int i]=>Value[i];

public static A040731Inst Instance=new A040731Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040732
{
public static readonly long[] Value={ 27L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L,54L,1L,1L,3L,5L,1L,5L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040732Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040732.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040732Inst : IEnumerable<long>
{
public static readonly long[] Value=A040732.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040732.Bytes);
public long this[int i]=>Value[i];

public static A040732Inst Instance=new A040732Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040749
{
public static readonly long[] Value={ 27L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L,54L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040749Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040749.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040749Inst : IEnumerable<long>
{
public static readonly long[] Value=A040749.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040749.Bytes);
public long this[int i]=>Value[i];

public static A040749Inst Instance=new A040749Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040750
{
public static readonly long[] Value={ 27L,1L,8L,3L,5L,1L,7L,7L,1L,5L,3L,8L,1L,54L,1L,8L,3L,5L,1L,7L,7L,1L,5L,3L,8L,1L,54L,1L,8L,3L,5L,1L,7L,7L,1L,5L,3L,8L,1L,54L,1L,8L,3L,5L,1L,7L,7L,1L,5L,3L,8L,1L,54L,1L,8L,3L,5L,1L,7L,7L,1L,5L,3L,8L,1L,54L,1L,8L,3L,5L,1L,7L,7L,1L,5L,3L,8L,1L,54L,1L,8L,3L,5L,1L,7L,7L,1L,5L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040750Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040750.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040750Inst : IEnumerable<long>
{
public static readonly long[] Value=A040750.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040750.Bytes);
public long this[int i]=>Value[i];

public static A040750Inst Instance=new A040750Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040751
{
public static readonly long[] Value={ 27L,1L,10L,5L,2L,27L,2L,5L,10L,1L,54L,1L,10L,5L,2L,27L,2L,5L,10L,1L,54L,1L,10L,5L,2L,27L,2L,5L,10L,1L,54L,1L,10L,5L,2L,27L,2L,5L,10L,1L,54L,1L,10L,5L,2L,27L,2L,5L,10L,1L,54L,1L,10L,5L,2L,27L,2L,5L,10L,1L,54L,1L,10L,5L,2L,27L,2L,5L,10L,1L,54L,1L,10L,5L,2L,27L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040751Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040751.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040751Inst : IEnumerable<long>
{
public static readonly long[] Value=A040751.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040751.Bytes);
public long this[int i]=>Value[i];

public static A040751Inst Instance=new A040751Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040752
{
public static readonly long[] Value={ 27L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L,1L,54L,1L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040752Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040752.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040752Inst : IEnumerable<long>
{
public static readonly long[] Value=A040752.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040752.Bytes);
public long this[int i]=>Value[i];

public static A040752Inst Instance=new A040752Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040753
{
public static readonly long[] Value={ 27L,1L,17L,1L,1L,1L,5L,1L,1L,4L,1L,1L,5L,1L,1L,1L,17L,1L,54L,1L,17L,1L,1L,1L,5L,1L,1L,4L,1L,1L,5L,1L,1L,1L,17L,1L,54L,1L,17L,1L,1L,1L,5L,1L,1L,4L,1L,1L,5L,1L,1L,1L,17L,1L,54L,1L,17L,1L,1L,1L,5L,1L,1L,4L,1L,1L,5L,1L,1L,1L,17L,1L,54L,1L,17L,1L,1L,1L,5L,1L,1L,4L,1L,1L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040753Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040753.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040753Inst : IEnumerable<long>
{
public static readonly long[] Value=A040753.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040753.Bytes);
public long this[int i]=>Value[i];

public static A040753Inst Instance=new A040753Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040754
{
public static readonly long[] Value={ 27L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L,1L,54L,1L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040754Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040754.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040754Inst : IEnumerable<long>
{
public static readonly long[] Value=A040754.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040754.Bytes);
public long this[int i]=>Value[i];

public static A040754Inst Instance=new A040754Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040755
{
public static readonly long[] Value={ 27L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L,1L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040755Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040755.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040755Inst : IEnumerable<long>
{
public static readonly long[] Value=A040755.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040755.Bytes);
public long this[int i]=>Value[i];

public static A040755Inst Instance=new A040755Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040756
{
public static readonly long[] Value={ 28L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040756Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040756.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040756Inst : IEnumerable<long>
{
public static readonly long[] Value=A040756.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040756.Bytes);
public long this[int i]=>Value[i];

public static A040756Inst Instance=new A040756Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040757
{
public static readonly long[] Value={ 28L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L,28L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040757Inst : IEnumerable<long>
{
public static readonly long[] Value=A040757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040757.Bytes);
public long this[int i]=>Value[i];

public static A040757Inst Instance=new A040757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040758
{
public static readonly long[] Value={ 28L,18L,1L,2L,5L,1L,8L,1L,1L,27L,1L,1L,8L,1L,5L,2L,1L,18L,56L,18L,1L,2L,5L,1L,8L,1L,1L,27L,1L,1L,8L,1L,5L,2L,1L,18L,56L,18L,1L,2L,5L,1L,8L,1L,1L,27L,1L,1L,8L,1L,5L,2L,1L,18L,56L,18L,1L,2L,5L,1L,8L,1L,1L,27L,1L,1L,8L,1L,5L,2L,1L,18L,56L,18L,1L,2L,5L,1L,8L,1L,1L,27L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040758Inst : IEnumerable<long>
{
public static readonly long[] Value=A040758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040758.Bytes);
public long this[int i]=>Value[i];

public static A040758Inst Instance=new A040758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040759
{
public static readonly long[] Value={ 28L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L,14L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040759Inst : IEnumerable<long>
{
public static readonly long[] Value=A040759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040759.Bytes);
public long this[int i]=>Value[i];

public static A040759Inst Instance=new A040759Inst();

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