using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A040332
{
public static readonly long[] Value={ 18L,1L,2L,1L,3L,2L,2L,2L,3L,1L,2L,1L,36L,1L,2L,1L,3L,2L,2L,2L,3L,1L,2L,1L,36L,1L,2L,1L,3L,2L,2L,2L,3L,1L,2L,1L,36L,1L,2L,1L,3L,2L,2L,2L,3L,1L,2L,1L,36L,1L,2L,1L,3L,2L,2L,2L,3L,1L,2L,1L,36L,1L,2L,1L,3L,2L,2L,2L,3L,1L,2L,1L,36L,1L,2L,1L,3L,2L,2L,2L,3L,1L,2L,1L,36L,1L,2L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040332Inst : IEnumerable<long>
{
public static readonly long[] Value=A040332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040332.Bytes);
public long this[int i]=>Value[i];

public static A040332Inst Instance=new A040332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040461
{
public static readonly long[] Value={ 21L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L,1L,42L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040461Inst : IEnumerable<long>
{
public static readonly long[] Value=A040461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040461.Bytes);
public long this[int i]=>Value[i];

public static A040461Inst Instance=new A040461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040462
{
public static readonly long[] Value={ 22L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040462Inst : IEnumerable<long>
{
public static readonly long[] Value=A040462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040462.Bytes);
public long this[int i]=>Value[i];

public static A040462Inst Instance=new A040462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040463
{
public static readonly long[] Value={ 22L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L,22L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040463Inst : IEnumerable<long>
{
public static readonly long[] Value=A040463.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040463.Bytes);
public long this[int i]=>Value[i];

public static A040463Inst Instance=new A040463Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040464
{
public static readonly long[] Value={ 22L,14L,1L,2L,4L,1L,1L,3L,2L,5L,1L,6L,1L,1L,21L,1L,1L,6L,1L,5L,2L,3L,1L,1L,4L,2L,1L,14L,44L,14L,1L,2L,4L,1L,1L,3L,2L,5L,1L,6L,1L,1L,21L,1L,1L,6L,1L,5L,2L,3L,1L,1L,4L,2L,1L,14L,44L,14L,1L,2L,4L,1L,1L,3L,2L,5L,1L,6L,1L,1L,21L,1L,1L,6L,1L,5L,2L,3L,1L,1L,4L,2L,1L,14L,44L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040464Inst : IEnumerable<long>
{
public static readonly long[] Value=A040464.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040464.Bytes);
public long this[int i]=>Value[i];

public static A040464Inst Instance=new A040464Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040465
{
public static readonly long[] Value={ 22L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L,11L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040465Inst : IEnumerable<long>
{
public static readonly long[] Value=A040465.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040465.Bytes);
public long this[int i]=>Value[i];

public static A040465Inst Instance=new A040465Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040466
{
public static readonly long[] Value={ 22L,8L,1L,4L,1L,1L,1L,3L,2L,1L,2L,14L,2L,1L,2L,3L,1L,1L,1L,4L,1L,8L,44L,8L,1L,4L,1L,1L,1L,3L,2L,1L,2L,14L,2L,1L,2L,3L,1L,1L,1L,4L,1L,8L,44L,8L,1L,4L,1L,1L,1L,3L,2L,1L,2L,14L,2L,1L,2L,3L,1L,1L,1L,4L,1L,8L,44L,8L,1L,4L,1L,1L,1L,3L,2L,1L,2L,14L,2L,1L,2L,3L,1L,1L,1L,4L,1L,8L,44L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040466Inst : IEnumerable<long>
{
public static readonly long[] Value=A040466.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040466.Bytes);
public long this[int i]=>Value[i];

public static A040466Inst Instance=new A040466Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040467
{
public static readonly long[] Value={ 22L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L,44L,7L,2L,1L,4L,4L,4L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040467Inst : IEnumerable<long>
{
public static readonly long[] Value=A040467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040467.Bytes);
public long this[int i]=>Value[i];

public static A040467Inst Instance=new A040467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040468
{
public static readonly long[] Value={ 22L,6L,3L,4L,8L,1L,1L,1L,2L,1L,1L,21L,1L,1L,2L,1L,1L,1L,8L,4L,3L,6L,44L,6L,3L,4L,8L,1L,1L,1L,2L,1L,1L,21L,1L,1L,2L,1L,1L,1L,8L,4L,3L,6L,44L,6L,3L,4L,8L,1L,1L,1L,2L,1L,1L,21L,1L,1L,2L,1L,1L,1L,8L,4L,3L,6L,44L,6L,3L,4L,8L,1L,1L,1L,2L,1L,1L,21L,1L,1L,2L,1L,1L,1L,8L,4L,3L,6L,44L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040468Inst : IEnumerable<long>
{
public static readonly long[] Value=A040468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040468.Bytes);
public long this[int i]=>Value[i];

public static A040468Inst Instance=new A040468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040469
{
public static readonly long[] Value={ 22L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L,10L,1L,1L,5L,44L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040469Inst : IEnumerable<long>
{
public static readonly long[] Value=A040469.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040469.Bytes);
public long this[int i]=>Value[i];

public static A040469Inst Instance=new A040469Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040470
{
public static readonly long[] Value={ 22L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L,44L,4L,1L,10L,3L,3L,10L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040470Inst : IEnumerable<long>
{
public static readonly long[] Value=A040470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040470.Bytes);
public long this[int i]=>Value[i];

public static A040470Inst Instance=new A040470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040471
{
public static readonly long[] Value={ 22L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L,44L,4L,2L,2L,1L,2L,1L,2L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040471Inst : IEnumerable<long>
{
public static readonly long[] Value=A040471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040471.Bytes);
public long this[int i]=>Value[i];

public static A040471Inst Instance=new A040471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040472
{
public static readonly long[] Value={ 22L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L,4L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040472Inst : IEnumerable<long>
{
public static readonly long[] Value=A040472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040472.Bytes);
public long this[int i]=>Value[i];

public static A040472Inst Instance=new A040472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040473
{
public static readonly long[] Value={ 22L,3L,1L,2L,4L,1L,1L,2L,2L,2L,1L,1L,4L,2L,1L,3L,44L,3L,1L,2L,4L,1L,1L,2L,2L,2L,1L,1L,4L,2L,1L,3L,44L,3L,1L,2L,4L,1L,1L,2L,2L,2L,1L,1L,4L,2L,1L,3L,44L,3L,1L,2L,4L,1L,1L,2L,2L,2L,1L,1L,4L,2L,1L,3L,44L,3L,1L,2L,4L,1L,1L,2L,2L,2L,1L,1L,4L,2L,1L,3L,44L,3L,1L,2L,4L,1L,1L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040473Inst : IEnumerable<long>
{
public static readonly long[] Value=A040473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040473.Bytes);
public long this[int i]=>Value[i];

public static A040473Inst Instance=new A040473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040474
{
public static readonly long[] Value={ 22L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L,44L,3L,2L,2L,5L,6L,5L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040474Inst : IEnumerable<long>
{
public static readonly long[] Value=A040474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040474.Bytes);
public long this[int i]=>Value[i];

public static A040474Inst Instance=new A040474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040475
{
public static readonly long[] Value={ 22L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L,22L,6L,3L,44L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040475Inst : IEnumerable<long>
{
public static readonly long[] Value=A040475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040475.Bytes);
public long this[int i]=>Value[i];

public static A040475Inst Instance=new A040475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040476
{
public static readonly long[] Value={ 22L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L,21L,1L,2L,44L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040476Inst : IEnumerable<long>
{
public static readonly long[] Value=A040476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040476.Bytes);
public long this[int i]=>Value[i];

public static A040476Inst Instance=new A040476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040525
{
public static readonly long[] Value={ 23L,2L,3L,9L,11L,1L,1L,1L,1L,4L,1L,1L,1L,1L,11L,9L,3L,2L,46L,2L,3L,9L,11L,1L,1L,1L,1L,4L,1L,1L,1L,1L,11L,9L,3L,2L,46L,2L,3L,9L,11L,1L,1L,1L,1L,4L,1L,1L,1L,1L,11L,9L,3L,2L,46L,2L,3L,9L,11L,1L,1L,1L,1L,4L,1L,1L,1L,1L,11L,9L,3L,2L,46L,2L,3L,9L,11L,1L,1L,1L,1L,4L,1L,1L,1L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040525Inst : IEnumerable<long>
{
public static readonly long[] Value=A040525.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040525.Bytes);
public long this[int i]=>Value[i];

public static A040525Inst Instance=new A040525Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040526
{
public static readonly long[] Value={ 23L,2L,4L,1L,2L,1L,1L,7L,4L,7L,1L,1L,2L,1L,4L,2L,46L,2L,4L,1L,2L,1L,1L,7L,4L,7L,1L,1L,2L,1L,4L,2L,46L,2L,4L,1L,2L,1L,1L,7L,4L,7L,1L,1L,2L,1L,4L,2L,46L,2L,4L,1L,2L,1L,1L,7L,4L,7L,1L,1L,2L,1L,4L,2L,46L,2L,4L,1L,2L,1L,1L,7L,4L,7L,1L,1L,2L,1L,4L,2L,46L,2L,4L,1L,2L,1L,1L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040526Inst : IEnumerable<long>
{
public static readonly long[] Value=A040526.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040526.Bytes);
public long this[int i]=>Value[i];

public static A040526Inst Instance=new A040526Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040527
{
public static readonly long[] Value={ 23L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L,1L,8L,2L,46L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040527Inst : IEnumerable<long>
{
public static readonly long[] Value=A040527.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040527.Bytes);
public long this[int i]=>Value[i];

public static A040527Inst Instance=new A040527Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040528
{
public static readonly long[] Value={ 23L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L,2L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040528Inst : IEnumerable<long>
{
public static readonly long[] Value=A040528.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040528.Bytes);
public long this[int i]=>Value[i];

public static A040528Inst Instance=new A040528Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040529
{
public static readonly long[] Value={ 23L,1L,1L,15L,5L,1L,4L,2L,1L,1L,3L,1L,2L,6L,2L,1L,3L,1L,1L,2L,4L,1L,5L,15L,1L,1L,46L,1L,1L,15L,5L,1L,4L,2L,1L,1L,3L,1L,2L,6L,2L,1L,3L,1L,1L,2L,4L,1L,5L,15L,1L,1L,46L,1L,1L,15L,5L,1L,4L,2L,1L,1L,3L,1L,2L,6L,2L,1L,3L,1L,1L,2L,4L,1L,5L,15L,1L,1L,46L,1L,1L,15L,5L,1L,4L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040529Inst : IEnumerable<long>
{
public static readonly long[] Value=A040529.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040529.Bytes);
public long this[int i]=>Value[i];

public static A040529Inst Instance=new A040529Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040530
{
public static readonly long[] Value={ 23L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L,1L,6L,4L,1L,1L,4L,6L,1L,1L,46L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040530Inst : IEnumerable<long>
{
public static readonly long[] Value=A040530.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040530.Bytes);
public long this[int i]=>Value[i];

public static A040530Inst Instance=new A040530Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040531
{
public static readonly long[] Value={ 23L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L,46L,1L,1L,3L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040531Inst : IEnumerable<long>
{
public static readonly long[] Value=A040531.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040531.Bytes);
public long this[int i]=>Value[i];

public static A040531Inst Instance=new A040531Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040532
{
public static readonly long[] Value={ 23L,1L,1L,2L,1L,1L,1L,3L,3L,2L,1L,5L,5L,15L,1L,1L,8L,1L,10L,1L,8L,1L,1L,15L,5L,5L,1L,2L,3L,3L,1L,1L,1L,2L,1L,1L,46L,1L,1L,2L,1L,1L,1L,3L,3L,2L,1L,5L,5L,15L,1L,1L,8L,1L,10L,1L,8L,1L,1L,15L,5L,5L,1L,2L,3L,3L,1L,1L,1L,2L,1L,1L,46L,1L,1L,2L,1L,1L,1L,3L,3L,2L,1L,5L,5L,15L,1L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040532Inst : IEnumerable<long>
{
public static readonly long[] Value=A040532.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040532.Bytes);
public long this[int i]=>Value[i];

public static A040532Inst Instance=new A040532Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040533
{
public static readonly long[] Value={ 23L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L,46L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040533Inst : IEnumerable<long>
{
public static readonly long[] Value=A040533.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040533.Bytes);
public long this[int i]=>Value[i];

public static A040533Inst Instance=new A040533Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040534
{
public static readonly long[] Value={ 23L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,46L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,46L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,46L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,46L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,46L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,46L,1L,1L,1L,1L,1L,4L,1L,1L,1L,1L,1L,46L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040534Inst : IEnumerable<long>
{
public static readonly long[] Value=A040534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040534.Bytes);
public long this[int i]=>Value[i];

public static A040534Inst Instance=new A040534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040535
{
public static readonly long[] Value={ 23L,1L,1L,1L,4L,15L,1L,1L,4L,1L,2L,1L,4L,1L,1L,15L,4L,1L,1L,1L,46L,1L,1L,1L,4L,15L,1L,1L,4L,1L,2L,1L,4L,1L,1L,15L,4L,1L,1L,1L,46L,1L,1L,1L,4L,15L,1L,1L,4L,1L,2L,1L,4L,1L,1L,15L,4L,1L,1L,1L,46L,1L,1L,1L,4L,15L,1L,1L,4L,1L,2L,1L,4L,1L,1L,15L,4L,1L,1L,1L,46L,1L,1L,1L,4L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040535Inst : IEnumerable<long>
{
public static readonly long[] Value=A040535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040535.Bytes);
public long this[int i]=>Value[i];

public static A040535Inst Instance=new A040535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040536
{
public static readonly long[] Value={ 23L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L,46L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040536Inst : IEnumerable<long>
{
public static readonly long[] Value=A040536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040536.Bytes);
public long this[int i]=>Value[i];

public static A040536Inst Instance=new A040536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040537
{
public static readonly long[] Value={ 23L,1L,2L,5L,1L,1L,2L,2L,2L,1L,1L,5L,2L,1L,46L,1L,2L,5L,1L,1L,2L,2L,2L,1L,1L,5L,2L,1L,46L,1L,2L,5L,1L,1L,2L,2L,2L,1L,1L,5L,2L,1L,46L,1L,2L,5L,1L,1L,2L,2L,2L,1L,1L,5L,2L,1L,46L,1L,2L,5L,1L,1L,2L,2L,2L,1L,1L,5L,2L,1L,46L,1L,2L,5L,1L,1L,2L,2L,2L,1L,1L,5L,2L,1L,46L,1L,2L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040537Inst : IEnumerable<long>
{
public static readonly long[] Value=A040537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040537.Bytes);
public long this[int i]=>Value[i];

public static A040537Inst Instance=new A040537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040538
{
public static readonly long[] Value={ 23L,1L,2L,2L,2L,4L,1L,5L,1L,22L,1L,5L,1L,4L,2L,2L,2L,1L,46L,1L,2L,2L,2L,4L,1L,5L,1L,22L,1L,5L,1L,4L,2L,2L,2L,1L,46L,1L,2L,2L,2L,4L,1L,5L,1L,22L,1L,5L,1L,4L,2L,2L,2L,1L,46L,1L,2L,2L,2L,4L,1L,5L,1L,22L,1L,5L,1L,4L,2L,2L,2L,1L,46L,1L,2L,2L,2L,4L,1L,5L,1L,22L,1L,5L,1L,4L,2L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040538Inst : IEnumerable<long>
{
public static readonly long[] Value=A040538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040538.Bytes);
public long this[int i]=>Value[i];

public static A040538Inst Instance=new A040538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040539
{
public static readonly long[] Value={ 23L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L,23L,2L,1L,2L,1L,46L,1L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040539Inst : IEnumerable<long>
{
public static readonly long[] Value=A040539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040539.Bytes);
public long this[int i]=>Value[i];

public static A040539Inst Instance=new A040539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040540
{
public static readonly long[] Value={ 23L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L,46L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040540Inst : IEnumerable<long>
{
public static readonly long[] Value=A040540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040540.Bytes);
public long this[int i]=>Value[i];

public static A040540Inst Instance=new A040540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040541
{
public static readonly long[] Value={ 23L,1L,3L,2L,1L,11L,5L,5L,11L,1L,2L,3L,1L,46L,1L,3L,2L,1L,11L,5L,5L,11L,1L,2L,3L,1L,46L,1L,3L,2L,1L,11L,5L,5L,11L,1L,2L,3L,1L,46L,1L,3L,2L,1L,11L,5L,5L,11L,1L,2L,3L,1L,46L,1L,3L,2L,1L,11L,5L,5L,11L,1L,2L,3L,1L,46L,1L,3L,2L,1L,11L,5L,5L,11L,1L,2L,3L,1L,46L,1L,3L,2L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040541Inst : IEnumerable<long>
{
public static readonly long[] Value=A040541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040541.Bytes);
public long this[int i]=>Value[i];

public static A040541Inst Instance=new A040541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040542
{
public static readonly long[] Value={ 23L,1L,3L,1L,3L,1L,1L,8L,1L,22L,1L,8L,1L,1L,3L,1L,3L,1L,46L,1L,3L,1L,3L,1L,1L,8L,1L,22L,1L,8L,1L,1L,3L,1L,3L,1L,46L,1L,3L,1L,3L,1L,1L,8L,1L,22L,1L,8L,1L,1L,3L,1L,3L,1L,46L,1L,3L,1L,3L,1L,1L,8L,1L,22L,1L,8L,1L,1L,3L,1L,3L,1L,46L,1L,3L,1L,3L,1L,1L,8L,1L,22L,1L,8L,1L,1L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040542Inst : IEnumerable<long>
{
public static readonly long[] Value=A040542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040542.Bytes);
public long this[int i]=>Value[i];

public static A040542Inst Instance=new A040542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040543
{
public static readonly long[] Value={ 23L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L,3L,4L,1L,46L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040543Inst : IEnumerable<long>
{
public static readonly long[] Value=A040543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040543.Bytes);
public long this[int i]=>Value[i];

public static A040543Inst Instance=new A040543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040544
{
public static readonly long[] Value={ 23L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L,46L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040544Inst : IEnumerable<long>
{
public static readonly long[] Value=A040544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040544.Bytes);
public long this[int i]=>Value[i];

public static A040544Inst Instance=new A040544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040545
{
public static readonly long[] Value={ 23L,1L,5L,1L,5L,9L,2L,1L,2L,3L,3L,2L,1L,2L,9L,5L,1L,5L,1L,46L,1L,5L,1L,5L,9L,2L,1L,2L,3L,3L,2L,1L,2L,9L,5L,1L,5L,1L,46L,1L,5L,1L,5L,9L,2L,1L,2L,3L,3L,2L,1L,2L,9L,5L,1L,5L,1L,46L,1L,5L,1L,5L,9L,2L,1L,2L,3L,3L,2L,1L,2L,9L,5L,1L,5L,1L,46L,1L,5L,1L,5L,9L,2L,1L,2L,3L,3L,2L,1L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040545Inst : IEnumerable<long>
{
public static readonly long[] Value=A040545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040545.Bytes);
public long this[int i]=>Value[i];

public static A040545Inst Instance=new A040545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040546
{
public static readonly long[] Value={ 23L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L,46L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040546Inst : IEnumerable<long>
{
public static readonly long[] Value=A040546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040546.Bytes);
public long this[int i]=>Value[i];

public static A040546Inst Instance=new A040546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040547
{
public static readonly long[] Value={ 23L,1L,8L,1L,1L,2L,1L,1L,1L,15L,3L,2L,1L,6L,7L,1L,4L,2L,3L,4L,2L,23L,2L,4L,3L,2L,4L,1L,7L,6L,1L,2L,3L,15L,1L,1L,1L,2L,1L,1L,8L,1L,46L,1L,8L,1L,1L,2L,1L,1L,1L,15L,3L,2L,1L,6L,7L,1L,4L,2L,3L,4L,2L,23L,2L,4L,3L,2L,4L,1L,7L,6L,1L,2L,3L,15L,1L,1L,1L,2L,1L,1L,8L,1L,46L,1L,8L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040547Inst : IEnumerable<long>
{
public static readonly long[] Value=A040547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040547.Bytes);
public long this[int i]=>Value[i];

public static A040547Inst Instance=new A040547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040548
{
public static readonly long[] Value={ 23L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L,1L,46L,1L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040548Inst : IEnumerable<long>
{
public static readonly long[] Value=A040548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040548.Bytes);
public long this[int i]=>Value[i];

public static A040548Inst Instance=new A040548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040549
{
public static readonly long[] Value={ 23L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L,1L,46L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040549Inst : IEnumerable<long>
{
public static readonly long[] Value=A040549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040549.Bytes);
public long this[int i]=>Value[i];

public static A040549Inst Instance=new A040549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040550
{
public static readonly long[] Value={ 23L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L,1L,46L,1L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040550Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040550.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040550Inst : IEnumerable<long>
{
public static readonly long[] Value=A040550.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040550.Bytes);
public long this[int i]=>Value[i];

public static A040550Inst Instance=new A040550Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040551
{
public static readonly long[] Value={ 23L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L,1L,46L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040551Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040551.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040551Inst : IEnumerable<long>
{
public static readonly long[] Value=A040551.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040551.Bytes);
public long this[int i]=>Value[i];

public static A040551Inst Instance=new A040551Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040552
{
public static readonly long[] Value={ 24L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040552Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040552.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040552Inst : IEnumerable<long>
{
public static readonly long[] Value=A040552.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040552.Bytes);
public long this[int i]=>Value[i];

public static A040552Inst Instance=new A040552Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040553
{
public static readonly long[] Value={ 24L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L,24L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040553Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040553.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040553Inst : IEnumerable<long>
{
public static readonly long[] Value=A040553.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040553.Bytes);
public long this[int i]=>Value[i];

public static A040553Inst Instance=new A040553Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040554
{
public static readonly long[] Value={ 24L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L,16L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040554Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040554.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040554Inst : IEnumerable<long>
{
public static readonly long[] Value=A040554.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040554.Bytes);
public long this[int i]=>Value[i];

public static A040554Inst Instance=new A040554Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040555
{
public static readonly long[] Value={ 24L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L,12L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040555Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040555.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040555Inst : IEnumerable<long>
{
public static readonly long[] Value=A040555.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040555.Bytes);
public long this[int i]=>Value[i];

public static A040555Inst Instance=new A040555Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040556
{
public static readonly long[] Value={ 24L,9L,1L,1L,1L,1L,1L,3L,11L,1L,3L,2L,6L,2L,3L,1L,11L,3L,1L,1L,1L,1L,1L,9L,48L,9L,1L,1L,1L,1L,1L,3L,11L,1L,3L,2L,6L,2L,3L,1L,11L,3L,1L,1L,1L,1L,1L,9L,48L,9L,1L,1L,1L,1L,1L,3L,11L,1L,3L,2L,6L,2L,3L,1L,11L,3L,1L,1L,1L,1L,1L,9L,48L,9L,1L,1L,1L,1L,1L,3L,11L,1L,3L,2L,6L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040556Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040556.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040556Inst : IEnumerable<long>
{
public static readonly long[] Value=A040556.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040556.Bytes);
public long this[int i]=>Value[i];

public static A040556Inst Instance=new A040556Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040701
{
public static readonly long[] Value={ 26L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L,1L,52L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040701Inst : IEnumerable<long>
{
public static readonly long[] Value=A040701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040701.Bytes);
public long this[int i]=>Value[i];

public static A040701Inst Instance=new A040701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040702
{
public static readonly long[] Value={ 27L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040702Inst : IEnumerable<long>
{
public static readonly long[] Value=A040702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040702.Bytes);
public long this[int i]=>Value[i];

public static A040702Inst Instance=new A040702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040703
{
public static readonly long[] Value={ 27L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L,27L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040703Inst : IEnumerable<long>
{
public static readonly long[] Value=A040703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040703.Bytes);
public long this[int i]=>Value[i];

public static A040703Inst Instance=new A040703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040704
{
public static readonly long[] Value={ 27L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L,18L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040704Inst : IEnumerable<long>
{
public static readonly long[] Value=A040704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040704.Bytes);
public long this[int i]=>Value[i];

public static A040704Inst Instance=new A040704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040705
{
public static readonly long[] Value={ 27L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L,1L,1L,13L,54L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040705Inst : IEnumerable<long>
{
public static readonly long[] Value=A040705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040705.Bytes);
public long this[int i]=>Value[i];

public static A040705Inst Instance=new A040705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040706
{
public static readonly long[] Value={ 27L,10L,1L,4L,1L,1L,26L,1L,1L,4L,1L,10L,54L,10L,1L,4L,1L,1L,26L,1L,1L,4L,1L,10L,54L,10L,1L,4L,1L,1L,26L,1L,1L,4L,1L,10L,54L,10L,1L,4L,1L,1L,26L,1L,1L,4L,1L,10L,54L,10L,1L,4L,1L,1L,26L,1L,1L,4L,1L,10L,54L,10L,1L,4L,1L,1L,26L,1L,1L,4L,1L,10L,54L,10L,1L,4L,1L,1L,26L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040706Inst : IEnumerable<long>
{
public static readonly long[] Value=A040706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040706.Bytes);
public long this[int i]=>Value[i];

public static A040706Inst Instance=new A040706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040707
{
public static readonly long[] Value={ 27L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L,9L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040707Inst : IEnumerable<long>
{
public static readonly long[] Value=A040707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040707.Bytes);
public long this[int i]=>Value[i];

public static A040707Inst Instance=new A040707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040708
{
public static readonly long[] Value={ 27L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L,54L,7L,1L,2L,1L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040708Inst : IEnumerable<long>
{
public static readonly long[] Value=A040708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040708.Bytes);
public long this[int i]=>Value[i];

public static A040708Inst Instance=new A040708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040709
{
public static readonly long[] Value={ 27L,6L,1L,3L,3L,7L,2L,4L,2L,7L,3L,3L,1L,6L,54L,6L,1L,3L,3L,7L,2L,4L,2L,7L,3L,3L,1L,6L,54L,6L,1L,3L,3L,7L,2L,4L,2L,7L,3L,3L,1L,6L,54L,6L,1L,3L,3L,7L,2L,4L,2L,7L,3L,3L,1L,6L,54L,6L,1L,3L,3L,7L,2L,4L,2L,7L,3L,3L,1L,6L,54L,6L,1L,3L,3L,7L,2L,4L,2L,7L,3L,3L,1L,6L,54L,6L,1L,3L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040709Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040709.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040709Inst : IEnumerable<long>
{
public static readonly long[] Value=A040709.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040709.Bytes);
public long this[int i]=>Value[i];

public static A040709Inst Instance=new A040709Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040710
{
public static readonly long[] Value={ 27L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L,6L,54L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040710Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040710.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040710Inst : IEnumerable<long>
{
public static readonly long[] Value=A040710.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040710.Bytes);
public long this[int i]=>Value[i];

public static A040710Inst Instance=new A040710Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040711
{
public static readonly long[] Value={ 27L,5L,2L,2L,1L,1L,3L,3L,2L,1L,8L,2L,1L,2L,1L,17L,2L,1L,1L,7L,5L,1L,10L,27L,10L,1L,5L,7L,1L,1L,2L,17L,1L,2L,1L,2L,8L,1L,2L,3L,3L,1L,1L,2L,2L,5L,54L,5L,2L,2L,1L,1L,3L,3L,2L,1L,8L,2L,1L,2L,1L,17L,2L,1L,1L,7L,5L,1L,10L,27L,10L,1L,5L,7L,1L,1L,2L,17L,1L,2L,1L,2L,8L,1L,2L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040711Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040711.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040711Inst : IEnumerable<long>
{
public static readonly long[] Value=A040711.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040711.Bytes);
public long this[int i]=>Value[i];

public static A040711Inst Instance=new A040711Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040712
{
public static readonly long[] Value={ 27L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L,12L,1L,4L,54L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040712Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040712.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040712Inst : IEnumerable<long>
{
public static readonly long[] Value=A040712.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040712.Bytes);
public long this[int i]=>Value[i];

public static A040712Inst Instance=new A040712Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040713
{
public static readonly long[] Value={ 27L,4L,1L,1L,13L,18L,13L,1L,1L,4L,54L,4L,1L,1L,13L,18L,13L,1L,1L,4L,54L,4L,1L,1L,13L,18L,13L,1L,1L,4L,54L,4L,1L,1L,13L,18L,13L,1L,1L,4L,54L,4L,1L,1L,13L,18L,13L,1L,1L,4L,54L,4L,1L,1L,13L,18L,13L,1L,1L,4L,54L,4L,1L,1L,13L,18L,13L,1L,1L,4L,54L,4L,1L,1L,13L,18L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040713Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040713.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040713Inst : IEnumerable<long>
{
public static readonly long[] Value=A040713.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040713.Bytes);
public long this[int i]=>Value[i];

public static A040713Inst Instance=new A040713Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040714
{
public static readonly long[] Value={ 27L,4L,5L,1L,4L,8L,1L,6L,1L,8L,4L,1L,5L,4L,54L,4L,5L,1L,4L,8L,1L,6L,1L,8L,4L,1L,5L,4L,54L,4L,5L,1L,4L,8L,1L,6L,1L,8L,4L,1L,5L,4L,54L,4L,5L,1L,4L,8L,1L,6L,1L,8L,4L,1L,5L,4L,54L,4L,5L,1L,4L,8L,1L,6L,1L,8L,4L,1L,5L,4L,54L,4L,5L,1L,4L,8L,1L,6L,1L,8L,4L,1L,5L,4L,54L,4L,5L,1L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040714Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040714.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040714Inst : IEnumerable<long>
{
public static readonly long[] Value=A040714.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040714.Bytes);
public long this[int i]=>Value[i];

public static A040714Inst Instance=new A040714Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040715
{
public static readonly long[] Value={ 27L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L,27L,7L,1L,3L,54L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040715Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040715.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040715Inst : IEnumerable<long>
{
public static readonly long[] Value=A040715.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040715.Bytes);
public long this[int i]=>Value[i];

public static A040715Inst Instance=new A040715Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040716
{
public static readonly long[] Value={ 27L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L,54L,3L,1L,1L,1L,1L,1L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040716Inst : IEnumerable<long>
{
public static readonly long[] Value=A040716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040716.Bytes);
public long this[int i]=>Value[i];

public static A040716Inst Instance=new A040716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040733
{
public static readonly long[] Value={ 27L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L,2L,2L,1L,1L,54L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040733Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040733.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040733Inst : IEnumerable<long>
{
public static readonly long[] Value=A040733.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040733.Bytes);
public long this[int i]=>Value[i];

public static A040733Inst Instance=new A040733Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040734
{
public static readonly long[] Value={ 27L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L,54L,1L,1L,1L,1L,8L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040734Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040734.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040734Inst : IEnumerable<long>
{
public static readonly long[] Value=A040734.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040734.Bytes);
public long this[int i]=>Value[i];

public static A040734Inst Instance=new A040734Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040735
{
public static readonly long[] Value={ 27L,1L,1L,1L,1L,1L,5L,1L,1L,17L,1L,6L,1L,17L,1L,1L,5L,1L,1L,1L,1L,1L,54L,1L,1L,1L,1L,1L,5L,1L,1L,17L,1L,6L,1L,17L,1L,1L,5L,1L,1L,1L,1L,1L,54L,1L,1L,1L,1L,1L,5L,1L,1L,17L,1L,6L,1L,17L,1L,1L,5L,1L,1L,1L,1L,1L,54L,1L,1L,1L,1L,1L,5L,1L,1L,17L,1L,6L,1L,17L,1L,1L,5L,1L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040735Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040735.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040735Inst : IEnumerable<long>
{
public static readonly long[] Value=A040735.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040735.Bytes);
public long this[int i]=>Value[i];

public static A040735Inst Instance=new A040735Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040736
{
public static readonly long[] Value={ 27L,1L,1L,1L,3L,1L,1L,2L,2L,1L,6L,4L,1L,7L,10L,1L,12L,1L,10L,7L,1L,4L,6L,1L,2L,2L,1L,1L,3L,1L,1L,1L,54L,1L,1L,1L,3L,1L,1L,2L,2L,1L,6L,4L,1L,7L,10L,1L,12L,1L,10L,7L,1L,4L,6L,1L,2L,2L,1L,1L,3L,1L,1L,1L,54L,1L,1L,1L,3L,1L,1L,2L,2L,1L,6L,4L,1L,7L,10L,1L,12L,1L,10L,7L,1L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040736Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040736.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040736Inst : IEnumerable<long>
{
public static readonly long[] Value=A040736.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040736.Bytes);
public long this[int i]=>Value[i];

public static A040736Inst Instance=new A040736Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040737
{
public static readonly long[] Value={ 27L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L,1L,1L,13L,6L,13L,1L,1L,1L,54L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040737Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040737.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040737Inst : IEnumerable<long>
{
public static readonly long[] Value=A040737.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040737.Bytes);
public long this[int i]=>Value[i];

public static A040737Inst Instance=new A040737Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040738
{
public static readonly long[] Value={ 27L,1L,2L,10L,1L,2L,1L,3L,1L,1L,17L,1L,8L,3L,1L,1L,2L,1L,2L,5L,5L,1L,26L,1L,5L,5L,2L,1L,2L,1L,1L,3L,8L,1L,17L,1L,1L,3L,1L,2L,1L,10L,2L,1L,54L,1L,2L,10L,1L,2L,1L,3L,1L,1L,17L,1L,8L,3L,1L,1L,2L,1L,2L,5L,5L,1L,26L,1L,5L,5L,2L,1L,2L,1L,1L,3L,8L,1L,17L,1L,1L,3L,1L,2L,1L,10L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040738Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040738.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040738Inst : IEnumerable<long>
{
public static readonly long[] Value=A040738.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040738.Bytes);
public long this[int i]=>Value[i];

public static A040738Inst Instance=new A040738Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040739
{
public static readonly long[] Value={ 27L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,54L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,54L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,54L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,54L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,54L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,54L,1L,2L,3L,1L,1L,1L,1L,1L,3L,2L,1L,54L,1L,2L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040739Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040739.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040739Inst : IEnumerable<long>
{
public static readonly long[] Value=A040739.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040739.Bytes);
public long this[int i]=>Value[i];

public static A040739Inst Instance=new A040739Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040740
{
public static readonly long[] Value={ 27L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L,13L,2L,2L,1L,54L,1L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040740Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040740.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040740Inst : IEnumerable<long>
{
public static readonly long[] Value=A040740.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040740.Bytes);
public long this[int i]=>Value[i];

public static A040740Inst Instance=new A040740Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040741
{
public static readonly long[] Value={ 27L,1L,2L,1L,2L,1L,1L,17L,1L,10L,6L,1L,5L,3L,3L,2L,1L,1L,1L,1L,1L,1L,2L,3L,3L,5L,1L,6L,10L,1L,17L,1L,1L,2L,1L,2L,1L,54L,1L,2L,1L,2L,1L,1L,17L,1L,10L,6L,1L,5L,3L,3L,2L,1L,1L,1L,1L,1L,1L,2L,3L,3L,5L,1L,6L,10L,1L,17L,1L,1L,2L,1L,2L,1L,54L,1L,2L,1L,2L,1L,1L,17L,1L,10L,6L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040741Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040741.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040741Inst : IEnumerable<long>
{
public static readonly long[] Value=A040741.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040741.Bytes);
public long this[int i]=>Value[i];

public static A040741Inst Instance=new A040741Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040742
{
public static readonly long[] Value={ 27L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L,54L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040742Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040742.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040742Inst : IEnumerable<long>
{
public static readonly long[] Value=A040742.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040742.Bytes);
public long this[int i]=>Value[i];

public static A040742Inst Instance=new A040742Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040743
{
public static readonly long[] Value={ 27L,1L,3L,3L,2L,4L,1L,1L,1L,1L,2L,27L,2L,1L,1L,1L,1L,4L,2L,3L,3L,1L,54L,1L,3L,3L,2L,4L,1L,1L,1L,1L,2L,27L,2L,1L,1L,1L,1L,4L,2L,3L,3L,1L,54L,1L,3L,3L,2L,4L,1L,1L,1L,1L,2L,27L,2L,1L,1L,1L,1L,4L,2L,3L,3L,1L,54L,1L,3L,3L,2L,4L,1L,1L,1L,1L,2L,27L,2L,1L,1L,1L,1L,4L,2L,3L,3L,1L,54L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040743Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040743.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040743Inst : IEnumerable<long>
{
public static readonly long[] Value=A040743.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040743.Bytes);
public long this[int i]=>Value[i];

public static A040743Inst Instance=new A040743Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040744
{
public static readonly long[] Value={ 27L,1L,3L,1L,1L,1L,5L,1L,1L,7L,2L,1L,1L,17L,1L,12L,1L,17L,1L,1L,2L,7L,1L,1L,5L,1L,1L,1L,3L,1L,54L,1L,3L,1L,1L,1L,5L,1L,1L,7L,2L,1L,1L,17L,1L,12L,1L,17L,1L,1L,2L,7L,1L,1L,5L,1L,1L,1L,3L,1L,54L,1L,3L,1L,1L,1L,5L,1L,1L,7L,2L,1L,1L,17L,1L,12L,1L,17L,1L,1L,2L,7L,1L,1L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040744Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040744.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040744Inst : IEnumerable<long>
{
public static readonly long[] Value=A040744.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040744.Bytes);
public long this[int i]=>Value[i];

public static A040744Inst Instance=new A040744Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040745
{
public static readonly long[] Value={ 27L,1L,4L,13L,1L,2L,2L,1L,13L,4L,1L,54L,1L,4L,13L,1L,2L,2L,1L,13L,4L,1L,54L,1L,4L,13L,1L,2L,2L,1L,13L,4L,1L,54L,1L,4L,13L,1L,2L,2L,1L,13L,4L,1L,54L,1L,4L,13L,1L,2L,2L,1L,13L,4L,1L,54L,1L,4L,13L,1L,2L,2L,1L,13L,4L,1L,54L,1L,4L,13L,1L,2L,2L,1L,13L,4L,1L,54L,1L,4L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040745Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040745.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040745Inst : IEnumerable<long>
{
public static readonly long[] Value=A040745.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040745.Bytes);
public long this[int i]=>Value[i];

public static A040745Inst Instance=new A040745Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040746
{
public static readonly long[] Value={ 27L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L,54L,1L,4L,1L,1L,2L,1L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040746Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040746.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040746Inst : IEnumerable<long>
{
public static readonly long[] Value=A040746.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040746.Bytes);
public long this[int i]=>Value[i];

public static A040746Inst Instance=new A040746Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040747
{
public static readonly long[] Value={ 27L,1L,5L,4L,1L,8L,2L,8L,1L,4L,5L,1L,54L,1L,5L,4L,1L,8L,2L,8L,1L,4L,5L,1L,54L,1L,5L,4L,1L,8L,2L,8L,1L,4L,5L,1L,54L,1L,5L,4L,1L,8L,2L,8L,1L,4L,5L,1L,54L,1L,5L,4L,1L,8L,2L,8L,1L,4L,5L,1L,54L,1L,5L,4L,1L,8L,2L,8L,1L,4L,5L,1L,54L,1L,5L,4L,1L,8L,2L,8L,1L,4L,5L,1L,54L,1L,5L,4L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040747Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040747.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040747Inst : IEnumerable<long>
{
public static readonly long[] Value=A040747.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040747.Bytes);
public long this[int i]=>Value[i];

public static A040747Inst Instance=new A040747Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040748
{
public static readonly long[] Value={ 27L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L,54L,1L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040748Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040748.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040748Inst : IEnumerable<long>
{
public static readonly long[] Value=A040748.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040748.Bytes);
public long this[int i]=>Value[i];

public static A040748Inst Instance=new A040748Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040765
{
public static readonly long[] Value={ 28L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L,1L,1L,1L,1L,1L,1L,1L,1L,5L,56L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040765Inst : IEnumerable<long>
{
public static readonly long[] Value=A040765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040765.Bytes);
public long this[int i]=>Value[i];

public static A040765Inst Instance=new A040765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040766
{
public static readonly long[] Value={ 28L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L,56L,5L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040766Inst : IEnumerable<long>
{
public static readonly long[] Value=A040766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040766.Bytes);
public long this[int i]=>Value[i];

public static A040766Inst Instance=new A040766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040767
{
public static readonly long[] Value={ 28L,4L,1L,2L,5L,1L,10L,2L,3L,1L,6L,3L,1L,1L,1L,1L,2L,4L,1L,2L,1L,18L,14L,18L,1L,2L,1L,4L,2L,1L,1L,1L,1L,3L,6L,1L,3L,2L,10L,1L,5L,2L,1L,4L,56L,4L,1L,2L,5L,1L,10L,2L,3L,1L,6L,3L,1L,1L,1L,1L,2L,4L,1L,2L,1L,18L,14L,18L,1L,2L,1L,4L,2L,1L,1L,1L,1L,3L,6L,1L,3L,2L,10L,1L,5L,2L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040767Inst : IEnumerable<long>
{
public static readonly long[] Value=A040767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040767.Bytes);
public long this[int i]=>Value[i];

public static A040767Inst Instance=new A040767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040768
{
public static readonly long[] Value={ 28L,4L,3L,13L,1L,4L,4L,1L,13L,3L,4L,56L,4L,3L,13L,1L,4L,4L,1L,13L,3L,4L,56L,4L,3L,13L,1L,4L,4L,1L,13L,3L,4L,56L,4L,3L,13L,1L,4L,4L,1L,13L,3L,4L,56L,4L,3L,13L,1L,4L,4L,1L,13L,3L,4L,56L,4L,3L,13L,1L,4L,4L,1L,13L,3L,4L,56L,4L,3L,13L,1L,4L,4L,1L,13L,3L,4L,56L,4L,3L,13L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040768Inst : IEnumerable<long>
{
public static readonly long[] Value=A040768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040768.Bytes);
public long this[int i]=>Value[i];

public static A040768Inst Instance=new A040768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040769
{
public static readonly long[] Value={ 28L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L,4L,56L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040769Inst : IEnumerable<long>
{
public static readonly long[] Value=A040769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040769.Bytes);
public long this[int i]=>Value[i];

public static A040769Inst Instance=new A040769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040770
{
public static readonly long[] Value={ 28L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L,56L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040770Inst : IEnumerable<long>
{
public static readonly long[] Value=A040770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040770.Bytes);
public long this[int i]=>Value[i];

public static A040770Inst Instance=new A040770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040771
{
public static readonly long[] Value={ 28L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L,13L,1L,1L,3L,56L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040771Inst : IEnumerable<long>
{
public static readonly long[] Value=A040771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040771.Bytes);
public long this[int i]=>Value[i];

public static A040771Inst Instance=new A040771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040772
{
public static readonly long[] Value={ 28L,3L,3L,4L,1L,5L,2L,10L,1L,6L,6L,6L,1L,10L,2L,5L,1L,4L,3L,3L,56L,3L,3L,4L,1L,5L,2L,10L,1L,6L,6L,6L,1L,10L,2L,5L,1L,4L,3L,3L,56L,3L,3L,4L,1L,5L,2L,10L,1L,6L,6L,6L,1L,10L,2L,5L,1L,4L,3L,3L,56L,3L,3L,4L,1L,5L,2L,10L,1L,6L,6L,6L,1L,10L,2L,5L,1L,4L,3L,3L,56L,3L,3L,4L,1L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040772Inst : IEnumerable<long>
{
public static readonly long[] Value=A040772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040772.Bytes);
public long this[int i]=>Value[i];

public static A040772Inst Instance=new A040772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040773
{
public static readonly long[] Value={ 28L,3L,7L,1L,3L,6L,28L,6L,3L,1L,7L,3L,56L,3L,7L,1L,3L,6L,28L,6L,3L,1L,7L,3L,56L,3L,7L,1L,3L,6L,28L,6L,3L,1L,7L,3L,56L,3L,7L,1L,3L,6L,28L,6L,3L,1L,7L,3L,56L,3L,7L,1L,3L,6L,28L,6L,3L,1L,7L,3L,56L,3L,7L,1L,3L,6L,28L,6L,3L,1L,7L,3L,56L,3L,7L,1L,3L,6L,28L,6L,3L,1L,7L,3L,56L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040773Inst : IEnumerable<long>
{
public static readonly long[] Value=A040773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040773.Bytes);
public long this[int i]=>Value[i];

public static A040773Inst Instance=new A040773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040774
{
public static readonly long[] Value={ 28L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L,27L,1L,2L,56L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040774Inst : IEnumerable<long>
{
public static readonly long[] Value=A040774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040774.Bytes);
public long this[int i]=>Value[i];

public static A040774Inst Instance=new A040774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040775
{
public static readonly long[] Value={ 28L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L,18L,2L,4L,1L,2L,56L,2L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040775Inst : IEnumerable<long>
{
public static readonly long[] Value=A040775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040775.Bytes);
public long this[int i]=>Value[i];

public static A040775Inst Instance=new A040775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040776
{
public static readonly long[] Value={ 28L,2L,1L,2L,5L,1L,13L,2L,1L,10L,1L,2L,13L,1L,5L,2L,1L,2L,56L,2L,1L,2L,5L,1L,13L,2L,1L,10L,1L,2L,13L,1L,5L,2L,1L,2L,56L,2L,1L,2L,5L,1L,13L,2L,1L,10L,1L,2L,13L,1L,5L,2L,1L,2L,56L,2L,1L,2L,5L,1L,13L,2L,1L,10L,1L,2L,13L,1L,5L,2L,1L,2L,56L,2L,1L,2L,5L,1L,13L,2L,1L,10L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040776Inst : IEnumerable<long>
{
public static readonly long[] Value=A040776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040776.Bytes);
public long this[int i]=>Value[i];

public static A040776Inst Instance=new A040776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040777
{
public static readonly long[] Value={ 28L,2L,1L,1L,3L,2L,5L,4L,5L,2L,3L,1L,1L,2L,56L,2L,1L,1L,3L,2L,5L,4L,5L,2L,3L,1L,1L,2L,56L,2L,1L,1L,3L,2L,5L,4L,5L,2L,3L,1L,1L,2L,56L,2L,1L,1L,3L,2L,5L,4L,5L,2L,3L,1L,1L,2L,56L,2L,1L,1L,3L,2L,5L,4L,5L,2L,3L,1L,1L,2L,56L,2L,1L,1L,3L,2L,5L,4L,5L,2L,3L,1L,1L,2L,56L,2L,1L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040777Inst : IEnumerable<long>
{
public static readonly long[] Value=A040777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040777.Bytes);
public long this[int i]=>Value[i];

public static A040777Inst Instance=new A040777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040778
{
public static readonly long[] Value={ 28L,2L,2L,4L,1L,3L,4L,9L,4L,3L,1L,4L,2L,2L,56L,2L,2L,4L,1L,3L,4L,9L,4L,3L,1L,4L,2L,2L,56L,2L,2L,4L,1L,3L,4L,9L,4L,3L,1L,4L,2L,2L,56L,2L,2L,4L,1L,3L,4L,9L,4L,3L,1L,4L,2L,2L,56L,2L,2L,4L,1L,3L,4L,9L,4L,3L,1L,4L,2L,2L,56L,2L,2L,4L,1L,3L,4L,9L,4L,3L,1L,4L,2L,2L,56L,2L,2L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040778Inst : IEnumerable<long>
{
public static readonly long[] Value=A040778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040778.Bytes);
public long this[int i]=>Value[i];

public static A040778Inst Instance=new A040778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040779
{
public static readonly long[] Value={ 28L,2L,2L,1L,5L,1L,1L,1L,1L,13L,1L,1L,1L,1L,5L,1L,2L,2L,56L,2L,2L,1L,5L,1L,1L,1L,1L,13L,1L,1L,1L,1L,5L,1L,2L,2L,56L,2L,2L,1L,5L,1L,1L,1L,1L,13L,1L,1L,1L,1L,5L,1L,2L,2L,56L,2L,2L,1L,5L,1L,1L,1L,1L,13L,1L,1L,1L,1L,5L,1L,2L,2L,56L,2L,2L,1L,5L,1L,1L,1L,1L,13L,1L,1L,1L,1L,5L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040779Inst : IEnumerable<long>
{
public static readonly long[] Value=A040779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040779.Bytes);
public long this[int i]=>Value[i];

public static A040779Inst Instance=new A040779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040780
{
public static readonly long[] Value={ 28L,2L,3L,1L,7L,2L,1L,6L,2L,3L,11L,11L,3L,2L,6L,1L,2L,7L,1L,3L,2L,56L,2L,3L,1L,7L,2L,1L,6L,2L,3L,11L,11L,3L,2L,6L,1L,2L,7L,1L,3L,2L,56L,2L,3L,1L,7L,2L,1L,6L,2L,3L,11L,11L,3L,2L,6L,1L,2L,7L,1L,3L,2L,56L,2L,3L,1L,7L,2L,1L,6L,2L,3L,11L,11L,3L,2L,6L,1L,2L,7L,1L,3L,2L,56L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040780Inst : IEnumerable<long>
{
public static readonly long[] Value=A040780.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040780.Bytes);
public long this[int i]=>Value[i];

public static A040780Inst Instance=new A040780Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040797
{
public static readonly long[] Value={ 28L,1L,2L,1L,5L,1L,1L,1L,3L,5L,2L,9L,8L,9L,2L,5L,3L,1L,1L,1L,5L,1L,2L,1L,56L,1L,2L,1L,5L,1L,1L,1L,3L,5L,2L,9L,8L,9L,2L,5L,3L,1L,1L,1L,5L,1L,2L,1L,56L,1L,2L,1L,5L,1L,1L,1L,3L,5L,2L,9L,8L,9L,2L,5L,3L,1L,1L,1L,5L,1L,2L,1L,56L,1L,2L,1L,5L,1L,1L,1L,3L,5L,2L,9L,8L,9L,2L,5L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040797Inst : IEnumerable<long>
{
public static readonly long[] Value=A040797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040797.Bytes);
public long this[int i]=>Value[i];

public static A040797Inst Instance=new A040797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040798
{
public static readonly long[] Value={ 28L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L,27L,1L,7L,3L,1L,56L,1L,3L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040798Inst : IEnumerable<long>
{
public static readonly long[] Value=A040798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040798.Bytes);
public long this[int i]=>Value[i];

public static A040798Inst Instance=new A040798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040799
{
public static readonly long[] Value={ 28L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L,2L,3L,1L,56L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040799Inst : IEnumerable<long>
{
public static readonly long[] Value=A040799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040799.Bytes);
public long this[int i]=>Value[i];

public static A040799Inst Instance=new A040799Inst();

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