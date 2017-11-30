using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A175464
{
public static readonly long[] Value={ 1111L,3513L,3514L,9013L,11109L,11110L,11111L,11112L,11113L,14357L,14572L,20524L,22635L,30205L,33518L,35129L,35130L,35131L,35132L,35133L,35134L,35135L,35136L,35137L,35138L,35139L,35140L,35141L,35142L,39003L,39549L,40154L,42616L,46081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175464Inst : IEnumerable<long>
{
public static readonly long[] Value=A175464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175464.Bytes);
public long this[int i]=>Value[i];

public static A175464Inst Instance=new A175464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175465
{
public static readonly long[] Value={ 1L,2L,1L,1L,3L,1L,1L,1L,2L,4L,2L,2L,2L,1L,1L,1L,2L,3L,2L,3L,5L,3L,2L,1L,2L,3L,2L,1L,2L,1L,1L,1L,2L,3L,1L,2L,4L,2L,1L,3L,4L,6L,4L,2L,4L,3L,2L,1L,1L,2L,3L,2L,4L,2L,1L,2L,1L,3L,1L,1L,2L,1L,1L,1L,2L,3L,1L,2L,4L,2L,2L,2L,3L,5L,3L,3L,3L,2L,1L,3L,4L,5L,3L,5L,7L,5L,4L,2L,3L,5L,3L,2L,4L,3L,2L,1L,1L,2L,2L,3L,3L,3L,2L,2L,3L,5L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175465Inst : IEnumerable<long>
{
public static readonly long[] Value=A175465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175465.Bytes);
public long this[int i]=>Value[i];

public static A175465Inst Instance=new A175465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175466
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,2L,3L,2L,1L,1L,2L,1L,1L,2L,1L,1L,2L,1L,4L,1L,2L,1L,1L,1L,3L,2L,2L,3L,1L,1L,1L,2L,3L,2L,5L,2L,3L,2L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175466Inst : IEnumerable<long>
{
public static readonly long[] Value=A175466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175466.Bytes);
public long this[int i]=>Value[i];

public static A175466Inst Instance=new A175466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175467
{
public static readonly long[] Value={ 1L,2L,5L,10L,5L,10L,21L,42L,21L,10L,21L,42L,21L,42L,85L,170L,85L,42L,85L,42L,21L,42L,85L,170L,85L,42L,85L,170L,85L,170L,341L,682L,341L,170L,341L,170L,85L,170L,341L,170L,85L,42L,85L,170L,85L,170L,341L,682L,341L,170L,341L,170L,85L,170L,341L,682L,341L,170L,341L,682L,341L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175467Inst : IEnumerable<long>
{
public static readonly long[] Value=A175467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175467.Bytes);
public long this[int i]=>Value[i];

public static A175467Inst Instance=new A175467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175468
{
public static readonly long[] Value={ 3L,5L,9L,10L,15L,17L,18L,27L,33L,34L,36L,45L,51L,54L,63L,65L,66L,68L,85L,99L,102L,119L,129L,130L,132L,136L,153L,165L,170L,187L,195L,198L,204L,221L,231L,238L,255L,257L,258L,260L,264L,297L,325L,330L,363L,387L,390L,396L,429L,455L,462L,495L,513L,514L,516L,520L,528L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175468Inst : IEnumerable<long>
{
public static readonly long[] Value=A175468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175468.Bytes);
public long this[int i]=>Value[i];

public static A175468Inst Instance=new A175468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175469
{
public static readonly long[] Value={ 1L,1L,1L,2L,3L,1L,2L,3L,1L,2L,4L,5L,3L,6L,7L,1L,2L,4L,5L,3L,6L,7L,1L,2L,4L,8L,9L,5L,10L,11L,3L,6L,12L,13L,7L,14L,15L,1L,2L,4L,8L,9L,5L,10L,11L,3L,6L,12L,13L,7L,14L,15L,1L,2L,4L,8L,16L,17L,9L,18L,19L,5L,10L,20L,21L,11L,22L,23L,3L,6L,12L,24L,25L,13L,26L,27L,7L,14L,28L,29L,15L,30L,31L,1L,2L,4L,8L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175469Inst : IEnumerable<long>
{
public static readonly long[] Value=A175469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175469.Bytes);
public long this[int i]=>Value[i];

public static A175469Inst Instance=new A175469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175470
{
public static readonly long[] Value={ 1L,2L,3L,2L,2L,4L,3L,3L,5L,4L,3L,3L,4L,3L,3L,6L,5L,4L,4L,5L,4L,4L,7L,6L,5L,4L,4L,5L,4L,4L,6L,5L,4L,4L,5L,4L,4L,8L,7L,6L,5L,5L,6L,5L,5L,7L,6L,5L,5L,6L,5L,5L,9L,8L,7L,6L,5L,5L,6L,5L,5L,7L,6L,5L,5L,6L,5L,5L,8L,7L,6L,5L,5L,6L,5L,5L,7L,6L,5L,5L,6L,5L,5L,10L,9L,8L,7L,6L,6L,7L,6L,6L,8L,7L,6L,6L,7L,6L,6L,9L,8L,7L,6L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175470Inst : IEnumerable<long>
{
public static readonly long[] Value=A175470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175470.Bytes);
public long this[int i]=>Value[i];

public static A175470Inst Instance=new A175470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175471
{
public static readonly long[] Value={ 3L,24L,26L,76L,83L,87L,236L,264L,313L,314L,316L,766L,816L,824L,834L,836L,883L,887L,937L,2366L,2383L,2387L,2424L,2563L,2626L,2976L,3114L,7613L,7666L,8117L,8167L,8184L,8234L,8286L,8366L,8716L,8813L,8814L,8887L,8937L,9266L,9316L,9363L,9417L,9474L,9786L,9833L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175471Inst : IEnumerable<long>
{
public static readonly long[] Value=A175471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175471.Bytes);
public long this[int i]=>Value[i];

public static A175471Inst Instance=new A175471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175472
{
public static readonly long[] Value={ 5L,0L,4L,0L,8L,3L,0L,0L,8L,2L,6L,4L,4L,5L,5L,4L,0L,9L,2L,5L,8L,2L,6L,9L,3L,0L,4L,5L,3L,3L,3L,0L,2L,4L,9L,8L,9L,5L,5L,3L,8L,5L,1L,8L,2L,3L,6L,8L,5L,7L,9L,8L,4L,5L,1L,7L,7L,2L,6L,9L,5L,8L,4L,5L,0L,9L,5L,9L,3L,8L,3L,3L,7L,1L,3L,4L,7L,8L,8L,6L,4L,6L,2L,5L,6L,4L,4L,7L,9L,3L,8L,1L,5L,1L,3L,6L,5L,2L,5L,4L,6L,8L,0L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175472Inst : IEnumerable<long>
{
public static readonly long[] Value=A175472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175472.Bytes);
public long this[int i]=>Value[i];

public static A175472Inst Instance=new A175472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175473
{
public static readonly long[] Value={ 1L,5L,7L,3L,4L,9L,8L,4L,7L,3L,1L,6L,2L,3L,9L,0L,4L,5L,8L,7L,7L,8L,2L,8L,6L,0L,4L,3L,6L,9L,0L,4L,3L,4L,6L,1L,2L,6L,5L,5L,0L,4L,0L,8L,5L,9L,1L,1L,6L,8L,4L,6L,1L,4L,9L,9L,3L,0L,1L,4L,2L,5L,6L,8L,7L,9L,7L,0L,2L,0L,3L,4L,4L,3L,9L,6L,5L,1L,4L,0L,4L,8L,1L,0L,4L,7L,3L,2L,3L,9L,8L,2L,5L,1L,8L,8L,5L,6L,2L,8L,1L,8L,7L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175473Inst : IEnumerable<long>
{
public static readonly long[] Value=A175473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175473.Bytes);
public long this[int i]=>Value[i];

public static A175473Inst Instance=new A175473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175474
{
public static readonly long[] Value={ 2L,6L,1L,0L,7L,2L,0L,8L,6L,8L,4L,4L,4L,1L,4L,4L,6L,5L,0L,0L,0L,1L,5L,3L,7L,7L,1L,5L,7L,1L,8L,7L,2L,4L,2L,0L,7L,9L,5L,1L,0L,7L,4L,0L,1L,0L,8L,7L,3L,4L,8L,0L,2L,4L,4L,1L,9L,0L,6L,5L,0L,8L,7L,5L,6L,0L,3L,7L,5L,7L,4L,7L,3L,3L,1L,3L,8L,3L,8L,6L,3L,7L,5L,6L,5L,3L,6L,1L,5L,4L,9L,6L,2L,5L,2L,7L,0L,7L,1L,1L,9L,5L,9L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175474Inst : IEnumerable<long>
{
public static readonly long[] Value=A175474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175474.Bytes);
public long this[int i]=>Value[i];

public static A175474Inst Instance=new A175474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175475
{
public static readonly long[] Value={ 0L,4L,8L,6L,0L,8L,3L,8L,8L,2L,9L,1L,1L,3L,1L,5L,6L,6L,9L,0L,7L,1L,8L,3L,0L,3L,9L,3L,4L,3L,4L,0L,7L,4L,2L,1L,3L,5L,4L,3L,2L,9L,5L,8L,0L,4L,7L,8L,1L,4L,0L,5L,4L,2L,3L,1L,6L,8L,0L,5L,2L,8L,5L,0L,5L,1L,4L,8L,8L,2L,3L,5L,7L,3L,5L,9L,3L,2L,4L,7L,2L,0L,0L,4L,0L,9L,1L,2L,9L,3L,3L,7L,1L,1L,6L,7L,7L,0L,7L,9L,6L,8L,0L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175475Inst : IEnumerable<long>
{
public static readonly long[] Value=A175475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175475.Bytes);
public long this[int i]=>Value[i];

public static A175475Inst Instance=new A175475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175476
{
public static readonly long[] Value={ 5L,5L,6L,8L,3L,2L,7L,9L,9L,6L,8L,3L,1L,7L,0L,7L,8L,4L,5L,2L,8L,4L,8L,1L,7L,9L,8L,2L,1L,1L,8L,8L,3L,5L,7L,0L,2L,0L,1L,3L,6L,2L,4L,3L,9L,0L,2L,8L,3L,2L,4L,3L,9L,1L,0L,7L,5L,3L,6L,7L,5L,8L,1L,8L,8L,2L,9L,7L,4L,5L,5L,3L,3L,6L,4L,7L,7L,9L,5L,7L,0L,2L,2L,1L,2L,1L,7L,7L,6L,8L,7L,3L,8L,4L,7L,0L,8L,4L,9L,4L,0L,9L,7L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175476Inst : IEnumerable<long>
{
public static readonly long[] Value=A175476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175476.Bytes);
public long this[int i]=>Value[i];

public static A175476Inst Instance=new A175476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175477
{
public static readonly long[] Value={ 1L,2L,7L,6L,4L,0L,5L,2L,9L,3L,5L,0L,3L,2L,6L,8L,1L,2L,7L,1L,2L,6L,3L,2L,8L,0L,9L,5L,0L,7L,6L,8L,5L,7L,4L,7L,6L,1L,9L,9L,8L,4L,0L,4L,7L,3L,2L,5L,6L,1L,4L,3L,7L,0L,6L,0L,5L,8L,7L,5L,7L,2L,0L,7L,4L,1L,3L,0L,0L,9L,6L,0L,2L,7L,2L,5L,6L,1L,9L,6L,2L,2L,0L,8L,2L,7L,1L,0L,6L,4L,7L,8L,3L,6L,4L,9L,0L,5L,4L,6L,6L,9L,5L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175477Inst : IEnumerable<long>
{
public static readonly long[] Value=A175477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175477.Bytes);
public long this[int i]=>Value[i];

public static A175477Inst Instance=new A175477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175478
{
public static readonly long[] Value={ 1L,2L,0L,6L,9L,4L,8L,9L,6L,0L,8L,1L,2L,5L,8L,1L,9L,7L,7L,8L,4L,3L,7L,7L,9L,1L,2L,3L,8L,4L,9L,3L,6L,5L,9L,1L,3L,6L,1L,8L,4L,6L,3L,3L,4L,6L,6L,2L,9L,2L,2L,1L,9L,8L,4L,8L,1L,6L,7L,2L,6L,8L,4L,0L,0L,5L,8L,2L,1L,5L,5L,1L,4L,8L,0L,7L,9L,8L,5L,2L,5L,4L,4L,5L,8L,5L,4L,4L,3L,0L,1L,7L,7L,1L,4L,0L,9L,3L,3L,3L,4L,2L,2L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175478Inst : IEnumerable<long>
{
public static readonly long[] Value=A175478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175478.Bytes);
public long this[int i]=>Value[i];

public static A175478Inst Instance=new A175478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175479
{
public static readonly long[] Value={ 1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L,0L,1L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,0L,0L,1L,0L,1L,0L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,0L,0L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175479Inst : IEnumerable<long>
{
public static readonly long[] Value=A175479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175479.Bytes);
public long this[int i]=>Value[i];

public static A175479Inst Instance=new A175479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175480
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,0L,1L,1L,0L,0L,1L,0L,0L,1L,0L,1L,1L,0L,1L,0L,1L,1L,0L,1L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175480Inst : IEnumerable<long>
{
public static readonly long[] Value=A175480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175480.Bytes);
public long this[int i]=>Value[i];

public static A175480Inst Instance=new A175480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175481
{
public static readonly long[] Value={ 1L,1L,2L,3L,5L,10L,11L,11L,13L,15L,36L,49L,42L,56L,54L,47L,42L,53L,52L,57L,112L,129L,131L,136L,163L,137L,183L,196L,198L,192L,162L,109L,218L,172L,275L,273L,151L,213L,196L,181L,343L,285L,367L,395L,437L,549L,389L,403L,524L,645L,409L,418L,568L,632L,608L,587L,719L,576L,570L,599L,565L,533L,393L,255L,595L,569L,565L,494L,984L,819L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175481Inst : IEnumerable<long>
{
public static readonly long[] Value=A175481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175481.Bytes);
public long this[int i]=>Value[i];

public static A175481Inst Instance=new A175481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175482
{
public static readonly long[] Value={ 3L,3L,7L,5L,3L,7L,3L,5L,3L,13L,3L,11L,7L,3L,11L,5L,3L,7L,19L,5L,3L,7L,5L,17L,3L,11L,13L,5L,3L,7L,19L,3L,17L,3L,5L,3L,7L,11L,3L,3L,11L,19L,17L,7L,3L,13L,5L,7L,23L,17L,3L,3L,11L,7L,3L,13L,5L,29L,5L,7L,13L,5L,3L,3L,31L,19L,23L,3L,11L,5L,3L,3L,13L,7L,19L,3L,37L,23L,5L,7L,11L,5L,17L,7L,5L,13L,3L,3L,31L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175482Inst : IEnumerable<long>
{
public static readonly long[] Value=A175482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175482.Bytes);
public long this[int i]=>Value[i];

public static A175482Inst Instance=new A175482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175483
{
public static readonly long[] Value={ 7L,23L,11L,17L,31L,19L,47L,41L,71L,17L,79L,23L,43L,103L,31L,73L,127L,59L,23L,89L,151L,67L,97L,29L,167L,47L,41L,113L,191L,83L,31L,199L,37L,223L,137L,239L,107L,71L,263L,271L,79L,47L,53L,131L,311L,73L,193L,139L,43L,61L,359L,367L,103L,163L,383L,89L,233L,41L,241L,179L,97L,257L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175483Inst : IEnumerable<long>
{
public static readonly long[] Value=A175483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175483.Bytes);
public long this[int i]=>Value[i];

public static A175483Inst Instance=new A175483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175484
{
public static readonly long[] Value={ 5L,13L,9L,11L,17L,13L,25L,23L,37L,15L,41L,17L,25L,53L,21L,39L,65L,33L,21L,47L,77L,37L,51L,23L,85L,29L,27L,59L,97L,45L,25L,101L,27L,113L,71L,121L,57L,41L,133L,137L,45L,33L,35L,69L,157L,43L,99L,73L,33L,39L,181L,185L,57L,85L,193L,51L,119L,35L,123L,93L,55L,131L,217L,221L,37L,45L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175484Inst : IEnumerable<long>
{
public static readonly long[] Value=A175484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175484.Bytes);
public long this[int i]=>Value[i];

public static A175484Inst Instance=new A175484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175485
{
public static readonly long[] Value={ 1L,5L,14L,15L,11L,91L,20L,51L,95L,77L,46L,325L,63L,145L,248L,187L,105L,703L,130L,287L,473L,345L,188L,1225L,221L,477L,770L,551L,295L,1891L,336L,715L,1139L,805L,426L,2701L,475L,1001L,1580L,1107L,581L,3655L,638L,1335L,2093L,1457L,760L,4753L,825L,1717L,2678L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175485Inst : IEnumerable<long>
{
public static readonly long[] Value=A175485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175485.Bytes);
public long this[int i]=>Value[i];

public static A175485Inst Instance=new A175485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175486
{
public static readonly long[] Value={ 125L,325L,725L,845L,925L,1325L,1525L,1885L,2197L,2405L,2525L,2725L,3125L,3445L,3725L,3925L,3965L,4205L,4325L,4525L,4901L,4925L,5365L,5725L,6253L,6565L,6725L,6845L,6925L,7085L,7325L,7685L,7925L,8125L,8725L,8845L,8957L,9325L,9685L,9725L,9805L,9925L,10205L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175486Inst : IEnumerable<long>
{
public static readonly long[] Value=A175486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175486.Bytes);
public long this[int i]=>Value[i];

public static A175486Inst Instance=new A175486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175487
{
public static readonly ulong[] Value={ 2L,7L,37L,127L,397L,3613L,18089L,162881L,1791787L,41211197L,370900973L,4821712733L,43395414737L,477349562419L,4296146062051L,227695741289567L,9335525392876531L,326743388750679161L,16663912826284638251UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175487Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A175487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175487.Bytes);
public ulong this[int i]=>Value[i];

public static A175487Inst Instance=new A175487Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175488
{
public static readonly long[] Value={ 1L,1L,2L,1L,1L,3L,1L,2L,1L,4L,1L,2L,1L,2L,5L,1L,2L,3L,2L,2L,6L,1L,1L,3L,1L,1L,3L,7L,1L,2L,1L,4L,2L,2L,1L,8L,1L,2L,1L,4L,2L,2L,1L,4L,9L,1L,2L,1L,2L,5L,2L,1L,2L,2L,10L,1L,2L,3L,2L,5L,3L,3L,2L,2L,5L,11L,1L,2L,3L,4L,2L,6L,3L,4L,4L,2L,3L,12L,1L,2L,3L,2L,5L,6L,3L,2L,2L,5L,5L,6L,13L,1L,2L,3L,2L,2L,6L,7L,2L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175488Inst : IEnumerable<long>
{
public static readonly long[] Value=A175488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175488.Bytes);
public long this[int i]=>Value[i];

public static A175488Inst Instance=new A175488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175489
{
public static readonly long[] Value={ 1L,3L,5L,8L,11L,16L,17L,21L,26L,28L,39L,46L,55L,58L,51L,54L,63L,65L,85L,87L,82L,104L,118L,128L,144L,147L,163L,176L,193L,181L,141L,137L,154L,156L,192L,162L,212L,231L,252L,247L,275L,202L,267L,307L,306L,333L,336L,345L,373L,381L,410L,412L,419L,423L,475L,497L,532L,539L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175489Inst : IEnumerable<long>
{
public static readonly long[] Value=A175489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175489.Bytes);
public long this[int i]=>Value[i];

public static A175489Inst Instance=new A175489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175490
{
public static readonly long[] Value={ 1L,2L,3L,8L,20L,144L,63L,256L,1152L,1600L,118800L,995328L,8424000L,12192768L,178605L,1048576L,8912896L,21233664L,27572576256L,13107200000L,537600000L,2032335360000L,30928035600000L,760840571584512L,13541327555788800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175490Inst : IEnumerable<long>
{
public static readonly long[] Value=A175490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175490.Bytes);
public long this[int i]=>Value[i];

public static A175490Inst Instance=new A175490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175491
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,11L,17L,25L,35L,49L,64L,89L,122L,174L,235L,286L,334L,407L,473L,581L,690L,824L,976L,1206L,1449L,1811L,2183L,2718L,3306L,4173L,5070L,5659L,6071L,6769L,7279L,8137L,8716L,9765L,10587L,11907L,12940L,14631L,15649L,17600L,19231L,21729L,24004L,27228L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175491Inst : IEnumerable<long>
{
public static readonly long[] Value=A175491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175491.Bytes);
public long this[int i]=>Value[i];

public static A175491Inst Instance=new A175491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175492
{
public static readonly long[] Value={ 7L,10L,24L,26L,65L,13777L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175492Inst : IEnumerable<long>
{
public static readonly long[] Value=A175492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175492.Bytes);
public long this[int i]=>Value[i];

public static A175492Inst Instance=new A175492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175493
{
public static readonly BigInteger[] Value={ 1L,4L,36L,2304L,57600L,74649600L,3657830400L,14982473318400L,10922223049113600L,BigInteger.Parse("109222230491136000000"),BigInteger.Parse("13215889889427456000000"),BigInteger.Parse("39462435755592152776704000000"),BigInteger.Parse("6669151642695073819262976000000") };
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
public class A175493Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175493.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175493Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175493.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175493.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175493Inst Instance=new A175493Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175494
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,2L,1L,3L,1L,3L,1L,1L,1L,4L,1L,4L,1L,2L,2L,4L,1L,2L,2L,2L,1L,5L,1L,5L,1L,2L,2L,2L,1L,6L,2L,2L,1L,6L,1L,6L,1L,1L,2L,6L,1L,3L,1L,2L,1L,7L,1L,2L,1L,2L,2L,7L,1L,7L,2L,1L,1L,2L,1L,8L,2L,2L,1L,8L,1L,8L,2L,2L,2L,2L,1L,8L,1L,2L,3L,9L,1L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175494Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175494.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175494Inst : IEnumerable<long>
{
public static readonly long[] Value=A175494.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175494.Bytes);
public long this[int i]=>Value[i];

public static A175494Inst Instance=new A175494Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175495
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,8L,10L,12L,14L,15L,16L,18L,20L,24L,28L,30L,32L,36L,40L,42L,44L,45L,48L,50L,52L,54L,56L,60L,63L,64L,66L,70L,72L,78L,80L,84L,88L,90L,96L,100L,102L,104L,105L,108L,110L,112L,114L,120L,126L,128L,130L,132L,135L,136L,138L,140L,144L,150L,152L,154L,156L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175495Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175495.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175495Inst : IEnumerable<long>
{
public static readonly long[] Value=A175495.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175495.Bytes);
public long this[int i]=>Value[i];

public static A175495Inst Instance=new A175495Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175496
{
public static readonly long[] Value={ 8L,24L,27L,40L,54L,56L,88L,104L,120L,125L,128L,135L,136L,152L,168L,184L,189L,216L,232L,248L,250L,264L,270L,280L,296L,297L,312L,328L,343L,344L,351L,375L,376L,378L,384L,408L,424L,440L,456L,459L,472L,488L,513L,520L,536L,552L,568L,584L,594L,616L,621L,632L,640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175496Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175496.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175496Inst : IEnumerable<long>
{
public static readonly long[] Value=A175496.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175496.Bytes);
public long this[int i]=>Value[i];

public static A175496Inst Instance=new A175496Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175497
{
public static readonly long[] Value={ 0L,6L,30L,35L,84L,180L,204L,210L,297L,330L,546L,840L,1170L,1189L,1224L,1710L,2310L,2940L,2970L,3036L,3230L,3900L,4914L,6090L,6930L,7134L,7140L,7245L,7440L,8976L,10710L,12654L,14175L,14820L,16296L,16380L,17220L,19866L,22770L,25172L,25944L,29103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175497Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175497.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175497Inst : IEnumerable<long>
{
public static readonly long[] Value=A175497.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175497.Bytes);
public long this[int i]=>Value[i];

public static A175497Inst Instance=new A175497Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175498
{
public static readonly long[] Value={ 1L,2L,4L,3L,6L,10L,5L,11L,7L,12L,9L,16L,8L,17L,15L,23L,13L,24L,18L,28L,14L,26L,19L,32L,20L,34L,21L,36L,25L,41L,22L,39L,30L,48L,27L,46L,29L,49L,31L,52L,37L,59L,33L,56L,40L,64L,35L,60L,38L,65L,42L,68L,43L,71L,44L,73L,45L,75L,51L,82L,47L,79L,112L,50L,84L,53L,88L,54L,90L,57L,94L,55L,93L,61L,100L,58L,98L,62L,103L,63L,105L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175498Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175498.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175498Inst : IEnumerable<long>
{
public static readonly long[] Value=A175498.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175498.Bytes);
public long this[int i]=>Value[i];

public static A175498Inst Instance=new A175498Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175499
{
public static readonly long[] Value={ 1L,2L,-1L,3L,4L,-5L,6L,-4L,5L,-3L,7L,-8L,9L,-2L,8L,-10L,11L,-6L,10L,-14L,12L,-7L,13L,-12L,14L,-13L,15L,-11L,16L,-19L,17L,-9L,18L,-21L,19L,-17L,20L,-18L,21L,-15L,22L,-26L,23L,-16L,24L,-29L,25L,-22L,27L,-23L,26L,-25L,28L,-27L,29L,-28L,30L,-24L,31L,-35L,32L,33L,-62L,34L,-31L,35L,-34L,36L,-33L,37L,-39L,38L,-32L,39L,-42L,40L,-36L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175499Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175499.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175499Inst : IEnumerable<long>
{
public static readonly long[] Value=A175499.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175499.Bytes);
public long this[int i]=>Value[i];

public static A175499Inst Instance=new A175499Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175500
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,12L,8L,9L,10L,14L,16L,11L,24L,13L,36L,15L,18L,17L,48L,19L,60L,20L,25L,28L,30L,21L,40L,32L,44L,64L,22L,72L,23L,81L,26L,80L,27L,100L,29L,120L,31L,144L,33L,168L,34L,180L,35L,192L,37L,240L,38L,324L,41L,252L,42L,49L,54L,56L,84L,39L,336L,43L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175500Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175500.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175500Inst : IEnumerable<long>
{
public static readonly long[] Value=A175500.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175500.Bytes);
public long this[int i]=>Value[i];

public static A175500Inst Instance=new A175500Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175501
{
public static readonly long[] Value={ 1L,2L,2L,3L,2L,4L,2L,6L,4L,3L,4L,4L,5L,2L,8L,2L,9L,4L,6L,2L,10L,2L,12L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175501Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175501.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175501Inst : IEnumerable<long>
{
public static readonly long[] Value=A175501.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175501.Bytes);
public long this[int i]=>Value[i];

public static A175501Inst Instance=new A175501Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175502
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,5L,12L,8L,10L,16L,7L,24L,9L,18L,20L,30L,14L,36L,11L,48L,15L,60L,13L,64L,21L,120L,17L,144L,22L,180L,19L,192L,25L,49L,72L,28L,80L,40L,42L,81L,32L,100L,54L,84L,90L,112L,121L,168L,44L,240L,23L,360L,26L,320L,45L,252L,56L,210L,96L,196L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175502Inst : IEnumerable<long>
{
public static readonly long[] Value=A175502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175502.Bytes);
public long this[int i]=>Value[i];

public static A175502Inst Instance=new A175502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175503
{
public static readonly long[] Value={ 1L,2L,2L,3L,4L,2L,6L,4L,4L,5L,2L,8L,3L,6L,6L,8L,4L,9L,2L,10L,4L,12L,2L,7L,4L,16L,2L,15L,4L,18L,2L,14L,3L,3L,12L,6L,10L,8L,8L,5L,6L,9L,8L,12L,12L,10L,3L,16L,6L,20L,2L,24L,4L,14L,6L,18L,8L,16L,12L,9L,10L,10L,16L,9L,3L,18L,12L,15L,6L,24L,8L,20L,4L,21L,2L,30L,4L,32L,2L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175503Inst : IEnumerable<long>
{
public static readonly long[] Value=A175503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175503.Bytes);
public long this[int i]=>Value[i];

public static A175503Inst Instance=new A175503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175504
{
public static readonly BigInteger[] Value={ 1L,1L,3L,4L,125L,6L,16807L,512L,59049L,1000L,2357947691L,1728L,1792160394037L,537824L,170859375L,268435456L,2862423051509815793L,1889568L,BigInteger.Parse("5480386857784802185939"),1280000000L,350277500542221L };
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
public class A175504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175504Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175504.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175504.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175504Inst Instance=new A175504Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175505
{
public static readonly long[] Value={ 1L,1L,5L,5L,3L,13L,13L,21L,53L,7L,7L,49L,25L,29L,31L,85L,11L,109L,37L,27L,43L,15L,15L,193L,83L,53L,485L,113L,19L,59L,61L,341L,67L,23L,71L,433L,73L,77L,79L,107L,27L,83L,85L,59L,271L,31L,31L,769L,685L,167L,103L,209L,35L,973L,37L,449L,115L,39L,39L,239L,121L,125L,379L,1365L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175505Inst : IEnumerable<long>
{
public static readonly long[] Value=A175505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175505.Bytes);
public long this[int i]=>Value[i];

public static A175505Inst Instance=new A175505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175506
{
public static readonly long[] Value={ 1L,1L,3L,2L,1L,3L,3L,4L,9L,1L,1L,6L,3L,3L,3L,8L,1L,9L,3L,2L,3L,1L,1L,12L,5L,3L,27L,6L,1L,3L,3L,16L,3L,1L,3L,18L,3L,3L,3L,4L,1L,3L,3L,2L,9L,1L,1L,24L,21L,5L,3L,6L,1L,27L,1L,12L,3L,1L,1L,6L,3L,3L,9L,32L,3L,3L,3L,2L,3L,3L,1L,36L,3L,3L,15L,6L,3L,3L,3L,8L,81L,1L,1L,6L,1L,3L,3L,4L,1L,9L,1L,2L,3L,1L,3L,48L,3L,21L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175506Inst : IEnumerable<long>
{
public static readonly long[] Value=A175506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175506.Bytes);
public long this[int i]=>Value[i];

public static A175506Inst Instance=new A175506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175507
{
public static readonly long[] Value={ 7980L,8190L,9360L,10920L,11760L,11880L,12870L,13230L,13860L,14820L,15960L,16380L,16740L,17640L,17940L,18216L,18270L,18360L,18720L,18810L,18900L,19040L,19080L,19140L,19656L,19740L,20196L,20580L,20790L,20880L,21168L,21560L,21840L,22176L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175507Inst : IEnumerable<long>
{
public static readonly long[] Value=A175507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175507.Bytes);
public long this[int i]=>Value[i];

public static A175507Inst Instance=new A175507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175508
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,4L,3L,7L,5L,7L,6L,10L,7L,10L,9L,15L,10L,14L,11L,17L,13L,17L,14L,22L,16L,20L,19L,24L,19L,24L,20L,31L,23L,26L,23L,32L,25L,30L,27L,37L,28L,34L,29L,39L,33L,37L,32L,46L,33L,41L,37L,46L,37L,46L,40L,52L,41L,48L,42L,54L,43L,51L,47L,63L,47L,56L,48L,61L,51L,58L,51L,68L,52L,62L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175508Inst : IEnumerable<long>
{
public static readonly long[] Value=A175508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175508.Bytes);
public long this[int i]=>Value[i];

public static A175508Inst Instance=new A175508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175509
{
public static readonly long[] Value={ -2L,-2L,-3L,2L,-2L,4L,-4L,2L,1L,5L,-4L,1L,7L,9L,9L,1L,-3L,9L,8L,7L,7L,9L,11L,5L,-2L,4L,-3L,-1L,6L,11L,12L,16L,17L,19L,2L,-5L,-11L,-10L,-1L,7L,10L,16L,9L,12L,21L,13L,15L,16L,15L,22L,11L,10L,11L,13L,9L,17L,7L,9L,11L,12L,17L,6L,-4L,3L,7L,7L,15L,27L,21L,25L,28L,35L,37L,43L,43L,41L,31L,31L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175509Inst : IEnumerable<long>
{
public static readonly long[] Value=A175509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175509.Bytes);
public long this[int i]=>Value[i];

public static A175509Inst Instance=new A175509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175510
{
public static readonly long[] Value={ -1L,1L,3L,7L,15L,25L,33L,43L,45L,55L,63L,61L,69L,55L,81L,37L,63L,67L,93L,73L,141L,133L,159L,163L,207L,217L,231L,247L,261L,355L,363L,349L,375L,343L,477L,469L,483L,439L,465L,457L,531L,439L,447L,439L,453L,505L,525L,439L,441L,469L,477L,469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175510Inst : IEnumerable<long>
{
public static readonly long[] Value=A175510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175510.Bytes);
public long this[int i]=>Value[i];

public static A175510Inst Instance=new A175510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175511
{
public static readonly long[] Value={ 0L,0L,1L,4L,8L,11L,13L,16L,21L,32L,29L,40L,47L,48L,55L,60L,69L,71L,79L,85L,88L,96L,101L,109L,120L,125L,124L,129L,132L,139L,163L,169L,180L,183L,192L,191L,199L,208L,215L,225L,236L,239L,253L,253L,260L,257L,280L,303L,309L,312L,311L,320L,323L,341L,348L,357L,361L,364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175511Inst : IEnumerable<long>
{
public static readonly long[] Value=A175511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175511.Bytes);
public long this[int i]=>Value[i];

public static A175511Inst Instance=new A175511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175512
{
public static readonly long[] Value={ 0L,1L,1L,3L,2L,4L,4L,7L,1L,3L,5L,1L,0L,2L,4L,4L,7L,1L,3L,16L,19L,9L,16L,1L,22L,8L,10L,21L,5L,28L,22L,7L,28L,6L,17L,28L,4L,16L,19L,22L,25L,10L,40L,43L,28L,3L,34L,40L,31L,34L,13L,40L,8L,1L,49L,43L,10L,9L,34L,19L,22L,8L,19L,40L,52L,64L,0L,66L,37L,49L,52L,55L,58L,70L,37L,49L,11L,64L,6L,25L,28L,67L,43L,55L,40L,20L,64L,13L,8L,28L,49L,34L,82L,0L,79L,82L,85L,61L,73L,67L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175512Inst : IEnumerable<long>
{
public static readonly long[] Value=A175512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175512.Bytes);
public long this[int i]=>Value[i];

public static A175512Inst Instance=new A175512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175513
{
public static readonly long[] Value={ 1L,2L,13L,753L,767L,1336L,1771L,1773L,1911L,2487L,3527L,4192L,5061L,5343L,5973L,6341L,7062L,7777L,8932L,9153L,15301L,17976L,18713L,19543L,20318L,22253L,24068L,27461L,29416L,29502L,31383L,31593L,31616L,31693L,36026L,36087L,41456L,42966L,44711L,45453L,45493L,46766L,49067L,50602L,51212L,51393L,53193L,56762L,58267L,60332L,60918L,64126L,65727L,67872L,71266L,72011L,75861L,78728L,79652L,82978L,85246L,86207L,86988L,87793L,90873L,91753L,94173L,97297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175513Inst : IEnumerable<long>
{
public static readonly long[] Value=A175513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175513.Bytes);
public long this[int i]=>Value[i];

public static A175513Inst Instance=new A175513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175514
{
public static readonly BigInteger[] Value={ 0L,1L,30L,31L,3900L,3901L,93900L,93901L,97000L,97001L,1270000000L,1270000001L,496864267596900L,496864267596901L,596044970707000L,596044970707001L,300522773449238130L,300522773449238131L,1549835974179703900L,1549835974179703901L,BigInteger.Parse("39043445740978906900"),BigInteger.Parse("39043445740978906901"),BigInteger.Parse("1156389717140148910000"),BigInteger.Parse("1156389717140148910001"),BigInteger.Parse("4850340461737111735130"),BigInteger.Parse("4850340461737111735131") };
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
public class A175514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175514Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175514.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175514.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175514Inst Instance=new A175514Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175515
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,9L,10L,14L,15L,21L,22L,25L,26L,33L,34L,35L,38L,39L,46L,49L,51L,55L,57L,58L,62L,65L,69L,74L,77L,82L,85L,86L,87L,91L,93L,94L,95L,106L,111L,115L,118L,119L,121L,122L,123L,129L,133L,134L,141L,142L,143L,145L,146L,155L,158L,159L,161L,166L,169L,177L,178L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175515Inst : IEnumerable<long>
{
public static readonly long[] Value=A175515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175515.Bytes);
public long this[int i]=>Value[i];

public static A175515Inst Instance=new A175515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175516
{
public static readonly long[] Value={ 2L,2L,6L,12L,60L,60L,252L,504L,504L,504L,7260L,7260L,10296L,11760L,11760L,11760L,56160L,56160L,198016L,198016L,1176480L,1323008L,2992500L,6240366L,13442580L,13442580L,37536408L,37536408L,90725804L,90725804L,319800096L,319800096L,319800096L,800640126L,2201169600L,2201169600L,4656965040L,5250966084L,5250966084L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175516Inst : IEnumerable<long>
{
public static readonly long[] Value=A175516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175516.Bytes);
public long this[int i]=>Value[i];

public static A175516Inst Instance=new A175516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175517
{
public static readonly long[] Value={ 1913L,18379L,19013L,25013L,34613L,35879L,36979L,37379L,37813L,40013L,40213L,45613L,48091L,49279L,51613L,55313L,56179L,56713L,58613L,63079L,63179L,64091L,65479L,66413L,74779L,75913L,76213L,76579L,76679L,85313L,88379L,90379L,90679L,93113L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175517Inst : IEnumerable<long>
{
public static readonly long[] Value=A175517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175517.Bytes);
public long this[int i]=>Value[i];

public static A175517Inst Instance=new A175517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175518
{
public static readonly long[] Value={ 1L,17L,101L,501L,1627L,2133L,2143L,2201L,2243L,3086L,3536L,3869L,4163L,4398L,4477L,5598L,5948L,5982L,6101L,6998L,7113L,7807L,8501L,8693L,9177L,9928L,10927L,11127L,11177L,11545L,11836L,12427L,12780L,13043L,13998L,14227L,14448L,14517L,14822L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175518Inst : IEnumerable<long>
{
public static readonly long[] Value=A175518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175518.Bytes);
public long this[int i]=>Value[i];

public static A175518Inst Instance=new A175518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175519
{
public static readonly long[] Value={ 13L,157L,4513L,19813L,78241L,98347L,111847L,128047L,130657L,161563L,163363L,168457L,205267L,384817L,599341L,602401L,743179L,765031L,833197L,833467L,964021L,996763L,1023133L,1028047L,1200307L,1235263L,1258267L,1478857L,1523551L,1549957L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175519Inst : IEnumerable<long>
{
public static readonly long[] Value=A175519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175519.Bytes);
public long this[int i]=>Value[i];

public static A175519Inst Instance=new A175519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175520
{
public static readonly long[] Value={ 3L,3L,6L,6L,4L,1L,10L,10L,10L,10L,15L,15L,20L,20L,15L,15L,20L,15L,6L,15L,15L,6L,21L,35L,35L,35L,35L,35L,35L,21L,21L,21L,21L,7L,35L,7L,21L,21L,7L,21L,21L,7L,28L,56L,56L,70L,70L,56L,56L,56L,56L,56L,28L,56L,70L,70L,70L,70L,28L,56L,28L,56L,70L,70L,56L,56L,56L,70L,56L,56L,28L,56L,56L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175520Inst : IEnumerable<long>
{
public static readonly long[] Value=A175520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175520.Bytes);
public long this[int i]=>Value[i];

public static A175520Inst Instance=new A175520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175521
{
public static readonly long[] Value={ 1L,1105L,1387L,1729L,2047L,2701L,2821L,3277L,4033L,4369L,4681L,5461L,6601L,7957L,8911L,10261L,10585L,11305L,13741L,13747L,13981L,14491L,15709L,15841L,16705L,18721L,19951L,23377L,29341L,30121L,30889L,31417L,31609L,31621L,34945L,39865L,41041L,41665L,42799L,46657L,49141L,49981L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175521Inst : IEnumerable<long>
{
public static readonly long[] Value=A175521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175521.Bytes);
public long this[int i]=>Value[i];

public static A175521Inst Instance=new A175521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175522
{
public static readonly long[] Value={ 2L,25L,95L,111L,119L,123L,125L,169L,187L,219L,221L,247L,289L,335L,365L,411L,415L,445L,485L,493L,505L,629L,655L,685L,695L,697L,731L,767L,815L,841L,871L,943L,949L,965L,985L,1003L,1139L,1207L,1241L,1261L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175522Inst : IEnumerable<long>
{
public static readonly long[] Value=A175522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175522.Bytes);
public long this[int i]=>Value[i];

public static A175522Inst Instance=new A175522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175523
{
public static readonly long[] Value={ 1L,12L,25L,54L,113L,226L,453L,910L,1821L,3644L,7303L,14610L,29231L,58462L,116939L,233892L,467803L,935616L,1871237L,3742486L,7484979L,14969998L,29939999L,59880012L,119760031L,239520072L,479040191L,958080388L,1916160779L,3832321566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175523Inst : IEnumerable<long>
{
public static readonly long[] Value=A175523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175523.Bytes);
public long this[int i]=>Value[i];

public static A175523Inst Instance=new A175523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175524
{
public static readonly long[] Value={ 1L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,121L,127L,131L,137L,139L,149L,151L,157L,163L,167L,173L,179L,181L,191L,193L,197L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175524Inst : IEnumerable<long>
{
public static readonly long[] Value=A175524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175524.Bytes);
public long this[int i]=>Value[i];

public static A175524Inst Instance=new A175524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175525
{
public static readonly long[] Value={ 1L,2L,5L,140L,158L,428L,788L,887L,914L,1814L,1895L,1976L,2579L,2732L,3074L,3299L,3641L,4658L,4874L,5378L,5423L,5504L,6170L,6440L,6944L,8060L,8249L,8915L,9041L,9158L,9725L,9824L,10661L,11291L,13820L,15305L,17051L,17393L,18716L,19589L,20876L,21641L,23756L,24188L,25961L,28409L,30632L,31307L,32387L,33215L,34970L,35240L,36653L,36977L,41558L,43970L,44951L,47444L,51764L,52655L,53375L,53852L,54104L,56831L,57506L,59153L,66479L,68063L,73562L,78485L,79286L,87908L,92093L,102029L,106934L,114854L,116321L,134051L,139397L,184037L,192353L,256469L,281381L,301118L,469004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175525Inst : IEnumerable<long>
{
public static readonly long[] Value=A175525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175525.Bytes);
public long this[int i]=>Value[i];

public static A175525Inst Instance=new A175525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175526
{
public static readonly long[] Value={ 4L,6L,8L,9L,10L,12L,14L,15L,16L,18L,20L,21L,22L,24L,26L,27L,28L,30L,32L,33L,34L,35L,36L,38L,39L,40L,42L,44L,45L,46L,48L,49L,50L,51L,52L,54L,55L,56L,57L,58L,60L,62L,63L,64L,65L,66L,68L,69L,70L,72L,74L,75L,76L,77L,78L,80L,81L,82L,84L,85L,86L,87L,88L,90L,91L,92L,93L,94L,96L,98L,99L,100L,102L,104L,105L,106L,108L,110L,112L,114L,115L,116L,117L,118L,120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175526Inst : IEnumerable<long>
{
public static readonly long[] Value=A175526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175526.Bytes);
public long this[int i]=>Value[i];

public static A175526Inst Instance=new A175526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175527
{
public static readonly long[] Value={ 1L,4L,16L,19L,22L,25L,37L,40L,34L,46L,67L,52L,55L,58L,97L,73L,85L,88L,91L,85L,115L,91L,121L,106L,109L,121L,133L,118L,121L,133L,163L,184L,169L,181L,193L,169L,172L,175L,178L,199L,193L,214L,226L,238L,169L,190L,247L,241L,208L,247L,232L,253L,292L,241L,316L,292L,268L,271L,301L,286L,298L,337L,304L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175527Inst : IEnumerable<long>
{
public static readonly long[] Value=A175527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175527.Bytes);
public long this[int i]=>Value[i];

public static A175527Inst Instance=new A175527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175528
{
public static readonly long[] Value={ 0L,0L,1L,2L,0L,1L,5L,2L,1L,7L,8L,7L,6L,13L,13L,5L,3L,1L,9L,15L,7L,11L,14L,13L,21L,3L,10L,9L,17L,13L,29L,9L,16L,23L,29L,28L,27L,26L,4L,33L,9L,16L,23L,37L,10L,17L,6L,16L,2L,32L,49L,32L,29L,46L,17L,44L,43L,11L,50L,58L,32L,56L,10L,45L,33L,61L,60L,18L,67L,66L,47L,1L,17L,15L,22L,69L,18L,61L,5L,11L,73L,63L,42L,40L,29L,18L,7L,57L,12L,46L,53L,53L,49L,11L,18L,40L,84L,39L,37L,35L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175528Inst : IEnumerable<long>
{
public static readonly long[] Value=A175528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175528.Bytes);
public long this[int i]=>Value[i];

public static A175528Inst Instance=new A175528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175529
{
public static readonly long[] Value={ 1L,2L,27L,252L,508L,1037L,2126L,4335L,8691L,17527L,35216L,70560L,141316L,282692L,565716L,1132725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175529Inst : IEnumerable<long>
{
public static readonly long[] Value=A175529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175529.Bytes);
public long this[int i]=>Value[i];

public static A175529Inst Instance=new A175529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175530
{
public static readonly long[] Value={ 7056721L,79397009999L,443372888629441L,582920080863121L,2491924062668039L,14522256850701599L,39671149333495681L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175530Inst : IEnumerable<long>
{
public static readonly long[] Value=A175530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175530.Bytes);
public long this[int i]=>Value[i];

public static A175530Inst Instance=new A175530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175531
{
public static readonly long[] Value={ 443372888629441L,39671149333495681L,842526563598720001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175531Inst : IEnumerable<long>
{
public static readonly long[] Value=A175531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175531.Bytes);
public long this[int i]=>Value[i];

public static A175531Inst Instance=new A175531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175532
{
public static readonly long[] Value={ 1L,9L,13L,25L,133L,193L,18673L,57313L,1032313L,4387273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175532Inst : IEnumerable<long>
{
public static readonly long[] Value=A175532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175532.Bytes);
public long this[int i]=>Value[i];

public static A175532Inst Instance=new A175532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175533
{
public static readonly long[] Value={ 3L,7L,19L,55L,139L,859L,2119L,112999L,333679L,10040119L,15363619L,548687179L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175533Inst : IEnumerable<long>
{
public static readonly long[] Value=A175533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175533.Bytes);
public long this[int i]=>Value[i];

public static A175533Inst Instance=new A175533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175534
{
public static readonly long[] Value={ 3362L,3473L,4194L,4743L,5024L,5378L,5378L,5522L,5634L,6048L,6722L,6722L,6952L,7394L,7697L,8073L,8114L,8258L,8456L,8498L,8514L,8786L,9097L,9800L,10088L,10430L,10592L,10688L,10728L,11138L,11456L,11585L,11666L,11744L,11880L,12040L,12082L,12152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175534Inst : IEnumerable<long>
{
public static readonly long[] Value=A175534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175534.Bytes);
public long this[int i]=>Value[i];

public static A175534Inst Instance=new A175534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175535
{
public static readonly long[] Value={ 110952L,12952L,10152L,8073L,129128L,78808L,34088L,13001L,142472L,100577L,61832L,14344L,154880L,36089L,5120L,1936L,161154L,52290L,41346L,5310L,163982L,149618L,106418L,2482L,166880L,63520L,33824L,6176L,167778L,130338L,70366L,3618L,172706L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175535Inst : IEnumerable<long>
{
public static readonly long[] Value=A175535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175535.Bytes);
public long this[int i]=>Value[i];

public static A175535Inst Instance=new A175535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175536
{
public static readonly long[] Value={ 482L,1288L,1282L,2482L,2720L,2018L,1346L,4082L,3775L,1696L,2114L,674L,2457L,4487L,2912L,1728L,3767L,4738L,4088L,3383L,3586L,4439L,5544L,5576L,3368L,3970L,2177L,3473L,3672L,3746L,1313L,6104L,3218L,6752L,8856L,7841L,8082L,4232L,5714L,10424L,3776L,2849L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175536Inst : IEnumerable<long>
{
public static readonly long[] Value=A175536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175536.Bytes);
public long this[int i]=>Value[i];

public static A175536Inst Instance=new A175536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175537
{
public static readonly long[] Value={ 359L,1016L,567L,882L,1376L,1346L,863L,3314L,2466L,1008L,1022L,167L,1512L,1442L,1712L,576L,3122L,1346L,953L,1106L,1890L,2450L,3672L,1649L,728L,2114L,1072L,2768L,2728L,743L,1088L,1640L,2258L,1712L,5544L,5384L,5607L,2009L,1682L,8072L,1553L,1120L,1436L,3346L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175537Inst : IEnumerable<long>
{
public static readonly long[] Value=A175537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175537.Bytes);
public long this[int i]=>Value[i];

public static A175537Inst Instance=new A175537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175538
{
public static readonly long[] Value={ 2L,8L,162L,18L,305L,98L,98L,407L,450L,513L,2L,2L,792L,2L,224L,208L,722L,23L,8L,338L,135L,50L,1512L,200L,113L,386L,224L,1856L,297L,98L,208L,296L,878L,137L,1345L,2360L,18L,392L,527L,392L,848L,176L,8L,135L,584L,704L,401L,1058L,32L,288L,722L,855L,1817L,143L,848L,1640L,98L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175538Inst : IEnumerable<long>
{
public static readonly long[] Value=A175538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175538.Bytes);
public long this[int i]=>Value[i];

public static A175538Inst Instance=new A175538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175539
{
public static readonly long[] Value={ 1L,2L,3L,5L,8L,12L,17L,25L,36L,51L,73L,104L,148L,210L,297L,421L,596L,843L,1193L,1688L,2388L,3378L,4778L,6758L,9558L,13518L,19118L,27037L,38237L,54076L,76476L,108154L,152953L,216309L,305908L,432620L,611818L,865242L,1223637L,1730485L,2447276L,3460971L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175539Inst : IEnumerable<long>
{
public static readonly long[] Value=A175539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175539.Bytes);
public long this[int i]=>Value[i];

public static A175539Inst Instance=new A175539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175540
{
public static readonly long[] Value={ 1L,3L,5L,8L,10L,13L,15L,18L,22L,24L,28L,31L,33L,36L,40L,44L,46L,50L,53L,55L,59L,62L,66L,71L,74L,76L,79L,81L,84L,92L,95L,99L,101L,107L,109L,113L,117L,120L,124L,128L,130L,136L,138L,141L,143L,150L,157L,160L,162L,165L,169L,171L,177L,181L,185L,189L,191L,195L,198L,200L,206L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175540Inst : IEnumerable<long>
{
public static readonly long[] Value=A175540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175540.Bytes);
public long this[int i]=>Value[i];

public static A175540Inst Instance=new A175540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175541
{
public static readonly BigInteger[] Value={ 10L,101L,1011L,10111L,101111L,10111111L,101111111L,1011111111111L,10111111111111111111UL,BigInteger.Parse("101111111111111111111111111111111111"),BigInteger.Parse("1011111111111111111111111111111111111111") };
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
public class A175541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175541Inst Instance=new A175541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175542
{
public static readonly long[] Value={ 1L,2L,1L,4L,2L,6L,1L,8L,4L,10L,5L,12L,6L,14L,1L,16L,8L,18L,9L,20L,10L,22L,3L,24L,12L,26L,13L,28L,14L,30L,1L,32L,16L,34L,17L,36L,18L,38L,19L,40L,20L,42L,21L,44L,22L,46L,23L,48L,24L,50L,25L,52L,26L,54L,27L,56L,28L,58L,29L,60L,30L,62L,1L,64L,32L,66L,33L,68L,34L,70L,35L,72L,36L,74L,37L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175542Inst : IEnumerable<long>
{
public static readonly long[] Value=A175542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175542.Bytes);
public long this[int i]=>Value[i];

public static A175542Inst Instance=new A175542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175543
{
public static readonly long[] Value={ 0L,5L,9L,17L,27L,33L,51L,65L,85L,99L,119L,129L,165L,195L,231L,257L,297L,325L,365L,387L,427L,455L,495L,513L,585L,645L,717L,771L,843L,903L,975L,1025L,1105L,1161L,1241L,1285L,1365L,1421L,1501L,1539L,1619L,1675L,1755L,1799L,1879L,1935L,2015L,2049L,2193L,2313L,2457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175543Inst : IEnumerable<long>
{
public static readonly long[] Value=A175543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175543.Bytes);
public long this[int i]=>Value[i];

public static A175543Inst Instance=new A175543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175544
{
public static readonly long[] Value={ 1L,3L,7L,15L,21L,31L,45L,63L,73L,93L,107L,127L,153L,189L,219L,255L,273L,313L,341L,381L,403L,443L,471L,511L,561L,633L,693L,765L,819L,891L,951L,1023L,1057L,1137L,1193L,1273L,1317L,1397L,1453L,1533L,1571L,1651L,1707L,1787L,1831L,1911L,1967L,2047L,2145L,2289L,2409L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175544Inst : IEnumerable<long>
{
public static readonly long[] Value=A175544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175544.Bytes);
public long this[int i]=>Value[i];

public static A175544Inst Instance=new A175544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175545
{
public static readonly long[] Value={ 3L,27L,33L,333L,369L,909L,2151L,2439L,2997L,3333L,27027L,33333L,37683L,41841L,76923L,90909L,142857L,194841L,243603L,333333L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175545Inst : IEnumerable<long>
{
public static readonly long[] Value=A175545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175545.Bytes);
public long this[int i]=>Value[i];

public static A175545Inst Instance=new A175545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175546
{
public static readonly long[] Value={ 19L,37L,59L,109L,127L,149L,239L,307L,419L,691L,1009L,1049L,1229L,1319L,2129L,2309L,2477L,3119L,4019L,5009L,6091L,8093L,8297L,9199L,10139L,10799L,11093L,12007L,12391L,13499L,14009L,14489L,15091L,15497L,18397L,20297L,20899L,21799L,22109L,23599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175546Inst : IEnumerable<long>
{
public static readonly long[] Value=A175546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175546.Bytes);
public long this[int i]=>Value[i];

public static A175546Inst Instance=new A175546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175547
{
public static readonly long[] Value={ 123456789L,214365897L,341278956L,432189675L,567891234L,658917342L,789523461L,896742513L,975634128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175547Inst : IEnumerable<long>
{
public static readonly long[] Value=A175547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175547.Bytes);
public long this[int i]=>Value[i];

public static A175547Inst Instance=new A175547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175548
{
public static readonly long[] Value={ 1L,2L,1L,3L,2L,2L,1L,4L,3L,2L,2L,3L,3L,2L,2L,5L,2L,4L,2L,3L,1L,2L,2L,4L,5L,3L,2L,3L,4L,2L,1L,6L,2L,4L,2L,5L,3L,4L,3L,4L,3L,2L,3L,3L,4L,2L,2L,5L,4L,5L,2L,3L,4L,4L,2L,4L,2L,4L,4L,3L,5L,2L,3L,7L,3L,2L,2L,6L,2L,2L,2L,4L,3L,4L,5L,3L,2L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175548Inst : IEnumerable<long>
{
public static readonly long[] Value=A175548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175548.Bytes);
public long this[int i]=>Value[i];

public static A175548Inst Instance=new A175548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175549
{
public static readonly long[] Value={ 0L,26L,98L,290L,578L,1154L,1730L,2882L,4034L,5762L,7490L,10370L,12674L,16706L,20162L,24770L,29378L,36290L,41474L,50114L,57026L,66242L,74882L,87554L,96770L,111170L,123266L,138818L,152642L,172802L,186626L,209666L,228098L,251138L,271874L,299522L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175549Inst : IEnumerable<long>
{
public static readonly long[] Value=A175549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175549.Bytes);
public long this[int i]=>Value[i];

public static A175549Inst Instance=new A175549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175550
{
public static readonly long[] Value={ 1L,6L,6L,44L,232L,84L,138L,133L,336L,396L,28656L,3016L,84L,514228L,335824L,152214L,67830L,4440L,261744L,504628L,108373609L,47124L,3295440L,2971215072L,49349664L,45240L,4438362040L,203028L,3599596L,10841042784L,104340657248L,252736776688L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175550Inst : IEnumerable<long>
{
public static readonly long[] Value=A175550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175550.Bytes);
public long this[int i]=>Value[i];

public static A175550Inst Instance=new A175550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175551
{
public static readonly BigInteger[] Value={ 3L,76923L,47619L,BigInteger.Parse("1123595505617977528089887640449438202247191") };
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
public class A175551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175551Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175551.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175551.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175551Inst Instance=new A175551Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175552
{
public static readonly long[] Value={ 1L,2L,5L,7L,22L,490L,724L,778L,868L,994L,1109L,1390L,1415L,1462L,1642L,1739L,1829L,2146L,2362L,3136L,4954L,6437L,6628L,7103L,11200L,12424L,12863L,14242L,14249L,15059L,15203L,16222L,17140L,18353L,19192L,21233L,22853L,24106L,24574L,24833L,26896L,27652L,28253L,30323L,31306L,31594L,32386L,33790L,34985L,36184L,36310L,40673L,42196L,43931L,45911L,45983L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175552Inst : IEnumerable<long>
{
public static readonly long[] Value=A175552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175552.Bytes);
public long this[int i]=>Value[i];

public static A175552Inst Instance=new A175552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175553
{
public static readonly long[] Value={ 1L,4L,7L,8L,10L,12L,13L,14L,16L,18L,19L,20L,22L,23L,24L,25L,26L,28L,30L,31L,32L,33L,34L,36L,37L,38L,40L,42L,43L,44L,46L,47L,48L,49L,50L,52L,53L,54L,55L,56L,58L,60L,61L,62L,63L,64L,66L,67L,68L,70L,72L,73L,74L,75L,76L,78L,79L,80L,82L,83L,84L,85L,86L,88L,89L,90L,91L,92L,93L,94L,96L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175553Inst : IEnumerable<long>
{
public static readonly long[] Value=A175553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175553.Bytes);
public long this[int i]=>Value[i];

public static A175553Inst Instance=new A175553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175554
{
public static readonly long[] Value={ 1L,6L,960L,40037760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175554Inst : IEnumerable<long>
{
public static readonly long[] Value=A175554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175554.Bytes);
public long this[int i]=>Value[i];

public static A175554Inst Instance=new A175554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175555
{
public static readonly long[] Value={ 5L,25L,2L,1L,125L,1L,8L,0L,0L,625L,0L,5L,0L,41L,4L,0L,3L,0L,3125L,0L,0L,2L,0L,25L,0L,2L,0L,0L,208L,2L,1L,0L,0L,17L,0L,1L,0L,15625L,0L,0L,1L,0L,13L,0L,1L,1L,0L,125L,0L,1L,0L,0L,11L,0L,1L,0L,0L,1041L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175555Inst : IEnumerable<long>
{
public static readonly long[] Value=A175555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175555.Bytes);
public long this[int i]=>Value[i];

public static A175555Inst Instance=new A175555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175556
{
public static readonly long[] Value={ 8L,9L,98L,108L,125L,196L,225L,576L,676L,864L,900L,1000L,1352L,1568L,1568L,1764L,2000L,2601L,3087L,3993L,4232L,4418L,4913L,5324L,5400L,6348L,7225L,7776L,8100L,8100L,8192L,9216L,12348L,12482L,15123L,15376L,15552L,16464L,16928L,17576L,18225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175556Inst : IEnumerable<long>
{
public static readonly long[] Value=A175556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175556.Bytes);
public long this[int i]=>Value[i];

public static A175556Inst Instance=new A175556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175557
{
public static readonly long[] Value={ 5L,2L,5L,41L,3L,2L,2L,2L,17L,13L,11L,89L,7L,5L,5L,5L,41L,3L,3L,347L,3L,3L,3L,29L,2L,2L,2L,2L,26041L,2L,2L,2L,23L,2L,2L,2L,2L,2L,17L,13L,13L,1201L,11L,11L,107L,919L,89L,7L,7L,7L,7L,7L,7L,61L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,5L,41L,4111L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175557Inst : IEnumerable<long>
{
public static readonly long[] Value=A175557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175557.Bytes);
public long this[int i]=>Value[i];

public static A175557Inst Instance=new A175557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175558
{
public static readonly BigInteger[] Value={ 1L,167L,27889L,4657463L,777796321L,129891985607L,21691961596369L,3622557586593623L,604967116961135041L,BigInteger.Parse("101029508532509551847"),BigInteger.Parse("16871927924929095158449"),BigInteger.Parse("2817611963463158891460983"),BigInteger.Parse("470541197898347534873984161"),BigInteger.Parse("78580380049024038323955354887"),BigInteger.Parse("13122923468187014400100544266129"),BigInteger.Parse("2191528219187231404816790892443543"),BigInteger.Parse("365985212604267644604404079038071681"),BigInteger.Parse("61119530504912696648935481199357970727") };
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
public class A175558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175558Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175558.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175558.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175558Inst Instance=new A175558Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175559
{
public static readonly long[] Value={ 1L,14L,34L,35L,49L,65L,73L,77L,70L,80L,121L,119L,136L,131L,106L,143L,148L,182L,136L,176L,169L,251L,220L,209L,244L,257L,268L,233L,265L,335L,298L,329L,349L,332L,373L,389L,343L,374L,331L,350L,355L,371L,433L,428L,430L,476L,463L,488L,451L,473L,529L,530L,463L,569L,514L,545L,583L,593L,562L,596L,586L,635L,601L,647L,598L,695L,649L,662L,718L,647L,742L,713L,685L,725L,709L,755L,742L,884L,775L,851L,790L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175559Inst : IEnumerable<long>
{
public static readonly long[] Value=A175559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175559.Bytes);
public long this[int i]=>Value[i];

public static A175559Inst Instance=new A175559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175560
{
public static readonly long[] Value={ 0L,0L,2L,1L,0L,1L,0L,6L,8L,1L,9L,4L,1L,8L,8L,4L,12L,10L,5L,9L,20L,0L,2L,4L,7L,8L,17L,13L,16L,28L,19L,29L,2L,33L,4L,19L,4L,27L,38L,35L,2L,13L,41L,34L,26L,3L,18L,19L,32L,29L,20L,47L,39L,28L,50L,23L,23L,40L,6L,46L,25L,43L,17L,22L,45L,55L,59L,38L,26L,42L,3L,37L,68L,43L,5L,58L,37L,73L,61L,70L,44L,67L,65L,73L,77L,61L,38L,24L,39L,1L,13L,61L,89L,18L,69L,88L,68L,97L,26L,86L,18L,52L,37L,38L,29L,103L,48L,28L,22L,106L,11L,27L,42L,40L,77L,26L,107L,57L,56L,118L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175560Inst : IEnumerable<long>
{
public static readonly long[] Value=A175560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175560.Bytes);
public long this[int i]=>Value[i];

public static A175560Inst Instance=new A175560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175561
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,6L,16L,2L,44L,1L,232L,84L,60L,138L,133L,144L,336L,10L,420L,396L,1580L,66L,1500L,733L,908L,84L,803L,60L,1546L,1060L,675L,1511L,1228L,1172L,325L,363L,566L,30L,1935L,420L,1237L,1402L,834L,118L,76L,1547L,1148L,1500L,985L,956L,509L,489L,614L,907L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175561Inst : IEnumerable<long>
{
public static readonly long[] Value=A175561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175561.Bytes);
public long this[int i]=>Value[i];

public static A175561Inst Instance=new A175561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175562
{
public static readonly BigInteger[] Value={ 0L,0L,0L,3L,0L,0L,769230L,476190L,2941176470588235L,18L,BigInteger.Parse("11235955056179775280898876404494382022471910"),4L };
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
public class A175562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175562Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A175562.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A175562.Bytes);
public BigInteger this[int i]=>Value[i];

public static A175562Inst Instance=new A175562Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A175563
{
public static readonly long[] Value={ 1L,2L,15L,334L,18521L,2293896L,586774783L,292184148320L,270280183791969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A175563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A175563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A175563Inst : IEnumerable<long>
{
public static readonly long[] Value=A175563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A175563.Bytes);
public long this[int i]=>Value[i];

public static A175563Inst Instance=new A175563Inst();

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