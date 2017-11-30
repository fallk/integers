using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A196757
{
public static readonly long[] Value={ 4L,1L,4L,1L,5L,9L,9L,3L,3L,2L,3L,1L,8L,7L,2L,9L,7L,5L,5L,1L,3L,7L,5L,7L,8L,9L,6L,3L,2L,0L,4L,4L,2L,1L,1L,2L,3L,0L,9L,6L,7L,5L,1L,8L,1L,1L,8L,3L,7L,6L,6L,2L,0L,1L,2L,3L,4L,3L,7L,5L,4L,9L,7L,4L,3L,7L,0L,1L,9L,0L,4L,2L,9L,3L,4L,9L,2L,2L,5L,1L,8L,8L,3L,5L,3L,0L,9L,1L,0L,1L,3L,0L,2L,6L,6L,5L,1L,9L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196757Inst : IEnumerable<long>
{
public static readonly long[] Value=A196757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196757.Bytes);
public long this[int i]=>Value[i];

public static A196757Inst Instance=new A196757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196758
{
public static readonly long[] Value={ 5L,4L,9L,5L,3L,9L,3L,9L,9L,3L,5L,5L,1L,5L,3L,4L,1L,1L,5L,2L,1L,9L,3L,8L,9L,8L,7L,3L,2L,5L,3L,8L,3L,9L,3L,8L,0L,9L,0L,0L,3L,3L,7L,2L,8L,1L,1L,5L,2L,8L,5L,6L,2L,7L,9L,9L,1L,4L,1L,4L,4L,8L,6L,9L,2L,6L,4L,3L,3L,4L,8L,0L,3L,1L,1L,8L,0L,1L,2L,5L,1L,7L,1L,0L,9L,1L,7L,7L,2L,2L,1L,6L,8L,3L,7L,7L,9L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196758Inst : IEnumerable<long>
{
public static readonly long[] Value=A196758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196758.Bytes);
public long this[int i]=>Value[i];

public static A196758Inst Instance=new A196758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196759
{
public static readonly long[] Value={ 2L,4L,2L,9L,6L,2L,6L,8L,5L,0L,9L,5L,0L,3L,4L,0L,8L,6L,9L,1L,2L,6L,1L,1L,5L,8L,0L,7L,9L,5L,1L,2L,3L,0L,7L,3L,0L,1L,2L,2L,6L,9L,4L,4L,5L,7L,7L,8L,0L,1L,5L,6L,2L,1L,4L,8L,8L,6L,0L,3L,9L,0L,7L,9L,6L,1L,2L,1L,9L,6L,3L,4L,1L,9L,9L,6L,2L,3L,0L,1L,4L,0L,8L,6L,3L,3L,5L,1L,0L,5L,3L,7L,7L,4L,7L,9L,2L,5L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196759Inst : IEnumerable<long>
{
public static readonly long[] Value=A196759.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196759.Bytes);
public long this[int i]=>Value[i];

public static A196759Inst Instance=new A196759Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196760
{
public static readonly long[] Value={ 6L,5L,9L,1L,4L,6L,7L,8L,0L,7L,2L,7L,6L,4L,5L,0L,4L,0L,8L,6L,8L,9L,1L,9L,3L,5L,3L,6L,4L,5L,6L,4L,7L,7L,3L,6L,6L,6L,0L,6L,9L,5L,3L,6L,2L,0L,3L,2L,8L,7L,0L,8L,9L,1L,3L,0L,8L,6L,4L,5L,7L,2L,7L,8L,2L,4L,9L,4L,9L,9L,7L,0L,6L,6L,6L,9L,6L,3L,3L,5L,0L,8L,4L,7L,8L,9L,6L,7L,6L,7L,2L,2L,6L,7L,5L,4L,6L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196760Inst : IEnumerable<long>
{
public static readonly long[] Value=A196760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196760.Bytes);
public long this[int i]=>Value[i];

public static A196760Inst Instance=new A196760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196761
{
public static readonly long[] Value={ 6L,7L,4L,4L,1L,6L,8L,3L,5L,3L,2L,5L,9L,1L,4L,8L,5L,5L,5L,8L,5L,5L,2L,8L,1L,1L,7L,3L,0L,1L,5L,3L,2L,5L,9L,4L,4L,0L,2L,6L,8L,7L,9L,9L,7L,1L,4L,1L,3L,4L,0L,7L,9L,1L,2L,9L,6L,2L,3L,6L,7L,5L,1L,2L,6L,6L,8L,7L,8L,6L,9L,0L,0L,1L,9L,5L,5L,7L,3L,4L,1L,7L,3L,9L,0L,9L,4L,6L,9L,1L,2L,7L,1L,6L,1L,6L,5L,4L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196761Inst : IEnumerable<long>
{
public static readonly long[] Value=A196761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196761.Bytes);
public long this[int i]=>Value[i];

public static A196761Inst Instance=new A196761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196762
{
public static readonly long[] Value={ 6L,9L,0L,1L,4L,1L,2L,6L,0L,9L,0L,2L,1L,3L,0L,4L,2L,9L,3L,2L,3L,8L,7L,3L,2L,3L,1L,3L,6L,3L,9L,9L,2L,6L,5L,5L,1L,6L,5L,9L,2L,0L,1L,1L,5L,3L,5L,1L,3L,2L,7L,6L,8L,7L,7L,7L,3L,6L,7L,4L,0L,1L,2L,3L,7L,2L,4L,3L,4L,8L,0L,2L,1L,1L,1L,0L,8L,5L,5L,9L,4L,1L,2L,0L,7L,0L,1L,5L,5L,5L,4L,3L,3L,3L,9L,0L,8L,4L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196762Inst : IEnumerable<long>
{
public static readonly long[] Value=A196762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196762.Bytes);
public long this[int i]=>Value[i];

public static A196762Inst Instance=new A196762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196763
{
public static readonly long[] Value={ 7L,0L,6L,8L,8L,9L,1L,4L,0L,3L,3L,9L,5L,0L,6L,6L,8L,0L,0L,6L,8L,7L,5L,9L,9L,5L,6L,1L,9L,1L,6L,7L,6L,2L,0L,4L,2L,7L,1L,5L,0L,4L,5L,1L,0L,1L,7L,0L,0L,5L,9L,5L,1L,7L,8L,7L,8L,0L,8L,5L,5L,2L,2L,9L,2L,2L,7L,5L,8L,0L,2L,5L,6L,0L,3L,5L,9L,4L,4L,1L,4L,9L,2L,2L,0L,8L,7L,2L,9L,7L,6L,5L,7L,9L,7L,9L,2L,8L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196763Inst : IEnumerable<long>
{
public static readonly long[] Value=A196763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196763.Bytes);
public long this[int i]=>Value[i];

public static A196763Inst Instance=new A196763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196764
{
public static readonly long[] Value={ 7L,2L,5L,6L,6L,3L,2L,9L,3L,6L,6L,2L,8L,3L,9L,9L,8L,6L,4L,3L,1L,3L,5L,5L,6L,1L,0L,0L,8L,6L,6L,9L,5L,7L,1L,2L,9L,1L,9L,4L,7L,1L,7L,0L,0L,4L,8L,3L,9L,7L,4L,2L,5L,3L,9L,6L,5L,8L,2L,0L,2L,5L,0L,8L,7L,7L,0L,8L,8L,9L,5L,7L,4L,1L,2L,5L,2L,7L,0L,7L,3L,9L,7L,1L,4L,4L,7L,1L,1L,7L,3L,4L,7L,2L,2L,2L,6L,3L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196764Inst : IEnumerable<long>
{
public static readonly long[] Value=A196764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196764.Bytes);
public long this[int i]=>Value[i];

public static A196764Inst Instance=new A196764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196765
{
public static readonly long[] Value={ 1L,8L,1L,9L,7L,0L,5L,7L,4L,1L,1L,5L,9L,6L,5L,3L,0L,4L,6L,2L,0L,6L,9L,5L,7L,6L,8L,0L,3L,7L,5L,5L,2L,8L,1L,4L,5L,6L,1L,6L,5L,2L,2L,4L,7L,8L,4L,4L,1L,6L,3L,4L,0L,3L,6L,1L,5L,1L,2L,9L,5L,5L,0L,7L,3L,3L,1L,4L,4L,0L,0L,1L,6L,7L,6L,0L,3L,3L,9L,6L,1L,7L,8L,6L,5L,6L,1L,9L,5L,0L,7L,4L,4L,4L,8L,1L,5L,2L,6L,6L,0L,5L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196765Inst : IEnumerable<long>
{
public static readonly long[] Value=A196765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196765.Bytes);
public long this[int i]=>Value[i];

public static A196765Inst Instance=new A196765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196766
{
public static readonly long[] Value={ 4L,4L,2L,1L,2L,0L,5L,9L,2L,9L,5L,4L,9L,9L,8L,3L,9L,1L,3L,3L,5L,6L,1L,6L,2L,4L,4L,0L,5L,0L,4L,7L,6L,1L,3L,6L,1L,8L,6L,9L,0L,7L,0L,8L,6L,1L,2L,8L,6L,1L,0L,1L,5L,2L,9L,5L,8L,7L,9L,4L,3L,9L,1L,1L,9L,4L,5L,6L,6L,6L,5L,7L,9L,4L,5L,8L,7L,2L,6L,2L,5L,7L,9L,6L,8L,0L,2L,6L,6L,6L,0L,0L,1L,7L,6L,8L,9L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196766Inst : IEnumerable<long>
{
public static readonly long[] Value=A196766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196766.Bytes);
public long this[int i]=>Value[i];

public static A196766Inst Instance=new A196766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196767
{
public static readonly long[] Value={ 2L,0L,7L,3L,9L,3L,2L,8L,0L,9L,0L,9L,1L,2L,1L,4L,9L,0L,1L,1L,6L,7L,7L,7L,6L,2L,9L,7L,7L,9L,9L,3L,6L,0L,0L,6L,7L,9L,4L,6L,2L,1L,9L,5L,3L,1L,5L,2L,8L,5L,3L,0L,5L,4L,4L,6L,7L,9L,2L,9L,5L,2L,6L,7L,8L,5L,7L,8L,6L,8L,5L,6L,8L,8L,8L,6L,8L,7L,0L,2L,3L,2L,9L,9L,2L,8L,2L,1L,8L,4L,1L,3L,0L,6L,9L,9L,4L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196767Inst : IEnumerable<long>
{
public static readonly long[] Value=A196767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196767.Bytes);
public long this[int i]=>Value[i];

public static A196767Inst Instance=new A196767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196768
{
public static readonly long[] Value={ 1L,6L,8L,3L,3L,0L,5L,5L,8L,6L,7L,0L,8L,8L,9L,6L,1L,4L,5L,4L,3L,7L,3L,6L,1L,7L,5L,8L,9L,9L,4L,8L,5L,5L,6L,3L,5L,4L,5L,1L,3L,9L,4L,8L,6L,6L,0L,4L,2L,0L,4L,7L,1L,7L,2L,7L,3L,3L,8L,7L,6L,5L,3L,2L,7L,3L,2L,9L,2L,9L,6L,6L,5L,6L,0L,6L,5L,7L,1L,5L,8L,2L,3L,9L,6L,4L,2L,9L,2L,5L,4L,4L,5L,0L,5L,6L,9L,2L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196768Inst : IEnumerable<long>
{
public static readonly long[] Value=A196768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196768.Bytes);
public long this[int i]=>Value[i];

public static A196768Inst Instance=new A196768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196769
{
public static readonly long[] Value={ 1L,5L,0L,9L,5L,0L,6L,8L,3L,2L,2L,2L,4L,4L,7L,2L,8L,8L,5L,5L,6L,5L,3L,2L,6L,2L,2L,0L,4L,3L,7L,7L,6L,8L,5L,0L,5L,5L,3L,2L,8L,8L,0L,8L,1L,7L,0L,6L,6L,7L,1L,9L,6L,4L,6L,6L,6L,7L,2L,3L,7L,1L,0L,6L,1L,3L,4L,3L,0L,5L,4L,2L,1L,6L,9L,1L,4L,0L,3L,4L,8L,1L,5L,9L,4L,3L,3L,3L,4L,5L,5L,5L,4L,1L,1L,9L,2L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196769Inst : IEnumerable<long>
{
public static readonly long[] Value=A196769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196769.Bytes);
public long this[int i]=>Value[i];

public static A196769Inst Instance=new A196769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196770
{
public static readonly long[] Value={ 1L,4L,1L,3L,9L,2L,2L,5L,4L,0L,9L,0L,9L,2L,9L,6L,7L,4L,0L,4L,2L,4L,4L,5L,3L,3L,3L,3L,0L,3L,6L,0L,3L,3L,1L,1L,3L,0L,4L,0L,9L,0L,1L,9L,1L,5L,7L,1L,0L,0L,0L,8L,3L,1L,5L,0L,5L,5L,0L,3L,1L,6L,0L,0L,5L,8L,0L,6L,3L,7L,8L,3L,6L,7L,5L,4L,0L,2L,7L,3L,0L,1L,2L,4L,9L,0L,2L,5L,7L,2L,8L,1L,9L,1L,2L,2L,6L,1L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196770Inst : IEnumerable<long>
{
public static readonly long[] Value=A196770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196770.Bytes);
public long this[int i]=>Value[i];

public static A196770Inst Instance=new A196770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196771
{
public static readonly long[] Value={ 1L,3L,5L,4L,2L,8L,7L,2L,1L,4L,1L,5L,7L,7L,2L,1L,4L,1L,7L,8L,3L,0L,6L,3L,7L,1L,6L,1L,6L,3L,7L,5L,3L,0L,6L,8L,5L,9L,7L,7L,2L,6L,3L,2L,5L,7L,6L,7L,5L,5L,1L,4L,7L,7L,6L,4L,6L,9L,9L,2L,1L,1L,6L,1L,2L,5L,1L,9L,2L,2L,3L,4L,1L,6L,4L,3L,7L,6L,0L,3L,8L,8L,1L,9L,0L,8L,5L,8L,3L,0L,1L,8L,6L,4L,0L,3L,5L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196771Inst : IEnumerable<long>
{
public static readonly long[] Value=A196771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196771.Bytes);
public long this[int i]=>Value[i];

public static A196771Inst Instance=new A196771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196772
{
public static readonly long[] Value={ 9L,6L,5L,0L,1L,6L,1L,0L,9L,7L,7L,3L,3L,4L,2L,9L,1L,0L,0L,8L,2L,9L,0L,4L,1L,2L,5L,8L,8L,0L,0L,5L,2L,6L,7L,1L,0L,5L,0L,4L,6L,6L,7L,9L,6L,5L,7L,3L,4L,0L,4L,5L,0L,4L,7L,0L,2L,3L,0L,5L,7L,5L,6L,4L,1L,8L,5L,8L,9L,6L,1L,6L,9L,8L,6L,0L,9L,5L,7L,6L,9L,1L,9L,1L,5L,4L,0L,0L,2L,8L,8L,5L,2L,1L,7L,9L,4L,1L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196772Inst : IEnumerable<long>
{
public static readonly long[] Value=A196772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196772.Bytes);
public long this[int i]=>Value[i];

public static A196772Inst Instance=new A196772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196773
{
public static readonly long[] Value={ 1L,8L,6L,3L,0L,4L,5L,3L,0L,8L,2L,4L,8L,6L,9L,9L,2L,2L,4L,0L,6L,9L,7L,9L,3L,2L,0L,4L,6L,9L,3L,6L,3L,5L,4L,1L,8L,3L,3L,4L,4L,2L,1L,0L,0L,0L,4L,6L,3L,5L,7L,8L,9L,5L,6L,7L,1L,4L,4L,9L,5L,9L,1L,8L,9L,2L,6L,4L,5L,2L,7L,4L,8L,9L,3L,9L,5L,0L,4L,7L,6L,3L,9L,3L,5L,3L,0L,7L,4L,8L,8L,7L,1L,0L,0L,8L,9L,1L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196773Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196773.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196773Inst : IEnumerable<long>
{
public static readonly long[] Value=A196773.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196773.Bytes);
public long this[int i]=>Value[i];

public static A196773Inst Instance=new A196773Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196774
{
public static readonly long[] Value={ 4L,2L,0L,8L,4L,2L,7L,5L,2L,6L,5L,6L,6L,7L,4L,1L,9L,5L,1L,6L,0L,6L,5L,3L,1L,2L,5L,0L,6L,9L,3L,2L,7L,8L,2L,4L,9L,0L,7L,0L,4L,2L,6L,0L,6L,5L,4L,9L,7L,3L,8L,9L,8L,9L,0L,5L,0L,2L,0L,0L,6L,4L,2L,0L,9L,6L,9L,4L,9L,8L,0L,6L,5L,0L,6L,4L,7L,9L,2L,4L,4L,8L,6L,7L,5L,2L,7L,9L,8L,5L,5L,9L,2L,8L,9L,1L,2L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196774Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196774.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196774Inst : IEnumerable<long>
{
public static readonly long[] Value=A196774.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196774.Bytes);
public long this[int i]=>Value[i];

public static A196774Inst Instance=new A196774Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196775
{
public static readonly long[] Value={ 2L,8L,8L,1L,0L,6L,5L,7L,2L,8L,3L,1L,2L,9L,8L,9L,6L,7L,2L,7L,3L,9L,8L,9L,5L,9L,9L,4L,5L,0L,8L,3L,9L,2L,5L,3L,4L,5L,5L,0L,0L,3L,4L,9L,2L,3L,1L,6L,1L,2L,3L,0L,3L,1L,5L,7L,6L,3L,1L,8L,7L,8L,6L,9L,3L,8L,2L,3L,1L,4L,4L,3L,9L,3L,5L,1L,0L,4L,3L,4L,2L,5L,5L,7L,7L,1L,0L,3L,5L,1L,5L,6L,7L,7L,7L,5L,6L,8L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196775Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196775.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196775Inst : IEnumerable<long>
{
public static readonly long[] Value=A196775.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196775.Bytes);
public long this[int i]=>Value[i];

public static A196775Inst Instance=new A196775Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196776
{
public static readonly long[] Value={ 1L,0L,2L,1L,0L,6L,0L,8L,0L,24L,1L,0L,60L,0L,120L,0L,32L,0L,480L,0L,720L,1L,0L,546L,0L,4200L,0L,5040L,0L,128L,0L,8064L,0L,40320L,0L,40320L,1L,0L,4920L,0L,115920L,0L,423360L,0L,362880L,0L,512L,0L,130560L,0L,1693440L,0L,4838400L,0L,3628800L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196776Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196776.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196776Inst : IEnumerable<long>
{
public static readonly long[] Value=A196776.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196776.Bytes);
public long this[int i]=>Value[i];

public static A196776Inst Instance=new A196776Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196777
{
public static readonly long[] Value={ 0L,1L,0L,1L,0L,2L,0L,1L,0L,5L,0L,2L,0L,0L,0L,1L,0L,2L,0L,2L,0L,0L,0L,2L,0L,13L,0L,0L,0L,0L,0L,1L,0L,17L,0L,2L,0L,0L,0L,2L,0L,4L,0L,22L,0L,0L,0L,2L,0L,25L,0L,0L,0L,2L,0L,28L,0L,29L,0L,4L,0L,0L,0L,1L,0L,0L,0L,17L,0L,0L,0L,2L,0L,37L,0L,38L,0L,0L,0L,2L,0L,41L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196777Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196777.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196777Inst : IEnumerable<long>
{
public static readonly long[] Value=A196777.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196777.Bytes);
public long this[int i]=>Value[i];

public static A196777Inst Instance=new A196777Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196778
{
public static readonly long[] Value={ 1L,3L,5L,6L,7L,7L,9L,8L,9L,12L,7L,9L,4L,4L,8L,11L,6L,11L,7L,8L,14L,7L,8L,11L,6L,10L,9L,8L,8L,11L,6L,10L,13L,7L,6L,9L,10L,8L,8L,10L,5L,10L,15L,6L,11L,9L,14L,7L,8L,16L,12L,10L,5L,10L,9L,8L,10L,8L,7L,10L,11L,13L,12L,6L,12L,9L,4L,10L,12L,13L,8L,14L,7L,2L,13L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196778Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196778.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196778Inst : IEnumerable<long>
{
public static readonly long[] Value=A196778.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196778.Bytes);
public long this[int i]=>Value[i];

public static A196778Inst Instance=new A196778Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196779
{
public static readonly long[] Value={ 1147L,113L,113L,400L,866L,131L,399L,32L,26L,29L,23L,58L,77L,21L,42L,3L,817L,4L,2L,37L,80L,29L,181L,39L,120L,382L,76L,5L,29L,20L,48L,19L,36L,7L,43L,7L,62L,22L,7L,43L,5L,17L,23L,44L,52L,137L,103L,2L,5L,49L,31L,10L,30L,5L,25L,25L,49L,10L,72L,50L,13L,4L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196779Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196779.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196779Inst : IEnumerable<long>
{
public static readonly long[] Value=A196779.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196779.Bytes);
public long this[int i]=>Value[i];

public static A196779Inst Instance=new A196779Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196780
{
public static readonly BigInteger[] Value={ 1L,1L,17L,145L,6137L,404589L,65282256L,22331701461L,16774271567427L,27461523421500033L,BigInteger.Parse("98038364298327333400") };
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
public class A196780Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196780.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196780Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196780.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196780.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196780Inst Instance=new A196780Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196781
{
public static readonly long[] Value={ 1L,3L,17L,39L,135L,427L,1351L,4319L,13715L,43607L,138727L,441175L,1403139L,4462583L,14192759L,45138911L,143560379L,456581095L,1452116295L,4618328471L,14688188867L,46714497719L,148571365447L,472518206415L,1502802742427L,4779532410183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196781Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196781.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196781Inst : IEnumerable<long>
{
public static readonly long[] Value=A196781.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196781.Bytes);
public long this[int i]=>Value[i];

public static A196781Inst Instance=new A196781Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196782
{
public static readonly long[] Value={ 1L,7L,39L,145L,797L,3569L,17175L,81389L,385231L,1829101L,8668831L,41113007L,194955001L,924449179L,4383753391L,20787435021L,98573175383L,467429309303L,2216527199343L,10510668481659L,49841089379745L,236344089239897L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196782Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196782.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196782Inst : IEnumerable<long>
{
public static readonly long[] Value=A196782.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196782.Bytes);
public long this[int i]=>Value[i];

public static A196782Inst Instance=new A196782Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196783
{
public static readonly long[] Value={ 1L,17L,135L,797L,6137L,40749L,289761L,2025511L,14215709L,99646153L,698024127L,4892934573L,34291191221L,240334383531L,1684405081345L,11805196899669L,82737396174443L,579869401345235L,4064046980256775L,28483094044958233L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196783Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196783.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196783Inst : IEnumerable<long>
{
public static readonly long[] Value=A196783.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196783.Bytes);
public long this[int i]=>Value[i];

public static A196783Inst Instance=new A196783Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196784
{
public static readonly long[] Value={ 1L,41L,427L,3569L,40749L,404589L,4216301L,43457133L,448071435L,4621262139L,47666356469L,491646083197L,5070868714285L,52302472643609L,539455130405867L,5564052932385685L,57388767910023213L,591918940819313175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196784Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196784.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196784Inst : IEnumerable<long>
{
public static readonly long[] Value=A196784.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196784.Bytes);
public long this[int i]=>Value[i];

public static A196784Inst Instance=new A196784Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196785
{
public static readonly long[] Value={ 1L,99L,1351L,17175L,289761L,4216301L,65282256L,993629439L,15177736646L,231779144185L,3537181684727L,53999808742021L,824352446553481L,12584320094861238L,192108754190909442L,2932675433265799165L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196785Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196785.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196785Inst : IEnumerable<long>
{
public static readonly long[] Value=A196785.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196785.Bytes);
public long this[int i]=>Value[i];

public static A196785Inst Instance=new A196785Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196786
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,7L,17L,7L,1L,1L,17L,39L,39L,17L,1L,1L,41L,135L,145L,135L,41L,1L,1L,99L,427L,797L,797L,427L,99L,1L,1L,239L,1351L,3569L,6137L,3569L,1351L,239L,1L,1L,577L,4319L,17175L,40749L,40749L,17175L,4319L,577L,1L,1L,1393L,13715L,81389L,289761L,404589L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196786Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196786.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196786Inst : IEnumerable<long>
{
public static readonly long[] Value=A196786.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196786.Bytes);
public long this[int i]=>Value[i];

public static A196786Inst Instance=new A196786Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196787
{
public static readonly long[] Value={ 1L,1L,1L,3L,6L,12L,24L,46L,87L,163L,303L,561L,1036L,1910L,3518L,6476L,11917L,21925L,40333L,74191L,136466L,251008L,461684L,849178L,1561891L,2872775L,5283867L,9718557L,1783L,2341247774L,4306226036L,7920384528L,14567858374L,26794468975L,49282711915L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196787Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196787.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196787Inst : IEnumerable<long>
{
public static readonly long[] Value=A196787.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196787.Bytes);
public long this[int i]=>Value[i];

public static A196787Inst Instance=new A196787Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196788
{
public static readonly long[] Value={ 1L,1805L,133L,2L,3L,4L,5L,13L,6L,9L,8L,10L,19L,16L,32L,24L,74L,30L,18L,60L,168L,20L,42L,90L,180L,210L,186L,408L,144L,1020L,1050L,900L,2520L,3348L,2850L,5520L,3390L,774L,5760L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196788Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196788.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196788Inst : IEnumerable<long>
{
public static readonly long[] Value=A196788.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196788.Bytes);
public long this[int i]=>Value[i];

public static A196788Inst Instance=new A196788Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196789
{
public static readonly long[] Value={ 1L,66L,1001L,8008L,43758L,184756L,646646L,1961256L,5311735L,13123110L,30045015L,64512240L,131128140L,254186856L,472733756L,847660528L,1471442973L,2481256778L,4076350421L,6540715896L,10272278170L,15820024220L,23930713170L,35607051480L,52179482355L,75394027566L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196789Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196789.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196789Inst : IEnumerable<long>
{
public static readonly long[] Value=A196789.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196789.Bytes);
public long this[int i]=>Value[i];

public static A196789Inst Instance=new A196789Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196790
{
public static readonly long[] Value={ 11L,286L,3003L,19448L,92378L,352716L,1144066L,3268760L,8436285L,20030010L,44352165L,92561040L,183579396L,348330136L,635745396L,1121099408L,1917334783L,3190187286L,5178066751L,8217822536L,12777711870L,19499099620L,29248649430L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196790Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196790.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196790Inst : IEnumerable<long>
{
public static readonly long[] Value=A196790.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196790.Bytes);
public long this[int i]=>Value[i];

public static A196790Inst Instance=new A196790Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196791
{
public static readonly long[] Value={ 1L,2L,14L,158L,1886L,22622L,271454L,3257438L,39089246L,469070942L,5628851294L,67546215518L,810554586206L,9726655034462L,116719860413534L,1400638324962398L,16807659899548766L,201691918794585182L,2420303025535022174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196791Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196791.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196791Inst : IEnumerable<long>
{
public static readonly long[] Value=A196791.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196791.Bytes);
public long this[int i]=>Value[i];

public static A196791Inst Instance=new A196791Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196792
{
public static readonly ulong[] Value={ 1L,2L,15L,184L,2381L,30942L,402235L,5229044L,67977561L,883708282L,11488207655L,149346699504L,1941507093541L,25239592216022L,328114698808275L,4265491084507564L,55451384098598321L,720867993281778162L,9371283912663116095UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196792Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196792.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196792Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A196792.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196792.Bytes);
public ulong this[int i]=>Value[i];

public static A196792Inst Instance=new A196792Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196793
{
public static readonly BigInteger[] Value={ 1L,2L,7L,44L,401L,4682L,66431L,1111112L,21435889L,469070942L,11488207655L,311505013052L,9267595563617L,300239975158034L,10523614159962559L,396861212733968144L,16024522975978953761UL,BigInteger.Parse("689852631578947368422"),BigInteger.Parse("31544039619835776489479") };
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
public class A196793Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196793.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196793Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196793.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196793.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196793Inst Instance=new A196793Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196794
{
public static readonly BigInteger[] Value={ 1L,3L,13L,69L,425L,2953L,22701L,190445L,1725777L,16757649L,173244629L,1896821941L,21897166137L,265525063001L,3371067773565L,44683137692157L,616811052816545L,8847765111928609L,131622808197394341L,2027097866771329349L,BigInteger.Parse("32267707989783480201"),BigInteger.Parse("530125689222591861993") };
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
public class A196794Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196794.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196794Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196794.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196794.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196794Inst Instance=new A196794Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196795
{
public static readonly BigInteger[] Value={ 1L,4L,22L,145L,1096L,9259L,85924L,865183L,9364864L,108173827L,1325589676L,17149360111L,233271228880L,3324545097475L,49493784653644L,767665750130839L,12376226335249024L,206967901014192643L,3583561993192959436L,BigInteger.Parse("64136093489935863583"),BigInteger.Parse("1184711492540805987856") };
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
public class A196795Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196795.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196795Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196795.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196795.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196795Inst Instance=new A196795Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196796
{
public static readonly BigInteger[] Value={ 1L,7L,120L,7407L,1516652L,1029024216L,2336509457978L,17524876527067107L,BigInteger.Parse("436288315960458288785") };
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
public class A196796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196796Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196796.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196796.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196796Inst Instance=new A196796Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196797
{
public static readonly long[] Value={ 2L,20L,120L,698L,4078L,23920L,140348L,821284L,4813216L,28205816L,165271574L,968402976L,5674170654L,33247932210L,194815836754L,1141514840080L,6688663128942L,39191982301068L,229644142997092L,1345591934306596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196797Inst : IEnumerable<long>
{
public static readonly long[] Value=A196797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196797.Bytes);
public long this[int i]=>Value[i];

public static A196797Inst Instance=new A196797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196798
{
public static readonly long[] Value={ 3L,65L,698L,7407L,79003L,834632L,8882811L,94530039L,1004745630L,10681187595L,113575660599L,1207591084696L,12839042473735L,136508257135233L,1451400786295740L,15431631832722251L,164072914020649465L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196798Inst : IEnumerable<long>
{
public static readonly long[] Value=A196798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196798.Bytes);
public long this[int i]=>Value[i];

public static A196798Inst Instance=new A196798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196799
{
public static readonly BigInteger[] Value={ 5L,203L,4078L,79003L,1516652L,29239326L,567312297L,10969537457L,212128886217L,4104645843820L,79400771205004L,1535972443663444L,29714060354536788L,574817774193408199L,11119837928249291579UL,BigInteger.Parse("215114059044446417887") };
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
public class A196799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196799Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196799.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196799.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196799Inst Instance=new A196799Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196800
{
public static readonly BigInteger[] Value={ 8L,648L,23920L,834632L,29239326L,1029024216L,36350586798L,1279579729422L,45097830841266L,1589630250146316L,56014699053391990L,1974063158226709556L,BigInteger.Parse("69568832383885224954"),BigInteger.Parse("2451683126595415033544"),BigInteger.Parse("86400830410674087049712") };
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
public class A196800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196800Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196800.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196800.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196800Inst Instance=new A196800Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196801
{
public static readonly BigInteger[] Value={ 13L,2057L,140348L,8882811L,567312297L,36350586798L,2336509457978L,149921556582391L,9626071838140254L,617911286516585441L,BigInteger.Parse("39661708458260298030"),BigInteger.Parse("2546127117580511443456"),BigInteger.Parse("163441791893758118667088") };
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
public class A196801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196801Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196801.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196801.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196801Inst Instance=new A196801Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196802
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,20L,20L,3L,5L,65L,120L,65L,5L,8L,203L,698L,698L,203L,8L,13L,648L,4078L,7407L,4078L,648L,13L,21L,2057L,23920L,79003L,79003L,23920L,2057L,21L,34L,6527L,140348L,834632L,1516652L,834632L,140348L,6527L,34L,55L,20740L,821284L,8882811L,29239326L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196802Inst : IEnumerable<long>
{
public static readonly long[] Value=A196802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196802.Bytes);
public long this[int i]=>Value[i];

public static A196802Inst Instance=new A196802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196803
{
public static readonly BigInteger[] Value={ 1L,1L,16L,193L,19449L,2535368L,1436535356L,2099296647197L,9043086011797968L,BigInteger.Parse("109561680407727718539") };
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
public class A196803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196803Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196803.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196803.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196803Inst Instance=new A196803Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196804
{
public static readonly long[] Value={ 1L,3L,16L,37L,120L,420L,1468L,4801L,15885L,53128L,178165L,594582L,1983454L,6622194L,22119691L,73864009L,246623786L,823483995L,2749775102L,9181948002L,30659615818L,102376096183L,341847401583L,1141474348346L,3811532000911L,12727199593820L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196804Inst : IEnumerable<long>
{
public static readonly long[] Value=A196804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196804.Bytes);
public long this[int i]=>Value[i];

public static A196804Inst Instance=new A196804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196805
{
public static readonly long[] Value={ 1L,7L,37L,193L,1515L,8719L,52291L,334317L,2067173L,12663609L,78727511L,488078559L,3014804713L,18665197193L,115593457951L,715253390987L,4426801402571L,27403189146691L,169608418907807L,1049766166947791L,6497692031157569L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196805Inst : IEnumerable<long>
{
public static readonly long[] Value=A196805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196805.Bytes);
public long this[int i]=>Value[i];

public static A196805Inst Instance=new A196805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196806
{
public static readonly long[] Value={ 1L,17L,120L,1515L,19449L,166682L,1730105L,18344433L,186996068L,1929020093L,20000798340L,205893266832L,2122824479646L,21911879424345L,226005819417517L,2331282643796687L,24051519818547252L,248109780944578426L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196806Inst : IEnumerable<long>
{
public static readonly long[] Value=A196806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196806.Bytes);
public long this[int i]=>Value[i];

public static A196806Inst Instance=new A196806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196807
{
public static readonly long[] Value={ 1L,41L,420L,8719L,166682L,2535368L,46685074L,822353649L,14219232895L,247793610490L,4321118145913L,75358654335980L,1315206264464536L,22934359993226090L,399880131880385285L,6973750320639071161L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196807Inst : IEnumerable<long>
{
public static readonly long[] Value=A196807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196807.Bytes);
public long this[int i]=>Value[i];

public static A196807Inst Instance=new A196807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196808
{
public static readonly BigInteger[] Value={ 1L,99L,1468L,52291L,1730105L,46685074L,1436535356L,42144649101L,1242942835600L,36966191677933L,1095659240954513L,32430161990804370L,960817109357914432L,BigInteger.Parse("28466699840871876758"),BigInteger.Parse("843388951593615572344"),BigInteger.Parse("24985495292021432741463") };
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
public class A196808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196808Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196808.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196808.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196808Inst Instance=new A196808Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196809
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,7L,16L,7L,1L,1L,17L,37L,37L,17L,1L,1L,41L,120L,193L,120L,41L,1L,1L,99L,420L,1515L,1515L,420L,99L,1L,1L,239L,1468L,8719L,19449L,8719L,1468L,239L,1L,1L,577L,4801L,52291L,166682L,166682L,52291L,4801L,577L,1L,1L,1393L,15885L,334317L,1730105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196809Inst : IEnumerable<long>
{
public static readonly long[] Value=A196809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196809.Bytes);
public long this[int i]=>Value[i];

public static A196809Inst Instance=new A196809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196810
{
public static readonly long[] Value={ 0L,4L,18L,80L,200L,420L,756L,1472L,2358L,3860L,5500L,8304L,11232L,15484L,21090L,27392L,34816L,44604L,55404L,69840L,84294L,102124L,122452L,147264L,173800L,203476L,237762L,276752L,318304L,368340L,418500L,478208L,541398L,611524L,689780L,774576L,863136L,963148L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196810Inst : IEnumerable<long>
{
public static readonly long[] Value=A196810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196810.Bytes);
public long this[int i]=>Value[i];

public static A196810Inst Instance=new A196810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196811
{
public static readonly long[] Value={ 0L,0L,6L,144L,600L,1992L,4592L,15616L,31788L,74840L,122210L,251184L,384826L,647696L,1085190L,1616384L,2308872L,3449880L,4783326L,7052400L,9253734L,12454640L,16453096L,22180992L,28552450L,36216544L,46089162L,58449104L,72061346L,91140000L,109813780L,135448576L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196811Inst : IEnumerable<long>
{
public static readonly long[] Value=A196811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196811.Bytes);
public long this[int i]=>Value[i];

public static A196811Inst Instance=new A196811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196812
{
public static readonly long[] Value={ 0L,2L,18L,72L,200L,378L,588L,1312L,2106L,3650L,4840L,7848L,10140L,14210L,20250L,25728L,32368L,42282L,51984L,67400L,80262L,97042L,116380L,141984L,167500L,195026L,228906L,266952L,306124L,358650L,403620L,463360L,524898L,592450L,671300L,754920L,837828L,936434L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196812Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196812.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196812Inst : IEnumerable<long>
{
public static readonly long[] Value=A196812.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196812.Bytes);
public long this[int i]=>Value[i];

public static A196812Inst Instance=new A196812Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196813
{
public static readonly long[] Value={ 0L,0L,6L,96L,600L,1392L,2156L,10624L,22410L,62400L,82280L,210336L,280540L,495488L,955950L,1332736L,1844976L,2924640L,3933456L,6319200L,7954170L,10648000L,14081980L,19826304L,25502500L,31809856L,41037354L,52338272L,63979916L,84001200L,98348740L,123033600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196813Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196813.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196813Inst : IEnumerable<long>
{
public static readonly long[] Value=A196813.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196813.Bytes);
public long this[int i]=>Value[i];

public static A196813Inst Instance=new A196813Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196814
{
public static readonly long[] Value={ 1L,4L,6L,84L,120L,784L,280L,40816L,13806L,1361706L,110990L,142633176L,4263454L,197730660L,9246172320L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196814Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196814.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196814Inst : IEnumerable<long>
{
public static readonly long[] Value=A196814.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196814.Bytes);
public long this[int i]=>Value[i];

public static A196814Inst Instance=new A196814Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196815
{
public static readonly long[] Value={ 1L,2L,14L,1L,4L,2L,18L,9L,7L,3L,29L,21L,19L,12L,8L,4L,2L,31L,21L,19L,11L,1L,59L,4L,2L,22L,24L,15L,16L,8L,6L,3L,36L,37L,174L,21L,18L,11L,12L,63L,78L,189L,38L,2L,27L,25L,112L,1L,107L,12L,6L,4L,45L,169L,28L,33L,21L,112L,14L,9L,10L,6L,4L,44L,37L,153L,151L,29L,27L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196815Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196815.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196815Inst : IEnumerable<long>
{
public static readonly long[] Value=A196815.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196815.Bytes);
public long this[int i]=>Value[i];

public static A196815Inst Instance=new A196815Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196816
{
public static readonly long[] Value={ 1L,1L,0L,2L,5L,0L,5L,8L,2L,4L,4L,0L,6L,4L,1L,6L,0L,4L,3L,5L,7L,1L,0L,5L,0L,1L,5L,5L,0L,2L,2L,2L,2L,4L,0L,7L,3L,8L,8L,4L,8L,1L,0L,5L,8L,2L,0L,0L,9L,7L,7L,5L,1L,1L,6L,0L,8L,5L,3L,7L,5L,3L,7L,1L,4L,7L,6L,3L,5L,2L,2L,9L,5L,8L,5L,5L,8L,8L,3L,9L,6L,0L,3L,3L,1L,5L,5L,3L,6L,1L,0L,8L,1L,4L,9L,4L,8L,3L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196816Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196816.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196816Inst : IEnumerable<long>
{
public static readonly long[] Value=A196816.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196816.Bytes);
public long this[int i]=>Value[i];

public static A196816Inst Instance=new A196816Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196817
{
public static readonly long[] Value={ 1L,4L,0L,1L,2L,6L,9L,2L,0L,7L,5L,9L,9L,9L,5L,7L,9L,4L,2L,9L,2L,7L,1L,8L,7L,2L,4L,3L,7L,9L,0L,8L,3L,4L,1L,9L,1L,5L,3L,0L,8L,8L,2L,8L,6L,5L,4L,5L,3L,3L,6L,0L,2L,6L,0L,3L,7L,9L,1L,7L,8L,2L,5L,0L,7L,8L,6L,3L,1L,6L,4L,0L,0L,0L,4L,3L,1L,7L,1L,7L,3L,3L,3L,7L,3L,4L,8L,3L,3L,1L,2L,5L,9L,5L,7L,5L,7L,7L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196817Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196817.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196817Inst : IEnumerable<long>
{
public static readonly long[] Value=A196817.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196817.Bytes);
public long this[int i]=>Value[i];

public static A196817Inst Instance=new A196817Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196818
{
public static readonly long[] Value={ 1L,4L,6L,4L,6L,1L,1L,4L,7L,9L,7L,0L,1L,4L,2L,5L,0L,0L,5L,0L,1L,4L,6L,4L,8L,0L,4L,8L,0L,1L,0L,0L,2L,5L,9L,9L,7L,8L,1L,8L,0L,8L,4L,8L,1L,3L,1L,0L,9L,6L,2L,6L,9L,6L,0L,3L,7L,9L,0L,7L,1L,1L,0L,1L,7L,5L,5L,7L,2L,5L,3L,9L,2L,4L,2L,6L,1L,6L,4L,8L,4L,7L,8L,7L,8L,4L,3L,0L,1L,6L,9L,8L,0L,2L,3L,9L,7L,7L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196818Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196818.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196818Inst : IEnumerable<long>
{
public static readonly long[] Value=A196818.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196818.Bytes);
public long this[int i]=>Value[i];

public static A196818Inst Instance=new A196818Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196819
{
public static readonly long[] Value={ 1L,4L,9L,3L,3L,1L,9L,5L,3L,5L,7L,3L,8L,2L,4L,2L,0L,1L,9L,2L,6L,6L,6L,7L,6L,1L,8L,4L,1L,7L,9L,8L,1L,8L,4L,0L,9L,6L,2L,5L,3L,4L,9L,9L,3L,6L,9L,7L,4L,1L,5L,8L,7L,8L,6L,6L,3L,7L,2L,7L,1L,3L,8L,7L,3L,4L,2L,0L,8L,4L,6L,1L,0L,8L,8L,1L,0L,1L,5L,7L,6L,7L,9L,2L,5L,5L,0L,3L,5L,7L,5L,2L,7L,0L,2L,8L,7L,1L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196819Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196819.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196819Inst : IEnumerable<long>
{
public static readonly long[] Value=A196819.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196819.Bytes);
public long this[int i]=>Value[i];

public static A196819Inst Instance=new A196819Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196820
{
public static readonly long[] Value={ 1L,5L,0L,9L,7L,7L,1L,9L,0L,0L,4L,7L,0L,7L,2L,6L,8L,8L,5L,3L,5L,5L,4L,9L,3L,7L,5L,3L,5L,0L,0L,9L,8L,6L,5L,9L,9L,4L,4L,8L,6L,3L,7L,7L,2L,7L,5L,6L,3L,8L,3L,7L,3L,0L,5L,0L,6L,6L,8L,0L,5L,9L,3L,4L,3L,1L,5L,3L,7L,5L,3L,9L,5L,9L,0L,0L,9L,7L,0L,3L,7L,1L,1L,0L,9L,2L,9L,0L,8L,1L,2L,9L,7L,3L,8L,7L,9L,0L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196820Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196820.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196820Inst : IEnumerable<long>
{
public static readonly long[] Value=A196820.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196820.Bytes);
public long this[int i]=>Value[i];

public static A196820Inst Instance=new A196820Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196821
{
public static readonly long[] Value={ 1L,5L,2L,0L,4L,4L,9L,4L,5L,0L,8L,3L,3L,8L,1L,6L,3L,6L,3L,1L,4L,7L,4L,5L,8L,8L,2L,0L,8L,9L,0L,5L,6L,3L,9L,6L,3L,1L,3L,8L,9L,8L,5L,3L,0L,5L,5L,8L,3L,2L,7L,8L,4L,3L,5L,1L,8L,1L,2L,8L,9L,3L,4L,0L,1L,3L,6L,8L,8L,1L,5L,5L,1L,6L,1L,1L,3L,2L,8L,2L,2L,3L,1L,6L,8L,8L,9L,2L,6L,3L,2L,4L,0L,2L,9L,2L,6L,1L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196821Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196821.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196821Inst : IEnumerable<long>
{
public static readonly long[] Value=A196821.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196821.Bytes);
public long this[int i]=>Value[i];

public static A196821Inst Instance=new A196821Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196822
{
public static readonly long[] Value={ 6L,8L,6L,9L,2L,8L,0L,7L,2L,5L,0L,7L,1L,1L,4L,1L,5L,1L,4L,7L,7L,4L,2L,6L,6L,1L,4L,9L,4L,4L,4L,5L,7L,6L,9L,5L,9L,5L,8L,2L,2L,1L,4L,9L,8L,9L,9L,9L,1L,3L,4L,9L,6L,4L,8L,4L,9L,0L,6L,0L,3L,7L,4L,0L,8L,8L,7L,4L,9L,3L,4L,1L,8L,8L,9L,1L,8L,1L,0L,9L,4L,8L,5L,5L,1L,5L,3L,2L,6L,7L,7L,2L,9L,7L,4L,5L,9L,6L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196822Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196822.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196822Inst : IEnumerable<long>
{
public static readonly long[] Value=A196822.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196822.Bytes);
public long this[int i]=>Value[i];

public static A196822Inst Instance=new A196822Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196823
{
public static readonly long[] Value={ 0L,9L,3L,7L,9L,0L,0L,2L,2L,4L,4L,3L,5L,8L,8L,1L,4L,0L,6L,4L,6L,8L,9L,1L,6L,2L,7L,2L,0L,2L,1L,0L,9L,9L,8L,6L,7L,0L,9L,0L,1L,2L,8L,8L,0L,7L,8L,5L,3L,3L,2L,8L,7L,2L,7L,1L,6L,2L,8L,5L,9L,7L,3L,8L,8L,1L,3L,4L,8L,9L,3L,1L,0L,9L,7L,8L,6L,5L,5L,8L,9L,5L,2L,4L,9L,0L,1L,4L,9L,2L,3L,8L,4L,3L,1L,1L,5L,3L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196823Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196823.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196823Inst : IEnumerable<long>
{
public static readonly long[] Value=A196823.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196823.Bytes);
public long this[int i]=>Value[i];

public static A196823Inst Instance=new A196823Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196824
{
public static readonly long[] Value={ 6L,3L,4L,1L,6L,4L,9L,7L,0L,6L,9L,5L,8L,7L,7L,9L,5L,6L,1L,0L,2L,7L,4L,9L,8L,1L,1L,8L,6L,4L,0L,2L,3L,8L,0L,5L,5L,8L,2L,2L,4L,8L,4L,2L,8L,3L,9L,3L,2L,7L,5L,4L,5L,8L,4L,2L,1L,3L,3L,1L,7L,4L,7L,4L,1L,0L,3L,6L,3L,6L,2L,9L,9L,4L,1L,7L,8L,8L,6L,3L,1L,0L,0L,1L,8L,2L,8L,0L,4L,2L,7L,5L,6L,0L,4L,4L,1L,4L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196824Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196824.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196824Inst : IEnumerable<long>
{
public static readonly long[] Value=A196824.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196824.Bytes);
public long this[int i]=>Value[i];

public static A196824Inst Instance=new A196824Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196825
{
public static readonly long[] Value={ 7L,1L,9L,4L,2L,1L,2L,9L,6L,3L,2L,7L,4L,1L,0L,3L,1L,5L,7L,1L,6L,9L,2L,2L,9L,7L,0L,0L,3L,7L,3L,3L,2L,0L,4L,9L,0L,8L,5L,1L,0L,1L,0L,6L,8L,3L,9L,1L,7L,9L,8L,9L,7L,8L,5L,7L,1L,0L,4L,1L,5L,7L,4L,3L,2L,1L,2L,3L,5L,3L,5L,3L,4L,5L,8L,4L,2L,0L,5L,5L,0L,1L,0L,8L,1L,9L,4L,4L,8L,3L,4L,5L,2L,2L,0L,3L,6L,2L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196825Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196825.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196825Inst : IEnumerable<long>
{
public static readonly long[] Value=A196825.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196825.Bytes);
public long this[int i]=>Value[i];

public static A196825Inst Instance=new A196825Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196826
{
public static readonly long[] Value={ 4L,3L,4L,2L,0L,2L,5L,4L,9L,9L,9L,8L,1L,9L,6L,3L,8L,6L,8L,1L,3L,5L,2L,4L,4L,2L,1L,9L,6L,6L,6L,8L,4L,0L,1L,9L,8L,3L,9L,6L,2L,3L,8L,0L,7L,6L,4L,7L,6L,7L,2L,5L,5L,4L,6L,4L,7L,2L,0L,6L,3L,4L,8L,5L,3L,3L,2L,3L,7L,1L,0L,7L,3L,3L,7L,0L,0L,8L,1L,7L,0L,8L,7L,0L,1L,2L,9L,0L,2L,5L,5L,1L,5L,4L,5L,9L,7L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196826Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196826.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196826Inst : IEnumerable<long>
{
public static readonly long[] Value=A196826.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196826.Bytes);
public long this[int i]=>Value[i];

public static A196826Inst Instance=new A196826Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196827
{
public static readonly long[] Value={ 3L,0L,9L,1L,5L,4L,9L,3L,3L,5L,5L,8L,9L,7L,2L,5L,7L,9L,2L,5L,2L,5L,3L,4L,5L,2L,4L,1L,8L,9L,6L,4L,0L,4L,3L,0L,0L,8L,1L,3L,4L,9L,4L,2L,0L,3L,9L,0L,9L,1L,3L,3L,7L,3L,7L,4L,3L,3L,9L,3L,4L,6L,8L,0L,0L,7L,1L,1L,5L,8L,5L,1L,4L,2L,9L,6L,6L,0L,2L,9L,9L,9L,9L,3L,2L,8L,9L,6L,2L,5L,5L,0L,5L,3L,4L,7L,8L,9L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196827Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196827.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196827Inst : IEnumerable<long>
{
public static readonly long[] Value=A196827.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196827.Bytes);
public long this[int i]=>Value[i];

public static A196827Inst Instance=new A196827Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196828
{
public static readonly long[] Value={ 2L,3L,8L,7L,7L,7L,6L,5L,9L,4L,4L,5L,9L,0L,4L,8L,5L,2L,5L,6L,4L,7L,2L,9L,0L,3L,0L,9L,5L,4L,6L,1L,3L,7L,4L,7L,6L,3L,8L,1L,5L,3L,9L,8L,9L,3L,9L,2L,6L,5L,3L,6L,7L,9L,7L,4L,7L,1L,1L,8L,5L,8L,5L,8L,5L,8L,4L,4L,8L,3L,5L,3L,5L,1L,1L,3L,2L,5L,0L,9L,1L,9L,6L,5L,3L,5L,9L,0L,7L,7L,4L,8L,2L,0L,9L,4L,5L,2L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196828Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196828.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196828Inst : IEnumerable<long>
{
public static readonly long[] Value=A196828.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196828.Bytes);
public long this[int i]=>Value[i];

public static A196828Inst Instance=new A196828Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196829
{
public static readonly long[] Value={ 1L,9L,3L,9L,6L,2L,4L,3L,0L,6L,8L,1L,0L,0L,6L,7L,1L,6L,6L,3L,0L,0L,8L,0L,4L,7L,1L,7L,7L,3L,9L,5L,7L,4L,8L,6L,5L,5L,4L,8L,8L,5L,3L,9L,8L,6L,3L,7L,7L,5L,3L,2L,1L,2L,5L,8L,2L,5L,8L,6L,8L,2L,2L,0L,1L,7L,3L,6L,1L,1L,6L,2L,9L,7L,4L,5L,9L,2L,2L,6L,2L,3L,1L,8L,8L,6L,5L,2L,8L,0L,9L,3L,1L,6L,2L,0L,6L,3L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196829Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196829.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196829Inst : IEnumerable<long>
{
public static readonly long[] Value=A196829.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196829.Bytes);
public long this[int i]=>Value[i];

public static A196829Inst Instance=new A196829Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196830
{
public static readonly long[] Value={ 1L,6L,3L,0L,7L,1L,2L,1L,1L,9L,9L,5L,5L,0L,6L,9L,1L,8L,9L,1L,1L,7L,2L,0L,2L,5L,2L,1L,4L,9L,6L,2L,3L,5L,8L,2L,3L,1L,3L,3L,1L,8L,8L,7L,4L,6L,4L,0L,3L,0L,3L,5L,5L,0L,2L,4L,6L,3L,2L,9L,1L,5L,0L,0L,1L,9L,1L,5L,2L,4L,4L,8L,6L,3L,8L,6L,8L,0L,0L,7L,4L,4L,7L,8L,8L,4L,0L,7L,7L,1L,3L,9L,0L,5L,9L,1L,0L,9L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196830Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196830.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196830Inst : IEnumerable<long>
{
public static readonly long[] Value=A196830.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196830.Bytes);
public long this[int i]=>Value[i];

public static A196830Inst Instance=new A196830Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196831
{
public static readonly long[] Value={ 2L,2L,1L,4L,4L,1L,6L,9L,0L,5L,0L,7L,9L,6L,3L,6L,3L,3L,0L,6L,7L,9L,5L,6L,5L,9L,6L,0L,3L,6L,7L,7L,9L,2L,2L,1L,5L,9L,6L,6L,3L,7L,6L,4L,7L,5L,4L,4L,0L,5L,8L,6L,1L,5L,8L,1L,4L,8L,7L,3L,1L,8L,2L,5L,7L,6L,3L,1L,6L,5L,9L,4L,0L,8L,0L,2L,1L,0L,6L,1L,9L,9L,6L,1L,9L,3L,4L,3L,0L,3L,0L,7L,2L,8L,3L,6L,9L,2L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196831Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196831.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196831Inst : IEnumerable<long>
{
public static readonly long[] Value=A196831.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196831.Bytes);
public long this[int i]=>Value[i];

public static A196831Inst Instance=new A196831Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196832
{
public static readonly long[] Value={ 2L,1L,1L,7L,5L,2L,6L,7L,2L,8L,4L,3L,1L,3L,3L,5L,6L,4L,2L,2L,8L,9L,1L,8L,2L,8L,8L,7L,8L,3L,0L,2L,6L,3L,7L,0L,7L,8L,1L,5L,9L,5L,1L,6L,7L,9L,1L,0L,4L,6L,3L,2L,3L,2L,6L,2L,5L,2L,5L,9L,6L,1L,4L,0L,8L,2L,5L,0L,7L,4L,4L,7L,1L,8L,8L,9L,8L,5L,5L,0L,0L,4L,1L,4L,6L,5L,1L,6L,9L,1L,0L,2L,3L,3L,1L,7L,2L,8L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196832Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196832.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196832Inst : IEnumerable<long>
{
public static readonly long[] Value=A196832.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196832.Bytes);
public long this[int i]=>Value[i];

public static A196832Inst Instance=new A196832Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196833
{
public static readonly long[] Value={ 1L,2L,7L,0L,7L,1L,8L,4L,1L,1L,8L,6L,4L,4L,1L,9L,0L,5L,9L,4L,7L,9L,4L,4L,6L,4L,3L,3L,9L,3L,0L,0L,1L,7L,6L,8L,3L,8L,5L,6L,2L,5L,4L,4L,7L,1L,6L,6L,1L,6L,1L,6L,3L,2L,0L,7L,5L,0L,6L,4L,5L,8L,1L,2L,0L,3L,8L,7L,5L,4L,2L,8L,7L,7L,9L,2L,4L,1L,7L,9L,1L,2L,7L,7L,0L,9L,9L,2L,3L,3L,8L,2L,7L,6L,7L,3L,3L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196833Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196833.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196833Inst : IEnumerable<long>
{
public static readonly long[] Value=A196833.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196833.Bytes);
public long this[int i]=>Value[i];

public static A196833Inst Instance=new A196833Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196834
{
public static readonly long[] Value={ 1L,6L,37L,235L,1540L,10427L,73013L,529032L,3967195L,30785747L,247126450L,2050937445L,17585497797L,155666739742L,1421428484337L,13377704321695L,129659127547372L,1293095848212799L,13259069937250169L,139671750579429512L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196834Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196834.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196834Inst : IEnumerable<long>
{
public static readonly long[] Value=A196834.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196834.Bytes);
public long this[int i]=>Value[i];

public static A196834Inst Instance=new A196834Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196835
{
public static readonly long[] Value={ 1L,4L,15L,51L,146L,273L,-319L,-6374L,-36235L,-113833L,69388L,3772035L,28631669L,112704452L,-96418909L,-5652669753L,-50538496446L,-230554460867L,281597003109L,16303457144146L,166512491229617L,872578914956059L,-1111135578108284L,-78512971676777833L,-919653124088665479L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196835Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196835.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196835Inst : IEnumerable<long>
{
public static readonly long[] Value=A196835.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196835.Bytes);
public long this[int i]=>Value[i];

public static A196835Inst Instance=new A196835Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196836
{
public static readonly long[] Value={ 2L,5L,15L,50L,177L,650L,2445L,9350L,36177L,141170L,554325L,2186750L,8656377L,34355690L,136617405L,544061750L,2169039777L,8654570210L,34553579685L,138020346350L,551499730377L,2204254480730L,8811785649165L,35231447872550L,140878711512177L,563373614503250L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196836Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196836.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196836Inst : IEnumerable<long>
{
public static readonly long[] Value=A196836.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196836.Bytes);
public long this[int i]=>Value[i];

public static A196836Inst Instance=new A196836Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196837
{
public static readonly long[] Value={ 1L,2L,-3L,3L,-12L,11L,4L,-30L,70L,-50L,5L,-60L,255L,-450L,274L,6L,-105L,700L,-2205L,3248L,-1764L,7L,-168L,1610L,-7840L,20307L,-26264L,13068L,8L,-252L,3276L,-22680L,89796L,-201852L,236248L,-109584L,9L,-360L,6090L,-56700L,316365L,-1077300L,2171040L,-2345400L,1026576L,10L,-495L,10560L,-127050L,946638L,-4510275L,13667720L,-25228500L,25507152L,-10628640L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196837Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196837.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196837Inst : IEnumerable<long>
{
public static readonly long[] Value=A196837.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196837.Bytes);
public long this[int i]=>Value[i];

public static A196837Inst Instance=new A196837Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196838
{
public static readonly long[] Value={ 1L,-1L,1L,1L,-1L,1L,0L,1L,-3L,1L,-1L,0L,1L,-2L,1L,0L,-1L,0L,5L,-5L,1L,1L,0L,-1L,0L,5L,-3L,1L,0L,1L,0L,-7L,0L,7L,-7L,1L,-1L,0L,2L,0L,-7L,0L,14L,-4L,1L,0L,-3L,0L,2L,0L,-21L,0L,6L,-9L,1L,5L,0L,-3L,0L,5L,0L,-7L,0L,15L,-5L,1L,0L,5L,0L,-11L,0L,11L,0L,-11L,0L,55L,-11L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196838Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196838.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196838Inst : IEnumerable<long>
{
public static readonly long[] Value=A196838.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196838.Bytes);
public long this[int i]=>Value[i];

public static A196838Inst Instance=new A196838Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196839
{
public static readonly long[] Value={ 1L,2L,1L,6L,1L,1L,1L,2L,2L,1L,30L,1L,1L,1L,1L,1L,6L,1L,3L,2L,1L,42L,1L,2L,1L,2L,1L,1L,1L,6L,1L,6L,1L,2L,2L,1L,30L,1L,3L,1L,3L,1L,3L,1L,1L,1L,10L,1L,1L,1L,5L,1L,1L,2L,1L,66L,1L,2L,1L,1L,1L,1L,1L,2L,1L,1L,1L,6L,1L,2L,1L,1L,1L,1L,1L,6L,2L,1L,2730L,1L,1L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196839Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196839.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196839Inst : IEnumerable<long>
{
public static readonly long[] Value=A196839.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196839.Bytes);
public long this[int i]=>Value[i];

public static A196839Inst Instance=new A196839Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196840
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,0L,1L,1L,1L,-1L,0L,1L,1L,1L,0L,-1L,0L,5L,1L,1L,1L,0L,-1L,0L,1L,1L,1L,0L,1L,0L,-7L,0L,7L,1L,1L,-1L,0L,2L,0L,-7L,0L,2L,1L,1L,0L,-3L,0L,1L,0L,-7L,0L,3L,1L,1L,5L,0L,-1L,0L,1L,0L,-1L,0L,5L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196840Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196840.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196840Inst : IEnumerable<long>
{
public static readonly long[] Value=A196840.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196840.Bytes);
public long this[int i]=>Value[i];

public static A196840Inst Instance=new A196840Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196841
{
public static readonly long[] Value={ 1L,1L,1L,1L,4L,3L,1L,8L,19L,12L,1L,13L,59L,107L,60L,1L,19L,137L,461L,702L,360L,1L,26L,270L,1420L,3929L,5274L,2520L,1L,34L,478L,3580L,15289L,36706L,44712L,20160L,1L,43L,784L,7882L,47509L,174307L,375066L,422568L,181440L,1L,53L,1214L,15722L,126329L,649397L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196841Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196841.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196841Inst : IEnumerable<long>
{
public static readonly long[] Value=A196841.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196841.Bytes);
public long this[int i]=>Value[i];

public static A196841Inst Instance=new A196841Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196842
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,7L,14L,8L,1L,12L,49L,78L,40L,1L,18L,121L,372L,508L,240L,1L,25L,247L,1219L,3112L,3796L,1680L,1L,33L,447L,3195L,12864L,28692L,32048L,13440L,1L,42L,744L,7218L,41619L,144468L,290276L,301872L,120960L,1L,52L,1164L,14658L,113799L,560658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196842Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196842.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196842Inst : IEnumerable<long>
{
public static readonly long[] Value=A196842.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196842.Bytes);
public long this[int i]=>Value[i];

public static A196842Inst Instance=new A196842Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196843
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,11L,6L,1L,11L,41L,61L,30L,1L,17L,107L,307L,396L,180L,1L,24L,226L,1056L,2545L,2952L,1260L,1L,32L,418L,2864L,10993L,23312L,24876L,10080L,1L,41L,706L,6626L,36769L,122249L,234684L,233964L,90720L,1L,51L,1116L,13686L,103029L,489939L,1457174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196843Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196843.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196843Inst : IEnumerable<long>
{
public static readonly long[] Value=A196843.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196843.Bytes);
public long this[int i]=>Value[i];

public static A196843Inst Instance=new A196843Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196844
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,6L,11L,6L,1L,10L,35L,50L,24L,1L,16L,95L,260L,324L,144L,1L,23L,207L,925L,2144L,2412L,1008L,1L,31L,391L,2581L,9544L,19564L,20304L,8064L,1L,40L,670L,6100L,32773L,105460L,196380L,190800L,72576L,1L,50L,1070L,12800L,93773L,433190L,1250980L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196844Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196844.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196844Inst : IEnumerable<long>
{
public static readonly long[] Value=A196844.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196844.Bytes);
public long this[int i]=>Value[i];

public static A196844Inst Instance=new A196844Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196845
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,12L,1L,12L,47L,60L,1L,18L,119L,342L,360L,1L,25L,245L,1175L,2754L,2520L,1L,33L,445L,3135L,12154L,24552L,20160L,1L,42L,742L,7140L,40369L,133938L,241128L,181440L,1L,52L,1162L,14560L,111769L,537628L,1580508L,2592720L,1814400L,1L,63L,1734L,27342L,271929L,1767087L,7494416L,19978308L,30334320L,19958400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196845Inst : IEnumerable<long>
{
public static readonly long[] Value=A196845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196845.Bytes);
public long this[int i]=>Value[i];

public static A196845Inst Instance=new A196845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196846
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,2L,1L,8L,17L,10L,1L,14L,65L,112L,60L,1L,21L,163L,567L,844L,420L,1L,29L,331L,1871L,5380L,7172L,3360L,1L,38L,592L,4850L,22219L,55592L,67908L,30240L,1L,48L,972L,10770L,70719L,277782L,623828L,709320L,302400L,1L,59L,1500L,21462L,189189L,1055691L,3679430L,7571428L,8104920L,3326400L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196846Inst : IEnumerable<long>
{
public static readonly long[] Value=A196846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196846.Bytes);
public long this[int i]=>Value[i];

public static A196846Inst Instance=new A196846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196847
{
public static readonly long[] Value={ 1L,1L,-5L,7L,1L,-14L,73L,-168L,148L,1L,-27L,298L,-1719L,5473L,-9162L,6396L,1L,-44L,830L,-8756L,56453L,-227744L,562060L,-778800L,468576L,1L,-65L,1865L,-31070L,332463L,-2385305L,11612795L,-37875240L,79269676L,-96420480L,52148160L,1L,-90L,3647L,-87900L,140202L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196847Inst : IEnumerable<long>
{
public static readonly long[] Value=A196847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196847.Bytes);
public long this[int i]=>Value[i];

public static A196847Inst Instance=new A196847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196848
{
public static readonly long[] Value={ 1L,1L,-4L,5L,1L,-12L,55L,-114L,94L,1L,-24L,238L,-1248L,3661L,-5736L,3828L,1L,-40L,690L,-6700L,40053L,-151060L,351800L,-465000L,270576L,1L,-60L,1595L,-24720L,247203L,-1665900L,7660565L,-23745720L,47560876L,-55805520L,29400480L,1L,-84L,3185L,-72030L,1081353L,-11344872L,85234175L,-461800710L,1790256286L,-4843901664L,8693117160L,-9320129280L,4546558080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196848Inst : IEnumerable<long>
{
public static readonly long[] Value=A196848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196848.Bytes);
public long this[int i]=>Value[i];

public static A196848Inst Instance=new A196848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196849
{
public static readonly long[] Value={ 1L,11L,206L,16876L,4326720L,3805929995L,11300853019444L,113522093851497024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196849Inst : IEnumerable<long>
{
public static readonly long[] Value=A196849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196849.Bytes);
public long this[int i]=>Value[i];

public static A196849Inst Instance=new A196849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196850
{
public static readonly long[] Value={ 2L,11L,38L,136L,496L,1792L,6440L,23306L,84180L,303664L,1096874L,3960906L,14299036L,51633110L,186437376L,673147554L,2430568646L,8776143806L,31687921122L,114416191032L,413124704992L,1491673030176L,5386005309890L,19447328987316L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196850Inst : IEnumerable<long>
{
public static readonly long[] Value=A196850.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196850.Bytes);
public long this[int i]=>Value[i];

public static A196850Inst Instance=new A196850Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196851
{
public static readonly long[] Value={ 4L,38L,206L,1370L,8767L,56470L,363685L,2343584L,15108610L,97376923L,627590184L,4044924351L,26070308556L,168028055199L,1082971243944L,6979940126878L,44986968132898L,289949111595991L,1868774104215258L,12044584704922151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196851Inst : IEnumerable<long>
{
public static readonly long[] Value=A196851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196851.Bytes);
public long this[int i]=>Value[i];

public static A196851Inst Instance=new A196851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196852
{
public static readonly long[] Value={ 6L,136L,1370L,16876L,199125L,2369631L,28194191L,335586650L,3993458371L,47516896629L,565414492412L,6728166888869L,80061424960490L,952681438970742L,11336327457310421L,134895508948869550L,1605175914338415794L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196852Inst : IEnumerable<long>
{
public static readonly long[] Value=A196852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196852.Bytes);
public long this[int i]=>Value[i];

public static A196852Inst Instance=new A196852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196853
{
public static readonly BigInteger[] Value={ 12L,496L,8767L,199125L,4326720L,94652804L,2069281146L,45250654402L,989582452566L,21641093339471L,473258424515226L,10349412319177011L,226326014259354738L,4949414076598335496L,BigInteger.Parse("108236297594374361032"),BigInteger.Parse("2366965861351964408167") };
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
public class A196853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196853Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196853.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196853.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196853Inst Instance=new A196853Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196854
{
public static readonly BigInteger[] Value={ 22L,1792L,56470L,2369631L,94652804L,3805929995L,152929723254L,6148984299163L,247223213832440L,9939022894905148L,399570539750626195L,16063726580619196531UL,BigInteger.Parse("645804489432297174658"),BigInteger.Parse("25963059069129330544089") };
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
public class A196854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196854Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196854.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196854Inst Instance=new A196854Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196855
{
public static readonly BigInteger[] Value={ 40L,6440L,363685L,28194191L,2069281146L,152929723254L,11300853019444L,835390769370971L,61745852507376150L,4563708721504197779L,BigInteger.Parse("337310171120447151691"),BigInteger.Parse("24931202561823495912020"),BigInteger.Parse("1842711946915214490433763") };
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
public class A196855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196855Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196855.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196855.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196855Inst Instance=new A196855Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196856
{
public static readonly long[] Value={ 1L,2L,2L,4L,11L,4L,6L,38L,38L,6L,12L,136L,206L,136L,12L,22L,496L,1370L,1370L,496L,22L,40L,1792L,8767L,16876L,8767L,1792L,40L,74L,6440L,56470L,199125L,199125L,56470L,6440L,74L,136L,23306L,363685L,2369631L,4326720L,2369631L,363685L,23306L,136L,250L,84180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196856Inst : IEnumerable<long>
{
public static readonly long[] Value=A196856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196856.Bytes);
public long this[int i]=>Value[i];

public static A196856Inst Instance=new A196856Inst();

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