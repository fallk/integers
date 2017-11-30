using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A040448
{
public static readonly long[] Value={ 21L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L,8L,2L,1L,42L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040448Inst : IEnumerable<long>
{
public static readonly long[] Value=A040448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040448.Bytes);
public long this[int i]=>Value[i];

public static A040448Inst Instance=new A040448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040449
{
public static readonly long[] Value={ 21L,1L,2L,2L,1L,3L,4L,14L,4L,3L,1L,2L,2L,1L,42L,1L,2L,2L,1L,3L,4L,14L,4L,3L,1L,2L,2L,1L,42L,1L,2L,2L,1L,3L,4L,14L,4L,3L,1L,2L,2L,1L,42L,1L,2L,2L,1L,3L,4L,14L,4L,3L,1L,2L,2L,1L,42L,1L,2L,2L,1L,3L,4L,14L,4L,3L,1L,2L,2L,1L,42L,1L,2L,2L,1L,3L,4L,14L,4L,3L,1L,2L,2L,1L,42L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040449Inst : IEnumerable<long>
{
public static readonly long[] Value=A040449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040449.Bytes);
public long this[int i]=>Value[i];

public static A040449Inst Instance=new A040449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040450
{
public static readonly long[] Value={ 21L,1L,2L,1L,1L,1L,4L,5L,4L,1L,1L,1L,2L,1L,42L,1L,2L,1L,1L,1L,4L,5L,4L,1L,1L,1L,2L,1L,42L,1L,2L,1L,1L,1L,4L,5L,4L,1L,1L,1L,2L,1L,42L,1L,2L,1L,1L,1L,4L,5L,4L,1L,1L,1L,2L,1L,42L,1L,2L,1L,1L,1L,4L,5L,4L,1L,1L,1L,2L,1L,42L,1L,2L,1L,1L,1L,4L,5L,4L,1L,1L,1L,2L,1L,42L,1L,2L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040450Inst : IEnumerable<long>
{
public static readonly long[] Value=A040450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040450.Bytes);
public long this[int i]=>Value[i];

public static A040450Inst Instance=new A040450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040451
{
public static readonly long[] Value={ 21L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L,42L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040451Inst : IEnumerable<long>
{
public static readonly long[] Value=A040451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040451.Bytes);
public long this[int i]=>Value[i];

public static A040451Inst Instance=new A040451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040452
{
public static readonly long[] Value={ 21L,1L,3L,2L,1L,1L,1L,6L,1L,1L,1L,2L,3L,1L,42L,1L,3L,2L,1L,1L,1L,6L,1L,1L,1L,2L,3L,1L,42L,1L,3L,2L,1L,1L,1L,6L,1L,1L,1L,2L,3L,1L,42L,1L,3L,2L,1L,1L,1L,6L,1L,1L,1L,2L,3L,1L,42L,1L,3L,2L,1L,1L,1L,6L,1L,1L,1L,2L,3L,1L,42L,1L,3L,2L,1L,1L,1L,6L,1L,1L,1L,2L,3L,1L,42L,1L,3L,2L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040452Inst : IEnumerable<long>
{
public static readonly long[] Value=A040452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040452.Bytes);
public long this[int i]=>Value[i];

public static A040452Inst Instance=new A040452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040453
{
public static readonly long[] Value={ 21L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L,42L,1L,3L,1L,6L,2L,6L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040453Inst : IEnumerable<long>
{
public static readonly long[] Value=A040453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040453.Bytes);
public long this[int i]=>Value[i];

public static A040453Inst Instance=new A040453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040454
{
public static readonly long[] Value={ 21L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L,10L,2L,4L,1L,42L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040454Inst : IEnumerable<long>
{
public static readonly long[] Value=A040454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040454.Bytes);
public long this[int i]=>Value[i];

public static A040454Inst Instance=new A040454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040455
{
public static readonly long[] Value={ 21L,1L,5L,3L,1L,4L,10L,1L,2L,2L,4L,2L,2L,1L,10L,4L,1L,3L,5L,1L,42L,1L,5L,3L,1L,4L,10L,1L,2L,2L,4L,2L,2L,1L,10L,4L,1L,3L,5L,1L,42L,1L,5L,3L,1L,4L,10L,1L,2L,2L,4L,2L,2L,1L,10L,4L,1L,3L,5L,1L,42L,1L,5L,3L,1L,4L,10L,1L,2L,2L,4L,2L,2L,1L,10L,4L,1L,3L,5L,1L,42L,1L,5L,3L,1L,4L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040455Inst : IEnumerable<long>
{
public static readonly long[] Value=A040455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040455.Bytes);
public long this[int i]=>Value[i];

public static A040455Inst Instance=new A040455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040456
{
public static readonly long[] Value={ 21L,1L,6L,3L,4L,1L,1L,5L,1L,2L,3L,1L,1L,1L,1L,1L,13L,1L,20L,1L,13L,1L,1L,1L,1L,1L,3L,2L,1L,5L,1L,1L,4L,3L,6L,1L,42L,1L,6L,3L,4L,1L,1L,5L,1L,2L,3L,1L,1L,1L,1L,1L,13L,1L,20L,1L,13L,1L,1L,1L,1L,1L,3L,2L,1L,5L,1L,1L,4L,3L,6L,1L,42L,1L,6L,3L,4L,1L,1L,5L,1L,2L,3L,1L,1L,1L,1L,1L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040456Inst : IEnumerable<long>
{
public static readonly long[] Value=A040456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040456.Bytes);
public long this[int i]=>Value[i];

public static A040456Inst Instance=new A040456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040457
{
public static readonly long[] Value={ 21L,1L,7L,1L,3L,2L,21L,2L,3L,1L,7L,1L,42L,1L,7L,1L,3L,2L,21L,2L,3L,1L,7L,1L,42L,1L,7L,1L,3L,2L,21L,2L,3L,1L,7L,1L,42L,1L,7L,1L,3L,2L,21L,2L,3L,1L,7L,1L,42L,1L,7L,1L,3L,2L,21L,2L,3L,1L,7L,1L,42L,1L,7L,1L,3L,2L,21L,2L,3L,1L,7L,1L,42L,1L,7L,1L,3L,2L,21L,2L,3L,1L,7L,1L,42L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040457Inst : IEnumerable<long>
{
public static readonly long[] Value=A040457.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040457.Bytes);
public long this[int i]=>Value[i];

public static A040457Inst Instance=new A040457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040458
{
public static readonly long[] Value={ 21L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L,42L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040458Inst : IEnumerable<long>
{
public static readonly long[] Value=A040458.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040458.Bytes);
public long this[int i]=>Value[i];

public static A040458Inst Instance=new A040458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040459
{
public static readonly long[] Value={ 21L,1L,13L,1L,1L,1L,4L,4L,1L,1L,1L,13L,1L,42L,1L,13L,1L,1L,1L,4L,4L,1L,1L,1L,13L,1L,42L,1L,13L,1L,1L,1L,4L,4L,1L,1L,1L,13L,1L,42L,1L,13L,1L,1L,1L,4L,4L,1L,1L,1L,13L,1L,42L,1L,13L,1L,1L,1L,4L,4L,1L,1L,1L,13L,1L,42L,1L,13L,1L,1L,1L,4L,4L,1L,1L,1L,13L,1L,42L,1L,13L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040459Inst : IEnumerable<long>
{
public static readonly long[] Value=A040459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040459.Bytes);
public long this[int i]=>Value[i];

public static A040459Inst Instance=new A040459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040460
{
public static readonly long[] Value={ 21L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L,1L,42L,1L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040460Inst : IEnumerable<long>
{
public static readonly long[] Value=A040460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040460.Bytes);
public long this[int i]=>Value[i];

public static A040460Inst Instance=new A040460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040477
{
public static readonly long[] Value={ 22L,2L,1L,3L,2L,1L,1L,10L,1L,1L,2L,3L,1L,2L,44L,2L,1L,3L,2L,1L,1L,10L,1L,1L,2L,3L,1L,2L,44L,2L,1L,3L,2L,1L,1L,10L,1L,1L,2L,3L,1L,2L,44L,2L,1L,3L,2L,1L,1L,10L,1L,1L,2L,3L,1L,2L,44L,2L,1L,3L,2L,1L,1L,10L,1L,1L,2L,3L,1L,2L,44L,2L,1L,3L,2L,1L,1L,10L,1L,1L,2L,3L,1L,2L,44L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040477Inst : IEnumerable<long>
{
public static readonly long[] Value=A040477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040477.Bytes);
public long this[int i]=>Value[i];

public static A040477Inst Instance=new A040477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040478
{
public static readonly long[] Value={ 22L,2L,1L,1L,1L,1L,3L,8L,1L,2L,10L,1L,5L,2L,14L,2L,5L,1L,10L,2L,1L,8L,3L,1L,1L,1L,1L,2L,44L,2L,1L,1L,1L,1L,3L,8L,1L,2L,10L,1L,5L,2L,14L,2L,5L,1L,10L,2L,1L,8L,3L,1L,1L,1L,1L,2L,44L,2L,1L,1L,1L,1L,3L,8L,1L,2L,10L,1L,5L,2L,14L,2L,5L,1L,10L,2L,1L,8L,3L,1L,1L,1L,1L,2L,44L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040478Inst : IEnumerable<long>
{
public static readonly long[] Value=A040478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040478.Bytes);
public long this[int i]=>Value[i];

public static A040478Inst Instance=new A040478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040479
{
public static readonly long[] Value={ 22L,2L,2L,7L,14L,1L,4L,22L,4L,1L,14L,7L,2L,2L,44L,2L,2L,7L,14L,1L,4L,22L,4L,1L,14L,7L,2L,2L,44L,2L,2L,7L,14L,1L,4L,22L,4L,1L,14L,7L,2L,2L,44L,2L,2L,7L,14L,1L,4L,22L,4L,1L,14L,7L,2L,2L,44L,2L,2L,7L,14L,1L,4L,22L,4L,1L,14L,7L,2L,2L,44L,2L,2L,7L,14L,1L,4L,22L,4L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040479Inst : IEnumerable<long>
{
public static readonly long[] Value=A040479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040479.Bytes);
public long this[int i]=>Value[i];

public static A040479Inst Instance=new A040479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040480
{
public static readonly long[] Value={ 22L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L,21L,1L,2L,2L,44L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040480Inst : IEnumerable<long>
{
public static readonly long[] Value=A040480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040480.Bytes);
public long this[int i]=>Value[i];

public static A040480Inst Instance=new A040480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040481
{
public static readonly long[] Value={ 22L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L,44L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040481Inst : IEnumerable<long>
{
public static readonly long[] Value=A040481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040481.Bytes);
public long this[int i]=>Value[i];

public static A040481Inst Instance=new A040481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040482
{
public static readonly long[] Value={ 22L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L,44L,2L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040482Inst : IEnumerable<long>
{
public static readonly long[] Value=A040482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040482.Bytes);
public long this[int i]=>Value[i];

public static A040482Inst Instance=new A040482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040483
{
public static readonly long[] Value={ 22L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L,2L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040483Inst : IEnumerable<long>
{
public static readonly long[] Value=A040483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040483.Bytes);
public long this[int i]=>Value[i];

public static A040483Inst Instance=new A040483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040484
{
public static readonly long[] Value={ 22L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L,14L,1L,1L,44L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040484Inst : IEnumerable<long>
{
public static readonly long[] Value=A040484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040484.Bytes);
public long this[int i]=>Value[i];

public static A040484Inst Instance=new A040484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040485
{
public static readonly long[] Value={ 22L,1L,1L,5L,1L,14L,5L,1L,1L,3L,4L,1L,2L,1L,1L,1L,10L,1L,1L,1L,2L,1L,4L,3L,1L,1L,5L,14L,1L,5L,1L,1L,44L,1L,1L,5L,1L,14L,5L,1L,1L,3L,4L,1L,2L,1L,1L,1L,10L,1L,1L,1L,2L,1L,4L,3L,1L,1L,5L,14L,1L,5L,1L,1L,44L,1L,1L,5L,1L,14L,5L,1L,1L,3L,4L,1L,2L,1L,1L,1L,10L,1L,1L,1L,2L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040485Inst : IEnumerable<long>
{
public static readonly long[] Value=A040485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040485.Bytes);
public long this[int i]=>Value[i];

public static A040485Inst Instance=new A040485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040486
{
public static readonly long[] Value={ 22L,1L,1L,3L,1L,1L,2L,10L,1L,8L,8L,1L,10L,2L,1L,1L,3L,1L,1L,44L,1L,1L,3L,1L,1L,2L,10L,1L,8L,8L,1L,10L,2L,1L,1L,3L,1L,1L,44L,1L,1L,3L,1L,1L,2L,10L,1L,8L,8L,1L,10L,2L,1L,1L,3L,1L,1L,44L,1L,1L,3L,1L,1L,2L,10L,1L,8L,8L,1L,10L,2L,1L,1L,3L,1L,1L,44L,1L,1L,3L,1L,1L,2L,10L,1L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040486Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040486.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040486Inst : IEnumerable<long>
{
public static readonly long[] Value=A040486.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040486.Bytes);
public long this[int i]=>Value[i];

public static A040486Inst Instance=new A040486Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040487
{
public static readonly long[] Value={ 22L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L,2L,1L,1L,44L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040487Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040487.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040487Inst : IEnumerable<long>
{
public static readonly long[] Value=A040487.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040487.Bytes);
public long this[int i]=>Value[i];

public static A040487Inst Instance=new A040487Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040488
{
public static readonly long[] Value={ 22L,1L,1L,1L,1L,6L,1L,14L,4L,1L,21L,1L,4L,14L,1L,6L,1L,1L,1L,1L,44L,1L,1L,1L,1L,6L,1L,14L,4L,1L,21L,1L,4L,14L,1L,6L,1L,1L,1L,1L,44L,1L,1L,1L,1L,6L,1L,14L,4L,1L,21L,1L,4L,14L,1L,6L,1L,1L,1L,1L,44L,1L,1L,1L,1L,6L,1L,14L,4L,1L,21L,1L,4L,14L,1L,6L,1L,1L,1L,1L,44L,1L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040488Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040488.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040488Inst : IEnumerable<long>
{
public static readonly long[] Value=A040488.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040488.Bytes);
public long this[int i]=>Value[i];

public static A040488Inst Instance=new A040488Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040489
{
public static readonly long[] Value={ 22L,1L,1L,1L,2L,6L,11L,6L,2L,1L,1L,1L,44L,1L,1L,1L,2L,6L,11L,6L,2L,1L,1L,1L,44L,1L,1L,1L,2L,6L,11L,6L,2L,1L,1L,1L,44L,1L,1L,1L,2L,6L,11L,6L,2L,1L,1L,1L,44L,1L,1L,1L,2L,6L,11L,6L,2L,1L,1L,1L,44L,1L,1L,1L,2L,6L,11L,6L,2L,1L,1L,1L,44L,1L,1L,1L,2L,6L,11L,6L,2L,1L,1L,1L,44L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040489Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040489.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040489Inst : IEnumerable<long>
{
public static readonly long[] Value=A040489.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040489.Bytes);
public long this[int i]=>Value[i];

public static A040489Inst Instance=new A040489Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040490
{
public static readonly long[] Value={ 22L,1L,1L,1L,5L,1L,4L,5L,2L,5L,4L,1L,5L,1L,1L,1L,44L,1L,1L,1L,5L,1L,4L,5L,2L,5L,4L,1L,5L,1L,1L,1L,44L,1L,1L,1L,5L,1L,4L,5L,2L,5L,4L,1L,5L,1L,1L,1L,44L,1L,1L,1L,5L,1L,4L,5L,2L,5L,4L,1L,5L,1L,1L,1L,44L,1L,1L,1L,5L,1L,4L,5L,2L,5L,4L,1L,5L,1L,1L,1L,44L,1L,1L,1L,5L,1L,4L,5L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040490Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040490.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040490Inst : IEnumerable<long>
{
public static readonly long[] Value=A040490.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040490.Bytes);
public long this[int i]=>Value[i];

public static A040490Inst Instance=new A040490Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040491
{
public static readonly long[] Value={ 22L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L,22L,2L,1L,44L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040491Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040491.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040491Inst : IEnumerable<long>
{
public static readonly long[] Value=A040491.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040491.Bytes);
public long this[int i]=>Value[i];

public static A040491Inst Instance=new A040491Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040492
{
public static readonly long[] Value={ 22L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L,44L,1L,2L,3L,1L,3L,1L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040492Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040492.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040492Inst : IEnumerable<long>
{
public static readonly long[] Value=A040492.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040492.Bytes);
public long this[int i]=>Value[i];

public static A040492Inst Instance=new A040492Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040509
{
public static readonly long[] Value={ 23L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L,1L,1L,11L,46L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040509Inst : IEnumerable<long>
{
public static readonly long[] Value=A040509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040509.Bytes);
public long this[int i]=>Value[i];

public static A040509Inst Instance=new A040509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040510
{
public static readonly long[] Value={ 23L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L,22L,1L,1L,4L,9L,46L,9L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040510Inst : IEnumerable<long>
{
public static readonly long[] Value=A040510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040510.Bytes);
public long this[int i]=>Value[i];

public static A040510Inst Instance=new A040510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040511
{
public static readonly long[] Value={ 23L,7L,1L,2L,4L,1L,3L,1L,4L,2L,1L,7L,46L,7L,1L,2L,4L,1L,3L,1L,4L,2L,1L,7L,46L,7L,1L,2L,4L,1L,3L,1L,4L,2L,1L,7L,46L,7L,1L,2L,4L,1L,3L,1L,4L,2L,1L,7L,46L,7L,1L,2L,4L,1L,3L,1L,4L,2L,1L,7L,46L,7L,1L,2L,4L,1L,3L,1L,4L,2L,1L,7L,46L,7L,1L,2L,4L,1L,3L,1L,4L,2L,1L,7L,46L,7L,1L,2L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040511Inst : IEnumerable<long>
{
public static readonly long[] Value=A040511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040511.Bytes);
public long this[int i]=>Value[i];

public static A040511Inst Instance=new A040511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040512
{
public static readonly long[] Value={ 23L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L,46L,6L,1L,1L,2L,5L,2L,1L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040512Inst : IEnumerable<long>
{
public static readonly long[] Value=A040512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040512.Bytes);
public long this[int i]=>Value[i];

public static A040512Inst Instance=new A040512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040513
{
public static readonly long[] Value={ 23L,5L,1L,3L,2L,1L,1L,1L,2L,1L,14L,1L,2L,1L,1L,1L,2L,3L,1L,5L,46L,5L,1L,3L,2L,1L,1L,1L,2L,1L,14L,1L,2L,1L,1L,1L,2L,3L,1L,5L,46L,5L,1L,3L,2L,1L,1L,1L,2L,1L,14L,1L,2L,1L,1L,1L,2L,3L,1L,5L,46L,5L,1L,3L,2L,1L,1L,1L,2L,1L,14L,1L,2L,1L,1L,1L,2L,3L,1L,5L,46L,5L,1L,3L,2L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040513Inst : IEnumerable<long>
{
public static readonly long[] Value=A040513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040513.Bytes);
public long this[int i]=>Value[i];

public static A040513Inst Instance=new A040513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040514
{
public static readonly long[] Value={ 23L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L,1L,1L,7L,5L,46L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040514Inst : IEnumerable<long>
{
public static readonly long[] Value=A040514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040514.Bytes);
public long this[int i]=>Value[i];

public static A040514Inst Instance=new A040514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040515
{
public static readonly long[] Value={ 23L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L,46L,4L,1L,1L,1L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040515Inst : IEnumerable<long>
{
public static readonly long[] Value=A040515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040515.Bytes);
public long this[int i]=>Value[i];

public static A040515Inst Instance=new A040515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040516
{
public static readonly long[] Value={ 23L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L,10L,1L,4L,4L,46L,4L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040516Inst : IEnumerable<long>
{
public static readonly long[] Value=A040516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040516.Bytes);
public long this[int i]=>Value[i];

public static A040516Inst Instance=new A040516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040517
{
public static readonly long[] Value={ 23L,3L,1L,5L,1L,8L,2L,4L,1L,2L,3L,1L,1L,11L,15L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,15L,11L,1L,1L,3L,2L,1L,4L,2L,8L,1L,5L,1L,3L,46L,3L,1L,5L,1L,8L,2L,4L,1L,2L,3L,1L,1L,11L,15L,2L,2L,1L,1L,1L,1L,1L,1L,2L,2L,15L,11L,1L,1L,3L,2L,1L,4L,2L,8L,1L,5L,1L,3L,46L,3L,1L,5L,1L,8L,2L,4L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040517Inst : IEnumerable<long>
{
public static readonly long[] Value=A040517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040517.Bytes);
public long this[int i]=>Value[i];

public static A040517Inst Instance=new A040517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040518
{
public static readonly long[] Value={ 23L,3L,1L,1L,3L,1L,1L,1L,22L,1L,1L,1L,3L,1L,1L,3L,46L,3L,1L,1L,3L,1L,1L,1L,22L,1L,1L,1L,3L,1L,1L,3L,46L,3L,1L,1L,3L,1L,1L,1L,22L,1L,1L,1L,3L,1L,1L,3L,46L,3L,1L,1L,3L,1L,1L,1L,22L,1L,1L,1L,3L,1L,1L,3L,46L,3L,1L,1L,3L,1L,1L,1L,22L,1L,1L,1L,3L,1L,1L,3L,46L,3L,1L,1L,3L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040518Inst : IEnumerable<long>
{
public static readonly long[] Value=A040518.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040518.Bytes);
public long this[int i]=>Value[i];

public static A040518Inst Instance=new A040518Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040519
{
public static readonly long[] Value={ 23L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L,14L,1L,3L,3L,3L,46L,3L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040519Inst : IEnumerable<long>
{
public static readonly long[] Value=A040519.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040519.Bytes);
public long this[int i]=>Value[i];

public static A040519Inst Instance=new A040519Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040520
{
public static readonly long[] Value={ 23L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L,3L,46L,3L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040520Inst : IEnumerable<long>
{
public static readonly long[] Value=A040520.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040520.Bytes);
public long this[int i]=>Value[i];

public static A040520Inst Instance=new A040520Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040521
{
public static readonly long[] Value={ 23L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L,8L,1L,2L,46L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040521Inst : IEnumerable<long>
{
public static readonly long[] Value=A040521.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040521.Bytes);
public long this[int i]=>Value[i];

public static A040521Inst Instance=new A040521Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040522
{
public static readonly long[] Value={ 23L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L,2L,1L,2L,46L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040522Inst : IEnumerable<long>
{
public static readonly long[] Value=A040522.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040522.Bytes);
public long this[int i]=>Value[i];

public static A040522Inst Instance=new A040522Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040523
{
public static readonly long[] Value={ 23L,2L,1L,1L,2L,1L,2L,1L,7L,15L,2L,6L,5L,23L,5L,6L,2L,15L,7L,1L,2L,1L,2L,1L,1L,2L,46L,2L,1L,1L,2L,1L,2L,1L,7L,15L,2L,6L,5L,23L,5L,6L,2L,15L,7L,1L,2L,1L,2L,1L,1L,2L,46L,2L,1L,1L,2L,1L,2L,1L,7L,15L,2L,6L,5L,23L,5L,6L,2L,15L,7L,1L,2L,1L,2L,1L,1L,2L,46L,2L,1L,1L,2L,1L,2L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040523Inst : IEnumerable<long>
{
public static readonly long[] Value=A040523.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040523.Bytes);
public long this[int i]=>Value[i];

public static A040523Inst Instance=new A040523Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040524
{
public static readonly long[] Value={ 23L,2L,2L,3L,1L,5L,1L,10L,1L,5L,1L,3L,2L,2L,46L,2L,2L,3L,1L,5L,1L,10L,1L,5L,1L,3L,2L,2L,46L,2L,2L,3L,1L,5L,1L,10L,1L,5L,1L,3L,2L,2L,46L,2L,2L,3L,1L,5L,1L,10L,1L,5L,1L,3L,2L,2L,46L,2L,2L,3L,1L,5L,1L,10L,1L,5L,1L,3L,2L,2L,46L,2L,2L,3L,1L,5L,1L,10L,1L,5L,1L,3L,2L,2L,46L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040524Inst : IEnumerable<long>
{
public static readonly long[] Value=A040524.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040524.Bytes);
public long this[int i]=>Value[i];

public static A040524Inst Instance=new A040524Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040557
{
public static readonly long[] Value={ 24L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L,8L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040557Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040557.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040557Inst : IEnumerable<long>
{
public static readonly long[] Value=A040557.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040557.Bytes);
public long this[int i]=>Value[i];

public static A040557Inst Instance=new A040557Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040558
{
public static readonly long[] Value={ 24L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L,48L,6L,1L,7L,5L,4L,5L,7L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040558Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040558.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040558Inst : IEnumerable<long>
{
public static readonly long[] Value=A040558.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040558.Bytes);
public long this[int i]=>Value[i];

public static A040558Inst Instance=new A040558Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040559
{
public static readonly long[] Value={ 24L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L,6L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040559Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040559.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040559Inst : IEnumerable<long>
{
public static readonly long[] Value=A040559.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040559.Bytes);
public long this[int i]=>Value[i];

public static A040559Inst Instance=new A040559Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040560
{
public static readonly long[] Value={ 24L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L,48L,5L,2L,1L,4L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040560Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040560.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040560Inst : IEnumerable<long>
{
public static readonly long[] Value=A040560.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040560.Bytes);
public long this[int i]=>Value[i];

public static A040560Inst Instance=new A040560Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040561
{
public static readonly long[] Value={ 24L,4L,1L,4L,1L,1L,2L,1L,2L,7L,1L,2L,2L,1L,7L,2L,1L,2L,1L,1L,4L,1L,4L,48L,4L,1L,4L,1L,1L,2L,1L,2L,7L,1L,2L,2L,1L,7L,2L,1L,2L,1L,1L,4L,1L,4L,48L,4L,1L,4L,1L,1L,2L,1L,2L,7L,1L,2L,2L,1L,7L,2L,1L,2L,1L,1L,4L,1L,4L,48L,4L,1L,4L,1L,1L,2L,1L,2L,7L,1L,2L,2L,1L,7L,2L,1L,2L,1L,1L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040561Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040561.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040561Inst : IEnumerable<long>
{
public static readonly long[] Value=A040561.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040561.Bytes);
public long this[int i]=>Value[i];

public static A040561Inst Instance=new A040561Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040562
{
public static readonly long[] Value={ 24L,4L,2L,1L,1L,1L,1L,23L,1L,1L,1L,1L,2L,4L,48L,4L,2L,1L,1L,1L,1L,23L,1L,1L,1L,1L,2L,4L,48L,4L,2L,1L,1L,1L,1L,23L,1L,1L,1L,1L,2L,4L,48L,4L,2L,1L,1L,1L,1L,23L,1L,1L,1L,1L,2L,4L,48L,4L,2L,1L,1L,1L,1L,23L,1L,1L,1L,1L,2L,4L,48L,4L,2L,1L,1L,1L,1L,23L,1L,1L,1L,1L,2L,4L,48L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040562Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040562.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040562Inst : IEnumerable<long>
{
public static readonly long[] Value=A040562.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040562.Bytes);
public long this[int i]=>Value[i];

public static A040562Inst Instance=new A040562Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040563
{
public static readonly long[] Value={ 24L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L,4L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040563Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040563.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040563Inst : IEnumerable<long>
{
public static readonly long[] Value=A040563.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040563.Bytes);
public long this[int i]=>Value[i];

public static A040563Inst Instance=new A040563Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040564
{
public static readonly long[] Value={ 24L,3L,1L,2L,2L,15L,1L,3L,9L,2L,4L,1L,11L,3L,6L,1L,1L,1L,1L,3L,2L,3L,1L,1L,1L,1L,6L,3L,11L,1L,4L,2L,9L,3L,1L,15L,2L,2L,1L,3L,48L,3L,1L,2L,2L,15L,1L,3L,9L,2L,4L,1L,11L,3L,6L,1L,1L,1L,1L,3L,2L,3L,1L,1L,1L,1L,6L,3L,11L,1L,4L,2L,9L,3L,1L,15L,2L,2L,1L,3L,48L,3L,1L,2L,2L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040564Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040564.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040564Inst : IEnumerable<long>
{
public static readonly long[] Value=A040564.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040564.Bytes);
public long this[int i]=>Value[i];

public static A040564Inst Instance=new A040564Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040565
{
public static readonly long[] Value={ 24L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L,4L,2L,3L,48L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040565Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040565.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040565Inst : IEnumerable<long>
{
public static readonly long[] Value=A040565.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040565.Bytes);
public long this[int i]=>Value[i];

public static A040565Inst Instance=new A040565Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040566
{
public static readonly long[] Value={ 24L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L,48L,3L,4L,1L,1L,7L,1L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040566Inst : IEnumerable<long>
{
public static readonly long[] Value=A040566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040566.Bytes);
public long this[int i]=>Value[i];

public static A040566Inst Instance=new A040566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040567
{
public static readonly long[] Value={ 24L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L,3L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040567Inst : IEnumerable<long>
{
public static readonly long[] Value=A040567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040567.Bytes);
public long this[int i]=>Value[i];

public static A040567Inst Instance=new A040567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040568
{
public static readonly long[] Value={ 24L,2L,1L,5L,2L,2L,1L,1L,2L,2L,5L,1L,2L,48L,2L,1L,5L,2L,2L,1L,1L,2L,2L,5L,1L,2L,48L,2L,1L,5L,2L,2L,1L,1L,2L,2L,5L,1L,2L,48L,2L,1L,5L,2L,2L,1L,1L,2L,2L,5L,1L,2L,48L,2L,1L,5L,2L,2L,1L,1L,2L,2L,5L,1L,2L,48L,2L,1L,5L,2L,2L,1L,1L,2L,2L,5L,1L,2L,48L,2L,1L,5L,2L,2L,1L,1L,2L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040568Inst : IEnumerable<long>
{
public static readonly long[] Value=A040568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040568.Bytes);
public long this[int i]=>Value[i];

public static A040568Inst Instance=new A040568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040569
{
public static readonly long[] Value={ 24L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L,24L,5L,2L,1L,2L,48L,2L,1L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040569Inst : IEnumerable<long>
{
public static readonly long[] Value=A040569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040569.Bytes);
public long this[int i]=>Value[i];

public static A040569Inst Instance=new A040569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040570
{
public static readonly long[] Value={ 24L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L,48L,2L,1L,1L,4L,1L,4L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040570Inst : IEnumerable<long>
{
public static readonly long[] Value=A040570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040570.Bytes);
public long this[int i]=>Value[i];

public static A040570Inst Instance=new A040570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040571
{
public static readonly long[] Value={ 24L,2L,2L,2L,1L,1L,1L,6L,2L,1L,9L,12L,9L,1L,2L,6L,1L,1L,1L,2L,2L,2L,48L,2L,2L,2L,1L,1L,1L,6L,2L,1L,9L,12L,9L,1L,2L,6L,1L,1L,1L,2L,2L,2L,48L,2L,2L,2L,1L,1L,1L,6L,2L,1L,9L,12L,9L,1L,2L,6L,1L,1L,1L,2L,2L,2L,48L,2L,2L,2L,1L,1L,1L,6L,2L,1L,9L,12L,9L,1L,2L,6L,1L,1L,1L,2L,2L,2L,48L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040571Inst : IEnumerable<long>
{
public static readonly long[] Value=A040571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040571.Bytes);
public long this[int i]=>Value[i];

public static A040571Inst Instance=new A040571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040572
{
public static readonly long[] Value={ 24L,2L,3L,3L,1L,3L,1L,2L,11L,1L,6L,16L,6L,1L,11L,2L,1L,3L,1L,3L,3L,2L,48L,2L,3L,3L,1L,3L,1L,2L,11L,1L,6L,16L,6L,1L,11L,2L,1L,3L,1L,3L,3L,2L,48L,2L,3L,3L,1L,3L,1L,2L,11L,1L,6L,16L,6L,1L,11L,2L,1L,3L,1L,3L,3L,2L,48L,2L,3L,3L,1L,3L,1L,2L,11L,1L,6L,16L,6L,1L,11L,2L,1L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040572Inst : IEnumerable<long>
{
public static readonly long[] Value=A040572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040572.Bytes);
public long this[int i]=>Value[i];

public static A040572Inst Instance=new A040572Inst();

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

public static class A040589
{
public static readonly long[] Value={ 24L,1L,3L,1L,1L,9L,2L,1L,4L,3L,1L,1L,2L,24L,2L,1L,1L,3L,4L,1L,2L,9L,1L,1L,3L,1L,48L,1L,3L,1L,1L,9L,2L,1L,4L,3L,1L,1L,2L,24L,2L,1L,1L,3L,4L,1L,2L,9L,1L,1L,3L,1L,48L,1L,3L,1L,1L,9L,2L,1L,4L,3L,1L,1L,2L,24L,2L,1L,1L,3L,4L,1L,2L,9L,1L,1L,3L,1L,48L,1L,3L,1L,1L,9L,2L,1L,4L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040589Inst : IEnumerable<long>
{
public static readonly long[] Value=A040589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040589.Bytes);
public long this[int i]=>Value[i];

public static A040589Inst Instance=new A040589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040590
{
public static readonly long[] Value={ 24L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L,48L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040590Inst : IEnumerable<long>
{
public static readonly long[] Value=A040590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040590.Bytes);
public long this[int i]=>Value[i];

public static A040590Inst Instance=new A040590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040591
{
public static readonly long[] Value={ 24L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L,48L,1L,4L,1L,1L,6L,1L,1L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040591Inst : IEnumerable<long>
{
public static readonly long[] Value=A040591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040591.Bytes);
public long this[int i]=>Value[i];

public static A040591Inst Instance=new A040591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040592
{
public static readonly long[] Value={ 24L,1L,5L,4L,2L,1L,6L,2L,2L,6L,1L,2L,4L,5L,1L,48L,1L,5L,4L,2L,1L,6L,2L,2L,6L,1L,2L,4L,5L,1L,48L,1L,5L,4L,2L,1L,6L,2L,2L,6L,1L,2L,4L,5L,1L,48L,1L,5L,4L,2L,1L,6L,2L,2L,6L,1L,2L,4L,5L,1L,48L,1L,5L,4L,2L,1L,6L,2L,2L,6L,1L,2L,4L,5L,1L,48L,1L,5L,4L,2L,1L,6L,2L,2L,6L,1L,2L,4L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040592Inst : IEnumerable<long>
{
public static readonly long[] Value=A040592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040592.Bytes);
public long this[int i]=>Value[i];

public static A040592Inst Instance=new A040592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040593
{
public static readonly long[] Value={ 24L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L,8L,6L,1L,48L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040593Inst : IEnumerable<long>
{
public static readonly long[] Value=A040593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040593.Bytes);
public long this[int i]=>Value[i];

public static A040593Inst Instance=new A040593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040594
{
public static readonly long[] Value={ 24L,1L,7L,3L,5L,4L,1L,3L,1L,2L,1L,1L,9L,2L,1L,1L,1L,15L,1L,23L,1L,15L,1L,1L,1L,2L,9L,1L,1L,2L,1L,3L,1L,4L,5L,3L,7L,1L,48L,1L,7L,3L,5L,4L,1L,3L,1L,2L,1L,1L,9L,2L,1L,1L,1L,15L,1L,23L,1L,15L,1L,1L,1L,2L,9L,1L,1L,2L,1L,3L,1L,4L,5L,3L,7L,1L,48L,1L,7L,3L,5L,4L,1L,3L,1L,2L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040594Inst : IEnumerable<long>
{
public static readonly long[] Value=A040594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040594.Bytes);
public long this[int i]=>Value[i];

public static A040594Inst Instance=new A040594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040595
{
public static readonly long[] Value={ 24L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L,48L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040595Inst : IEnumerable<long>
{
public static readonly long[] Value=A040595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040595.Bytes);
public long this[int i]=>Value[i];

public static A040595Inst Instance=new A040595Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040596
{
public static readonly long[] Value={ 24L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L,2L,11L,1L,48L,1L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040596Inst : IEnumerable<long>
{
public static readonly long[] Value=A040596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040596.Bytes);
public long this[int i]=>Value[i];

public static A040596Inst Instance=new A040596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040597
{
public static readonly long[] Value={ 24L,1L,15L,1L,1L,1L,4L,1L,7L,2L,24L,2L,7L,1L,4L,1L,1L,1L,15L,1L,48L,1L,15L,1L,1L,1L,4L,1L,7L,2L,24L,2L,7L,1L,4L,1L,1L,1L,15L,1L,48L,1L,15L,1L,1L,1L,4L,1L,7L,2L,24L,2L,7L,1L,4L,1L,1L,1L,15L,1L,48L,1L,15L,1L,1L,1L,4L,1L,7L,2L,24L,2L,7L,1L,4L,1L,1L,1L,15L,1L,48L,1L,15L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040597Inst : IEnumerable<long>
{
public static readonly long[] Value=A040597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040597.Bytes);
public long this[int i]=>Value[i];

public static A040597Inst Instance=new A040597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040598
{
public static readonly long[] Value={ 24L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L,1L,48L,1L,23L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040598Inst : IEnumerable<long>
{
public static readonly long[] Value=A040598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040598.Bytes);
public long this[int i]=>Value[i];

public static A040598Inst Instance=new A040598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040599
{
public static readonly long[] Value={ 24L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L,1L,48L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040599Inst : IEnumerable<long>
{
public static readonly long[] Value=A040599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040599.Bytes);
public long this[int i]=>Value[i];

public static A040599Inst Instance=new A040599Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040600
{
public static readonly long[] Value={ 25L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040600Inst : IEnumerable<long>
{
public static readonly long[] Value=A040600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040600.Bytes);
public long this[int i]=>Value[i];

public static A040600Inst Instance=new A040600Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040601
{
public static readonly long[] Value={ 25L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L,25L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040601Inst : IEnumerable<long>
{
public static readonly long[] Value=A040601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040601.Bytes);
public long this[int i]=>Value[i];

public static A040601Inst Instance=new A040601Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040602
{
public static readonly long[] Value={ 25L,16L,1L,2L,5L,4L,2L,1L,2L,2L,3L,1L,3L,12L,3L,1L,3L,2L,2L,1L,2L,4L,5L,2L,1L,16L,50L,16L,1L,2L,5L,4L,2L,1L,2L,2L,3L,1L,3L,12L,3L,1L,3L,2L,2L,1L,2L,4L,5L,2L,1L,16L,50L,16L,1L,2L,5L,4L,2L,1L,2L,2L,3L,1L,3L,12L,3L,1L,3L,2L,2L,1L,2L,4L,5L,2L,1L,16L,50L,16L,1L,2L,5L,4L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040602Inst : IEnumerable<long>
{
public static readonly long[] Value=A040602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040602.Bytes);
public long this[int i]=>Value[i];

public static A040602Inst Instance=new A040602Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040603
{
public static readonly long[] Value={ 25L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L,1L,1L,12L,50L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040603Inst : IEnumerable<long>
{
public static readonly long[] Value=A040603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040603.Bytes);
public long this[int i]=>Value[i];

public static A040603Inst Instance=new A040603Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040604
{
public static readonly long[] Value={ 25L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L,10L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040604Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040604.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040604Inst : IEnumerable<long>
{
public static readonly long[] Value=A040604.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040604.Bytes);
public long this[int i]=>Value[i];

public static A040604Inst Instance=new A040604Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040605
{
public static readonly long[] Value={ 25L,8L,2L,1L,4L,1L,9L,4L,2L,6L,1L,2L,1L,2L,1L,1L,1L,1L,4L,2L,2L,2L,1L,16L,25L,16L,1L,2L,2L,2L,4L,1L,1L,1L,1L,2L,1L,2L,1L,6L,2L,4L,9L,1L,4L,1L,2L,8L,50L,8L,2L,1L,4L,1L,9L,4L,2L,6L,1L,2L,1L,2L,1L,1L,1L,1L,4L,2L,2L,2L,1L,16L,25L,16L,1L,2L,2L,2L,4L,1L,1L,1L,1L,2L,1L,2L,1L,6L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040605Inst : IEnumerable<long>
{
public static readonly long[] Value=A040605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040605.Bytes);
public long this[int i]=>Value[i];

public static A040605Inst Instance=new A040605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040606
{
public static readonly long[] Value={ 25L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L,50L,7L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040606Inst : IEnumerable<long>
{
public static readonly long[] Value=A040606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040606.Bytes);
public long this[int i]=>Value[i];

public static A040606Inst Instance=new A040606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040607
{
public static readonly long[] Value={ 25L,6L,3L,1L,2L,2L,1L,1L,2L,16L,2L,1L,1L,2L,2L,1L,3L,6L,50L,6L,3L,1L,2L,2L,1L,1L,2L,16L,2L,1L,1L,2L,2L,1L,3L,6L,50L,6L,3L,1L,2L,2L,1L,1L,2L,16L,2L,1L,1L,2L,2L,1L,3L,6L,50L,6L,3L,1L,2L,2L,1L,1L,2L,16L,2L,1L,1L,2L,2L,1L,3L,6L,50L,6L,3L,1L,2L,2L,1L,1L,2L,16L,2L,1L,1L,2L,2L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040607Inst : IEnumerable<long>
{
public static readonly long[] Value=A040607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040607.Bytes);
public long this[int i]=>Value[i];

public static A040607Inst Instance=new A040607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040608
{
public static readonly long[] Value={ 25L,5L,1L,1L,2L,1L,4L,3L,6L,1L,7L,1L,1L,7L,1L,6L,3L,4L,1L,2L,1L,1L,5L,50L,5L,1L,1L,2L,1L,4L,3L,6L,1L,7L,1L,1L,7L,1L,6L,3L,4L,1L,2L,1L,1L,5L,50L,5L,1L,1L,2L,1L,4L,3L,6L,1L,7L,1L,1L,7L,1L,6L,3L,4L,1L,2L,1L,1L,5L,50L,5L,1L,1L,2L,1L,4L,3L,6L,1L,7L,1L,1L,7L,1L,6L,3L,4L,1L,2L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040608Inst : IEnumerable<long>
{
public static readonly long[] Value=A040608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040608.Bytes);
public long this[int i]=>Value[i];

public static A040608Inst Instance=new A040608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040609
{
public static readonly long[] Value={ 25L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L,5L,50L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040609Inst : IEnumerable<long>
{
public static readonly long[] Value=A040609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040609.Bytes);
public long this[int i]=>Value[i];

public static A040609Inst Instance=new A040609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040610
{
public static readonly long[] Value={ 25L,4L,1L,1L,3L,3L,12L,3L,3L,1L,1L,4L,50L,4L,1L,1L,3L,3L,12L,3L,3L,1L,1L,4L,50L,4L,1L,1L,3L,3L,12L,3L,3L,1L,1L,4L,50L,4L,1L,1L,3L,3L,12L,3L,3L,1L,1L,4L,50L,4L,1L,1L,3L,3L,12L,3L,3L,1L,1L,4L,50L,4L,1L,1L,3L,3L,12L,3L,3L,1L,1L,4L,50L,4L,1L,1L,3L,3L,12L,3L,3L,1L,1L,4L,50L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040610Inst : IEnumerable<long>
{
public static readonly long[] Value=A040610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040610.Bytes);
public long this[int i]=>Value[i];

public static A040610Inst Instance=new A040610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040611
{
public static readonly long[] Value={ 25L,4L,5L,2L,1L,3L,1L,1L,12L,16L,1L,2L,1L,16L,12L,1L,1L,3L,1L,2L,5L,4L,50L,4L,5L,2L,1L,3L,1L,1L,12L,16L,1L,2L,1L,16L,12L,1L,1L,3L,1L,2L,5L,4L,50L,4L,5L,2L,1L,3L,1L,1L,12L,16L,1L,2L,1L,16L,12L,1L,1L,3L,1L,2L,5L,4L,50L,4L,5L,2L,1L,3L,1L,1L,12L,16L,1L,2L,1L,16L,12L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040611Inst : IEnumerable<long>
{
public static readonly long[] Value=A040611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040611.Bytes);
public long this[int i]=>Value[i];

public static A040611Inst Instance=new A040611Inst();

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