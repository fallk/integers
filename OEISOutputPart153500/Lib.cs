using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A196605
{
public static readonly long[] Value={ 2L,5L,8L,5L,9L,8L,5L,8L,2L,2L,5L,4L,1L,8L,9L,4L,9L,0L,3L,0L,4L,4L,8L,2L,6L,1L,9L,5L,6L,1L,5L,2L,0L,2L,8L,1L,3L,3L,8L,5L,5L,2L,9L,6L,5L,3L,1L,6L,8L,2L,5L,7L,5L,3L,4L,3L,8L,8L,1L,7L,2L,8L,7L,4L,3L,7L,7L,4L,1L,3L,3L,0L,4L,9L,3L,9L,2L,6L,1L,8L,4L,4L,6L,4L,5L,3L,3L,9L,0L,5L,0L,8L,1L,5L,9L,4L,0L,9L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196605Inst : IEnumerable<long>
{
public static readonly long[] Value=A196605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196605.Bytes);
public long this[int i]=>Value[i];

public static A196605Inst Instance=new A196605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196606
{
public static readonly long[] Value={ 2L,0L,4L,2L,4L,5L,3L,7L,8L,7L,0L,4L,5L,3L,8L,9L,0L,1L,7L,2L,3L,4L,5L,9L,0L,5L,7L,0L,5L,5L,2L,8L,0L,9L,7L,7L,3L,4L,4L,5L,7L,3L,1L,1L,3L,0L,6L,3L,5L,9L,6L,9L,1L,1L,2L,8L,0L,3L,7L,9L,7L,1L,8L,5L,8L,3L,3L,0L,7L,9L,1L,4L,4L,2L,3L,6L,4L,3L,1L,1L,5L,3L,1L,5L,5L,7L,7L,4L,2L,6L,7L,7L,7L,0L,0L,7L,5L,7L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196606Inst : IEnumerable<long>
{
public static readonly long[] Value=A196606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196606.Bytes);
public long this[int i]=>Value[i];

public static A196606Inst Instance=new A196606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196607
{
public static readonly long[] Value={ 1L,6L,9L,0L,7L,7L,6L,4L,7L,3L,9L,8L,0L,1L,5L,1L,4L,9L,9L,9L,5L,2L,9L,5L,3L,6L,7L,6L,7L,2L,6L,2L,7L,8L,1L,0L,7L,4L,2L,1L,3L,4L,0L,7L,6L,9L,6L,9L,6L,5L,3L,7L,1L,7L,0L,5L,6L,2L,1L,0L,6L,7L,7L,0L,2L,8L,1L,3L,5L,0L,2L,5L,7L,5L,8L,9L,1L,6L,8L,6L,1L,8L,9L,9L,4L,5L,5L,6L,8L,0L,9L,5L,5L,1L,1L,9L,4L,7L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196607Inst : IEnumerable<long>
{
public static readonly long[] Value=A196607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196607.Bytes);
public long this[int i]=>Value[i];

public static A196607Inst Instance=new A196607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196608
{
public static readonly long[] Value={ 2L,5L,5L,7L,0L,9L,1L,0L,9L,3L,9L,2L,7L,9L,0L,7L,9L,3L,7L,4L,5L,9L,8L,8L,7L,7L,7L,4L,4L,6L,3L,4L,0L,0L,3L,8L,6L,7L,5L,2L,8L,1L,8L,0L,9L,9L,9L,0L,7L,2L,1L,9L,3L,8L,0L,0L,2L,3L,3L,1L,0L,9L,3L,7L,9L,6L,3L,4L,3L,2L,8L,8L,3L,0L,1L,7L,1L,3L,6L,0L,0L,4L,8L,8L,7L,8L,2L,1L,9L,2L,9L,5L,9L,9L,7L,5L,4L,8L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196608Inst : IEnumerable<long>
{
public static readonly long[] Value=A196608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196608.Bytes);
public long this[int i]=>Value[i];

public static A196608Inst Instance=new A196608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196609
{
public static readonly long[] Value={ 1L,3L,8L,0L,6L,0L,8L,5L,2L,5L,6L,4L,7L,7L,5L,6L,7L,2L,9L,1L,2L,8L,1L,9L,8L,3L,6L,9L,2L,9L,5L,0L,5L,6L,6L,1L,5L,4L,5L,8L,8L,3L,6L,0L,2L,5L,5L,6L,2L,8L,7L,4L,4L,9L,8L,3L,4L,3L,0L,6L,7L,8L,1L,2L,9L,0L,8L,8L,1L,1L,9L,4L,1L,2L,0L,9L,1L,1L,5L,1L,7L,6L,1L,3L,1L,8L,3L,7L,9L,3L,8L,5L,4L,0L,5L,2L,7L,5L,4L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196609Inst : IEnumerable<long>
{
public static readonly long[] Value=A196609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196609.Bytes);
public long this[int i]=>Value[i];

public static A196609Inst Instance=new A196609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196610
{
public static readonly long[] Value={ 1L,7L,8L,2L,2L,2L,5L,1L,4L,0L,2L,0L,3L,1L,3L,3L,3L,1L,2L,4L,0L,7L,5L,5L,1L,0L,3L,2L,6L,6L,6L,1L,6L,0L,0L,1L,9L,5L,1L,3L,4L,4L,2L,6L,3L,6L,9L,4L,4L,5L,2L,3L,3L,4L,5L,7L,3L,0L,3L,9L,3L,2L,2L,0L,3L,9L,2L,9L,1L,5L,6L,2L,8L,3L,8L,7L,9L,3L,1L,2L,8L,0L,2L,8L,4L,6L,5L,8L,4L,5L,1L,5L,5L,2L,5L,7L,0L,6L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196610Inst : IEnumerable<long>
{
public static readonly long[] Value=A196610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196610.Bytes);
public long this[int i]=>Value[i];

public static A196610Inst Instance=new A196610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196611
{
public static readonly long[] Value={ 1L,3L,5L,1L,0L,3L,3L,8L,8L,6L,8L,7L,8L,3L,7L,8L,6L,2L,4L,0L,0L,9L,1L,9L,2L,4L,7L,3L,5L,2L,8L,4L,3L,0L,2L,1L,7L,4L,8L,3L,4L,3L,7L,8L,0L,5L,9L,6L,3L,4L,7L,8L,1L,5L,9L,2L,3L,0L,1L,4L,5L,2L,3L,3L,6L,5L,4L,5L,9L,5L,8L,9L,8L,3L,5L,7L,6L,8L,7L,7L,2L,4L,9L,2L,4L,5L,3L,5L,7L,8L,7L,6L,5L,3L,0L,2L,9L,4L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196611Inst : IEnumerable<long>
{
public static readonly long[] Value=A196611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196611.Bytes);
public long this[int i]=>Value[i];

public static A196611Inst Instance=new A196611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196612
{
public static readonly long[] Value={ 5L,1L,1L,4L,1L,8L,2L,1L,8L,7L,8L,5L,5L,8L,1L,5L,8L,7L,4L,9L,1L,9L,7L,7L,5L,5L,4L,8L,9L,2L,6L,8L,0L,0L,7L,7L,3L,5L,0L,5L,6L,3L,6L,1L,9L,9L,8L,1L,4L,4L,3L,8L,7L,6L,0L,0L,4L,6L,6L,2L,1L,8L,7L,5L,9L,2L,6L,8L,6L,5L,7L,6L,6L,0L,3L,4L,2L,7L,2L,0L,0L,9L,7L,7L,5L,6L,4L,3L,8L,5L,9L,1L,9L,9L,5L,0L,9L,7L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196612Inst : IEnumerable<long>
{
public static readonly long[] Value=A196612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196612.Bytes);
public long this[int i]=>Value[i];

public static A196612Inst Instance=new A196612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196613
{
public static readonly long[] Value={ 5L,3L,1L,2L,4L,6L,9L,7L,1L,1L,6L,5L,6L,5L,6L,7L,6L,9L,7L,3L,6L,6L,1L,5L,7L,9L,9L,8L,2L,5L,4L,4L,0L,3L,1L,8L,1L,1L,9L,1L,6L,9L,4L,1L,2L,2L,9L,2L,0L,7L,8L,3L,5L,5L,2L,4L,1L,2L,5L,6L,2L,2L,8L,3L,8L,4L,9L,0L,6L,5L,4L,7L,0L,5L,4L,7L,0L,2L,9L,2L,3L,6L,4L,4L,2L,8L,8L,2L,9L,8L,4L,8L,7L,2L,6L,5L,3L,2L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196613Inst : IEnumerable<long>
{
public static readonly long[] Value=A196613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196613.Bytes);
public long this[int i]=>Value[i];

public static A196613Inst Instance=new A196613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196614
{
public static readonly long[] Value={ 5L,5L,2L,2L,4L,3L,4L,1L,0L,2L,5L,9L,1L,0L,2L,6L,9L,1L,6L,5L,1L,2L,7L,9L,3L,4L,7L,7L,1L,8L,0L,2L,2L,6L,4L,6L,1L,8L,3L,5L,3L,4L,4L,1L,0L,2L,2L,5L,1L,4L,9L,7L,9L,9L,3L,3L,7L,2L,2L,7L,1L,2L,5L,1L,6L,3L,5L,2L,4L,7L,7L,6L,4L,8L,3L,6L,4L,6L,0L,7L,0L,4L,5L,2L,7L,3L,5L,1L,7L,5L,4L,1L,6L,2L,1L,1L,0L,1L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196614Inst : IEnumerable<long>
{
public static readonly long[] Value=A196614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196614.Bytes);
public long this[int i]=>Value[i];

public static A196614Inst Instance=new A196614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196615
{
public static readonly long[] Value={ 5L,7L,6L,2L,8L,0L,9L,4L,5L,6L,0L,9L,0L,9L,8L,8L,0L,3L,3L,0L,0L,7L,3L,0L,0L,1L,5L,2L,9L,9L,9L,9L,5L,3L,3L,5L,6L,6L,7L,6L,8L,1L,9L,6L,8L,0L,7L,1L,2L,0L,5L,6L,6L,6L,8L,0L,8L,3L,2L,4L,9L,4L,4L,8L,5L,3L,2L,7L,4L,1L,9L,7L,7L,9L,1L,4L,0L,1L,0L,3L,8L,1L,8L,6L,7L,5L,1L,3L,9L,0L,3L,4L,8L,4L,4L,7L,2L,6L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196615Inst : IEnumerable<long>
{
public static readonly long[] Value=A196615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196615.Bytes);
public long this[int i]=>Value[i];

public static A196615Inst Instance=new A196615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196616
{
public static readonly long[] Value={ 6L,7L,6L,2L,6L,9L,7L,9L,4L,4L,6L,8L,2L,5L,4L,4L,5L,0L,0L,9L,9L,7L,9L,3L,6L,0L,1L,4L,4L,6L,0L,8L,1L,0L,9L,4L,9L,1L,7L,6L,5L,8L,8L,3L,1L,7L,6L,0L,2L,4L,4L,0L,0L,5L,2L,4L,0L,6L,2L,0L,6L,8L,3L,3L,1L,6L,6L,5L,6L,4L,5L,4L,2L,8L,3L,8L,2L,8L,2L,5L,4L,3L,1L,2L,7L,1L,1L,6L,0L,6L,7L,3L,3L,9L,5L,1L,7L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196616Inst : IEnumerable<long>
{
public static readonly long[] Value=A196616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196616.Bytes);
public long this[int i]=>Value[i];

public static A196616Inst Instance=new A196616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196617
{
public static readonly long[] Value={ 1L,0L,6L,8L,2L,2L,3L,5L,4L,4L,1L,9L,7L,2L,4L,9L,0L,1L,8L,2L,8L,3L,4L,7L,1L,1L,1L,4L,2L,6L,3L,0L,9L,2L,8L,9L,8L,4L,6L,8L,9L,3L,5L,1L,3L,0L,5L,1L,5L,1L,1L,6L,6L,3L,4L,3L,9L,3L,2L,7L,1L,1L,7L,8L,1L,1L,1L,1L,7L,7L,2L,9L,7L,6L,4L,7L,3L,2L,9L,6L,6L,3L,4L,9L,8L,5L,4L,1L,3L,9L,5L,2L,1L,6L,7L,3L,0L,3L,8L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196617Inst : IEnumerable<long>
{
public static readonly long[] Value=A196617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196617.Bytes);
public long this[int i]=>Value[i];

public static A196617Inst Instance=new A196617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196618
{
public static readonly long[] Value={ 4L,8L,1L,6L,8L,1L,7L,7L,8L,5L,4L,8L,2L,3L,8L,2L,6L,9L,9L,8L,7L,4L,2L,9L,7L,2L,2L,7L,7L,5L,1L,6L,9L,6L,3L,8L,0L,6L,1L,4L,9L,0L,5L,0L,2L,7L,9L,3L,2L,6L,8L,4L,6L,6L,7L,2L,6L,0L,0L,8L,4L,4L,8L,4L,5L,8L,1L,3L,0L,3L,4L,1L,8L,3L,5L,9L,2L,6L,6L,8L,6L,6L,7L,9L,4L,6L,5L,4L,7L,5L,3L,3L,5L,4L,8L,5L,7L,4L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196618Inst : IEnumerable<long>
{
public static readonly long[] Value=A196618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196618.Bytes);
public long this[int i]=>Value[i];

public static A196618Inst Instance=new A196618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196619
{
public static readonly long[] Value={ 4L,5L,4L,4L,5L,1L,8L,6L,6L,3L,5L,4L,2L,2L,6L,5L,9L,9L,8L,1L,9L,6L,9L,1L,1L,4L,6L,3L,2L,9L,5L,2L,3L,4L,0L,2L,8L,3L,6L,3L,4L,6L,9L,6L,1L,1L,7L,9L,5L,6L,7L,2L,2L,1L,8L,1L,1L,7L,2L,6L,3L,4L,1L,4L,5L,1L,2L,5L,7L,1L,7L,1L,7L,6L,6L,8L,0L,0L,5L,9L,9L,3L,4L,9L,4L,8L,5L,0L,9L,9L,7L,9L,0L,1L,6L,0L,2L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196619Inst : IEnumerable<long>
{
public static readonly long[] Value=A196619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196619.Bytes);
public long this[int i]=>Value[i];

public static A196619Inst Instance=new A196619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196620
{
public static readonly long[] Value={ 8L,7L,6L,3L,4L,6L,2L,0L,1L,1L,1L,8L,3L,7L,4L,1L,9L,1L,1L,2L,3L,4L,9L,4L,1L,1L,3L,9L,2L,2L,8L,3L,0L,2L,4L,8L,2L,1L,3L,1L,7L,7L,2L,3L,5L,9L,5L,9L,6L,9L,0L,8L,7L,6L,1L,6L,9L,6L,2L,3L,0L,2L,0L,2L,9L,3L,8L,2L,0L,9L,1L,7L,8L,1L,6L,7L,8L,2L,2L,6L,2L,7L,5L,1L,0L,3L,5L,8L,7L,4L,8L,5L,1L,7L,4L,5L,4L,1L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196620Inst : IEnumerable<long>
{
public static readonly long[] Value=A196620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196620.Bytes);
public long this[int i]=>Value[i];

public static A196620Inst Instance=new A196620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196621
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,6L,5L,0L,4L,8L,3L,2L,5L,5L,4L,6L,0L,2L,8L,4L,7L,1L,3L,0L,7L,2L,9L,0L,3L,0L,5L,4L,0L,3L,4L,8L,4L,5L,6L,7L,7L,6L,1L,4L,1L,8L,7L,4L,9L,0L,5L,3L,6L,4L,4L,3L,8L,3L,1L,9L,1L,4L,0L,8L,4L,2L,3L,9L,0L,6L,9L,5L,4L,3L,0L,4L,9L,0L,1L,7L,8L,3L,6L,4L,0L,6L,5L,0L,7L,9L,7L,8L,4L,4L,4L,4L,6L,2L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196621Inst : IEnumerable<long>
{
public static readonly long[] Value=A196621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196621.Bytes);
public long this[int i]=>Value[i];

public static A196621Inst Instance=new A196621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196622
{
public static readonly long[] Value={ 1L,0L,3L,0L,9L,1L,5L,3L,4L,8L,5L,3L,5L,1L,1L,3L,4L,1L,1L,8L,6L,4L,3L,8L,4L,0L,1L,8L,3L,5L,3L,4L,3L,5L,6L,6L,2L,0L,9L,0L,6L,1L,6L,9L,3L,2L,9L,4L,0L,1L,9L,2L,2L,2L,3L,3L,8L,0L,6L,0L,2L,3L,3L,5L,7L,8L,9L,8L,4L,3L,2L,8L,3L,3L,5L,2L,1L,8L,0L,1L,6L,0L,6L,0L,2L,6L,9L,9L,4L,1L,7L,0L,3L,6L,1L,6L,7L,7L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196622Inst : IEnumerable<long>
{
public static readonly long[] Value=A196622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196622.Bytes);
public long this[int i]=>Value[i];

public static A196622Inst Instance=new A196622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196623
{
public static readonly long[] Value={ 1L,1L,6L,0L,4L,8L,0L,1L,4L,3L,6L,8L,7L,5L,8L,7L,0L,6L,7L,1L,4L,6L,4L,0L,5L,8L,5L,9L,9L,4L,5L,6L,3L,5L,8L,8L,9L,1L,7L,5L,4L,9L,9L,3L,4L,7L,3L,5L,9L,5L,0L,5L,2L,4L,5L,3L,1L,5L,9L,7L,3L,0L,6L,6L,0L,7L,9L,7L,2L,5L,4L,5L,8L,3L,6L,2L,2L,8L,5L,9L,7L,1L,3L,9L,7L,9L,5L,8L,0L,9L,9L,4L,8L,1L,6L,6L,5L,9L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196623Inst : IEnumerable<long>
{
public static readonly long[] Value=A196623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196623.Bytes);
public long this[int i]=>Value[i];

public static A196623Inst Instance=new A196623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196624
{
public static readonly long[] Value={ 7L,4L,0L,8L,4L,0L,9L,5L,5L,0L,9L,5L,4L,9L,0L,6L,2L,1L,0L,1L,0L,9L,3L,5L,4L,0L,9L,9L,4L,3L,1L,3L,0L,1L,3L,7L,1L,9L,8L,6L,5L,2L,7L,9L,3L,5L,5L,9L,3L,2L,1L,5L,7L,6L,3L,2L,4L,2L,7L,0L,4L,8L,1L,9L,5L,1L,7L,6L,6L,5L,7L,5L,3L,5L,1L,4L,8L,4L,5L,3L,8L,6L,3L,3L,0L,4L,6L,4L,4L,2L,6L,5L,1L,1L,1L,3L,2L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196624Inst : IEnumerable<long>
{
public static readonly long[] Value=A196624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196624.Bytes);
public long this[int i]=>Value[i];

public static A196624Inst Instance=new A196624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196625
{
public static readonly long[] Value={ 6L,0L,5L,7L,8L,0L,2L,1L,7L,0L,2L,1L,5L,5L,3L,7L,0L,9L,1L,4L,8L,4L,1L,7L,5L,6L,5L,7L,5L,9L,6L,9L,8L,7L,7L,1L,0L,4L,8L,1L,1L,7L,9L,0L,3L,1L,1L,4L,1L,4L,8L,4L,0L,5L,7L,8L,5L,1L,6L,6L,5L,3L,9L,7L,3L,5L,3L,1L,8L,5L,8L,6L,1L,5L,7L,0L,0L,8L,7L,3L,0L,1L,2L,2L,4L,7L,7L,3L,8L,3L,8L,1L,8L,8L,7L,9L,1L,2L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196625Inst : IEnumerable<long>
{
public static readonly long[] Value=A196625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196625.Bytes);
public long this[int i]=>Value[i];

public static A196625Inst Instance=new A196625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196626
{
public static readonly long[] Value={ 1L,1L,5L,2L,5L,6L,1L,8L,9L,1L,2L,1L,8L,1L,9L,7L,6L,0L,6L,6L,0L,1L,4L,6L,0L,0L,3L,0L,5L,9L,9L,9L,9L,0L,6L,7L,1L,3L,3L,5L,3L,6L,3L,9L,3L,6L,1L,4L,2L,4L,1L,1L,3L,3L,3L,6L,1L,6L,6L,4L,9L,8L,8L,9L,7L,0L,6L,5L,4L,8L,3L,9L,5L,5L,8L,2L,8L,0L,2L,0L,7L,6L,3L,7L,3L,5L,0L,2L,7L,8L,0L,6L,9L,6L,8L,9L,4L,5L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196626Inst : IEnumerable<long>
{
public static readonly long[] Value=A196626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196626.Bytes);
public long this[int i]=>Value[i];

public static A196626Inst Instance=new A196626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196627
{
public static readonly long[] Value={ 5L,5333L,18414001L,804146449L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196627Inst : IEnumerable<long>
{
public static readonly long[] Value=A196627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196627.Bytes);
public long this[int i]=>Value[i];

public static A196627Inst Instance=new A196627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196628
{
public static readonly long[] Value={ 3L,3783L,712999L,49917253L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196628Inst : IEnumerable<long>
{
public static readonly long[] Value=A196628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196628.Bytes);
public long this[int i]=>Value[i];

public static A196628Inst Instance=new A196628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196629
{
public static readonly long[] Value={ 1L,2L,21L,327L,17278L,2140040L,651323279L,497248017421L,944403244013788L,4486207626875690795L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196629Inst : IEnumerable<long>
{
public static readonly long[] Value=A196629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196629.Bytes);
public long this[int i]=>Value[i];

public static A196629Inst Instance=new A196629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196630
{
public static readonly long[] Value={ 1L,2L,5L,10L,26L,65L,161L,403L,1006L,2511L,6270L,15654L,39083L,97579L,243625L,608258L,1518637L,3791578L,9466426L,23634809L,59008985L,147327627L,367832622L,918367047L,2292885358L,5724642758L,14292705299L,35684571667L,89093606033L,222439846274L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196630Inst : IEnumerable<long>
{
public static readonly long[] Value=A196630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196630.Bytes);
public long this[int i]=>Value[i];

public static A196630Inst Instance=new A196630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196631
{
public static readonly long[] Value={ 1L,5L,21L,62L,232L,780L,2716L,9427L,32612L,113008L,391387L,1355818L,4696609L,16268643L,56353996L,195208062L,676193929L,2342310759L,8113674993L,28105465903L,97356282867L,337238520190L,1168181597226L,4046537274472L,14017053521933L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196631Inst : IEnumerable<long>
{
public static readonly long[] Value=A196631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196631.Bytes);
public long this[int i]=>Value[i];

public static A196631Inst Instance=new A196631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196632
{
public static readonly long[] Value={ 1L,10L,62L,327L,1927L,10708L,61040L,344949L,1953280L,11058838L,62603964L,354440028L,2006561317L,11359957121L,64312714711L,364097413550L,2061286075359L,11669680495150L,66066258785133L,374024808089191L,2117488804412111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196632Inst : IEnumerable<long>
{
public static readonly long[] Value=A196632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196632.Bytes);
public long this[int i]=>Value[i];

public static A196632Inst Instance=new A196632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196633
{
public static readonly long[] Value={ 1L,26L,232L,1927L,17278L,152925L,1339251L,11820065L,103936104L,915486074L,8060380033L,70961333274L,624782246290L,5500794059044L,48430956386897L,426402612324896L,3754196939727200L,33053273003024306L,291012538839640625L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196633Inst : IEnumerable<long>
{
public static readonly long[] Value=A196633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196633.Bytes);
public long this[int i]=>Value[i];

public static A196633Inst Instance=new A196633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196634
{
public static readonly long[] Value={ 1L,65L,780L,10708L,152925L,2140040L,29718190L,415475619L,5791281872L,80883758124L,1128675587447L,15753191583307L,219869040473415L,3068688709980912L,42829911529529182L,597780110150837643L,8343266217471860095L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196634Inst : IEnumerable<long>
{
public static readonly long[] Value=A196634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196634.Bytes);
public long this[int i]=>Value[i];

public static A196634Inst Instance=new A196634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196635
{
public static readonly BigInteger[] Value={ 1L,161L,2716L,61040L,1339251L,29718190L,651323279L,14313363492L,314536084653L,6918341058099L,152091254605720L,3343887108564234L,73523096683740016L,1616580075894214591L,BigInteger.Parse("35544361135805663463"),BigInteger.Parse("781529666441604010638") };
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
public class A196635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196635Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196635.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196635.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196635Inst Instance=new A196635Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196636
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,5L,5L,1L,1L,10L,21L,10L,1L,1L,26L,62L,62L,26L,1L,1L,65L,232L,327L,232L,65L,1L,1L,161L,780L,1927L,1927L,780L,161L,1L,1L,403L,2716L,10708L,17278L,10708L,2716L,403L,1L,1L,1006L,9427L,61040L,152925L,152925L,61040L,9427L,1006L,1L,1L,2511L,32612L,344949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196636Inst : IEnumerable<long>
{
public static readonly long[] Value=A196636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196636.Bytes);
public long this[int i]=>Value[i];

public static A196636Inst Instance=new A196636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196637
{
public static readonly long[] Value={ 1L,2L,21L,327L,17518L,2166536L,665532327L,513774394191L,988444898540533L,4764558471777983273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196637Inst : IEnumerable<long>
{
public static readonly long[] Value=A196637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196637.Bytes);
public long this[int i]=>Value[i];

public static A196637Inst Instance=new A196637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196638
{
public static readonly long[] Value={ 1L,26L,232L,1927L,17518L,154629L,1359317L,12023695L,106039299L,936657625L,8268804393L,72998302818L,644487244986L,5689897996053L,50233768766506L,443492858364741L,3915416819930768L,34567612325414149L,305183172877964077L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196638Inst : IEnumerable<long>
{
public static readonly long[] Value=A196638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196638.Bytes);
public long this[int i]=>Value[i];

public static A196638Inst Instance=new A196638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196639
{
public static readonly long[] Value={ 1L,65L,780L,10708L,154629L,2166536L,30213746L,423781213L,5929501986L,83127041136L,1164232610323L,16309719386435L,228474526845154L,3200565487849560L,44835398622377697L,628080583294667526L,8798521636340417779L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196639Inst : IEnumerable<long>
{
public static readonly long[] Value=A196639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196639.Bytes);
public long this[int i]=>Value[i];

public static A196639Inst Instance=new A196639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196640
{
public static readonly BigInteger[] Value={ 1L,161L,2716L,61040L,1359317L,30213746L,665532327L,14699136810L,324580294214L,7174373488843L,158475010595627L,3501133164138965L,77351575703021875L,1708953141696773382L,BigInteger.Parse("37756465985372614724"),BigInteger.Parse("834167580535337854517") };
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
public class A196640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196640Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196640.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196640.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196640Inst Instance=new A196640Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196641
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,5L,5L,1L,1L,10L,21L,10L,1L,1L,26L,62L,62L,26L,1L,1L,65L,232L,327L,232L,65L,1L,1L,161L,780L,1927L,1927L,780L,161L,1L,1L,403L,2716L,10708L,17518L,10708L,2716L,403L,1L,1L,1006L,9427L,61040L,154629L,154629L,61040L,9427L,1006L,1L,1L,2511L,32612L,344949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196641Inst : IEnumerable<long>
{
public static readonly long[] Value=A196641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196641.Bytes);
public long this[int i]=>Value[i];

public static A196641Inst Instance=new A196641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196642
{
public static readonly BigInteger[] Value={ 1L,1L,16L,129L,4273L,217880L,23946130L,5094296927L,2171426372387L,1837082082523359L,3094534584891471987L,BigInteger.Parse("10360619358796873163844"),BigInteger.Parse("68989834793646571143250669"),BigInteger.Parse("913590557002024874434691467840") };
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
public class A196642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196642Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196642.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196642.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196642Inst Instance=new A196642Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196643
{
public static readonly long[] Value={ 1L,17L,116L,667L,4273L,25118L,160347L,983193L,6087268L,37645887L,232843313L,1440449688L,8908661143L,55104054837L,340834463434L,2108162310301L,13039609400629L,80653777800732L,498867623140685L,3085643335339211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196643Inst : IEnumerable<long>
{
public static readonly long[] Value=A196643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196643.Bytes);
public long this[int i]=>Value[i];

public static A196643Inst Instance=new A196643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196644
{
public static readonly long[] Value={ 1L,41L,356L,2783L,25118L,217880L,1921822L,16668173L,146029787L,1275692776L,11144916533L,97386223456L,850945201900L,7435399467018L,64968547774607L,567683242015249L,4960297439355274L,43342029653468635L,378713657086113296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196644Inst : IEnumerable<long>
{
public static readonly long[] Value=A196644.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196644.Bytes);
public long this[int i]=>Value[i];

public static A196644Inst Instance=new A196644Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196645
{
public static readonly long[] Value={ 1L,99L,1068L,12515L,160347L,1921822L,23946130L,294598355L,3633351823L,44727792165L,551403942858L,6795075196272L,83731843282741L,1031848028281460L,12715479852445067L,156693802189196311L,1930948033440945770L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196645Inst : IEnumerable<long>
{
public static readonly long[] Value=A196645.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196645.Bytes);
public long this[int i]=>Value[i];

public static A196645Inst Instance=new A196645Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196646
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,3L,3L,1L,1L,7L,16L,7L,1L,1L,17L,37L,37L,17L,1L,1L,41L,116L,129L,116L,41L,1L,1L,99L,356L,667L,667L,356L,99L,1L,1L,239L,1068L,2783L,4273L,2783L,1068L,239L,1L,1L,577L,3217L,12515L,25118L,25118L,12515L,3217L,577L,1L,1L,1393L,9717L,55513L,160347L,217880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196646Inst : IEnumerable<long>
{
public static readonly long[] Value=A196646.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196646.Bytes);
public long this[int i]=>Value[i];

public static A196646Inst Instance=new A196646Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196647
{
public static readonly long[] Value={ 1L,7L,27L,391L,15289L,965315L,163282859L,65251102177L,58145917053607L,118692826575904321L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196647Inst : IEnumerable<long>
{
public static readonly long[] Value=A196647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196647.Bytes);
public long this[int i]=>Value[i];

public static A196647Inst Instance=new A196647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196648
{
public static readonly long[] Value={ 2L,10L,27L,76L,248L,735L,2178L,6622L,20006L,60256L,181914L,549017L,1656115L,4996932L,15077683L,45492308L,137261044L,414152752L,1249599381L,3770345250L,11376066317L,34324394098L,103565135609L,312481530333L,942833738234L,2844761508741L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196648Inst : IEnumerable<long>
{
public static readonly long[] Value=A196648.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196648.Bytes);
public long this[int i]=>Value[i];

public static A196648Inst Instance=new A196648Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196649
{
public static readonly long[] Value={ 3L,23L,76L,391L,1895L,8118L,37661L,172339L,791490L,3631677L,16619517L,76129750L,348810191L,1598275415L,7323187236L,33551912535L,153722248869L,704306601498L,3226924900161L,14784806391213L,67739415602004L,310360945033631L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196649Inst : IEnumerable<long>
{
public static readonly long[] Value=A196649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196649.Bytes);
public long this[int i]=>Value[i];

public static A196649Inst Instance=new A196649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196650
{
public static readonly long[] Value={ 5L,57L,248L,1895L,15289L,97292L,689313L,4940279L,34729760L,244473481L,1723635527L,12148477662L,85660331405L,603874547091L,4256603908016L,30006134374525L,211527978688847L,1491144741896136L,10511616761223147L,74100223117032273L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196650Inst : IEnumerable<long>
{
public static readonly long[] Value=A196650.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196650.Bytes);
public long this[int i]=>Value[i];

public static A196650Inst Instance=new A196650Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196651
{
public static readonly long[] Value={ 8L,122L,735L,8118L,97292L,965315L,10183698L,109227468L,1156876986L,12249728518L,129927163532L,1377786353021L,14609496269787L,154908775081008L,1642552525655091L,17416757261775288L,184678163033584910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196651Inst : IEnumerable<long>
{
public static readonly long[] Value=A196651.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196651.Bytes);
public long this[int i]=>Value[i];

public static A196651Inst Instance=new A196651Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196652
{
public static readonly ulong[] Value={ 13L,275L,2178L,37661L,689313L,10183698L,163282859L,2644969245L,42258577643L,676570815905L,10841400740070L,173671897740728L,2782146287996664L,44567043932430607L,713930349360876103L,11436736386929595699UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196652Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A196652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196652.Bytes);
public ulong this[int i]=>Value[i];

public static A196652Inst Instance=new A196652Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196653
{
public static readonly long[] Value={ 1L,1L,1L,2L,7L,2L,3L,10L,10L,3L,5L,23L,27L,23L,5L,8L,57L,76L,76L,57L,8L,13L,122L,248L,391L,248L,122L,13L,21L,275L,735L,1895L,1895L,735L,275L,21L,34L,623L,2178L,8118L,15289L,8118L,2178L,623L,34L,55L,1394L,6622L,37661L,97292L,97292L,37661L,6622L,1394L,55L,89L,3133L,20006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196653Inst : IEnumerable<long>
{
public static readonly long[] Value=A196653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196653.Bytes);
public long this[int i]=>Value[i];

public static A196653Inst Instance=new A196653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196654
{
public static readonly long[] Value={ 8L,3L,5L,4L,1L,9L,5L,1L,7L,9L,9L,1L,0L,5L,4L,6L,8L,8L,0L,4L,1L,5L,4L,3L,0L,2L,6L,1L,8L,2L,6L,8L,5L,2L,0L,4L,5L,3L,4L,7L,1L,4L,7L,8L,4L,9L,3L,6L,4L,5L,9L,7L,8L,1L,7L,6L,1L,7L,9L,0L,0L,2L,8L,2L,1L,4L,8L,0L,3L,6L,9L,6L,4L,2L,4L,8L,7L,6L,3L,3L,5L,1L,2L,7L,0L,2L,0L,9L,4L,8L,4L,7L,3L,5L,6L,3L,1L,3L,4L,9L,8L,1L,3L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196654Inst : IEnumerable<long>
{
public static readonly long[] Value=A196654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196654.Bytes);
public long this[int i]=>Value[i];

public static A196654Inst Instance=new A196654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196655
{
public static readonly long[] Value={ 73L,139L,271L,535L,1063L,2119L,4231L,8455L,16903L,33799L,67591L,135175L,270343L,540679L,1081351L,2162695L,4325383L,8650759L,17301511L,34603015L,69206023L,138412039L,276824071L,553648135L,1107296263L,2214592519L,4429185031L,8858370055L,17716740103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196655Inst : IEnumerable<long>
{
public static readonly long[] Value=A196655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196655.Bytes);
public long this[int i]=>Value[i];

public static A196655Inst Instance=new A196655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196656
{
public static readonly BigInteger[] Value={ 73L,139L,271L,1063L,4231L,16903L,270343L,540679L,1081351L,69206023L,276824071L,1107296263L,37154696925806599L,297237575406452743L,BigInteger.Parse("79789104094565525530607623"),BigInteger.Parse("326816170371340392573368795143"),BigInteger.Parse("334659758460252561995129646219271") };
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
public class A196656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196656Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196656.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196656.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196656Inst Instance=new A196656Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196657
{
public static readonly long[] Value={ 127L,253L,505L,1009L,2017L,4033L,8065L,16129L,32257L,64513L,129025L,258049L,516097L,1032193L,2064385L,4128769L,8257537L,16515073L,33030145L,66060289L,132120577L,264241153L,528482305L,1056964609L,2113929217L,4227858433L,8455716865L,16911433729L,33822867457L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196657Inst : IEnumerable<long>
{
public static readonly long[] Value=A196657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196657.Bytes);
public long this[int i]=>Value[i];

public static A196657Inst Instance=new A196657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196658
{
public static readonly BigInteger[] Value={ 127L,1009L,2017L,32257L,64513L,1032193L,8257537L,16515073L,132120577L,2113929217L,8658654068737L,17317308137473L,1108307720798209L,BigInteger.Parse("72634054790231359489"),BigInteger.Parse("2324289753287403503617"),BigInteger.Parse("1247843559599663317098317217793"),BigInteger.Parse("686009251712611942342163208582444714295297") };
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
public class A196658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196658Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196658.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196658.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196658Inst Instance=new A196658Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196659
{
public static readonly BigInteger[] Value={ 1L,1L,5L,53L,917L,22617L,735033L,29953065L,1479692909L,86472860573L,5868283305245L,455754185294737L,40032598733260945L,3938398783862213521L,BigInteger.Parse("430402127790139060725"),BigInteger.Parse("51882414924375353368677"),BigInteger.Parse("6856582955062676722110885"),BigInteger.Parse("988136808489380086666701225") };
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
public class A196659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196659Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196659.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196659.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196659Inst Instance=new A196659Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196660
{
public static readonly long[] Value={ 2L,1L,1L,1L,3L,1L,1L,2L,1L,1L,3L,1L,7L,2L,1L,1L,3L,2L,1L,2L,1L,1L,5L,1L,5L,3L,1L,2L,5L,1L,1L,3L,3L,1L,3L,1L,1L,2L,5L,1L,3L,1L,5L,2L,1L,2L,5L,3L,1L,2L,1L,1L,3L,1L,1L,2L,1L,2L,5L,2L,7L,6L,3L,1L,5L,1L,5L,3L,1L,1L,3L,4L,13L,5L,1L,1L,3L,2L,1L,2L,7L,1L,3L,1L,5L,2L,1L,2L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196660Inst : IEnumerable<long>
{
public static readonly long[] Value=A196660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196660.Bytes);
public long this[int i]=>Value[i];

public static A196660Inst Instance=new A196660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196661
{
public static readonly long[] Value={ 1L,5L,35L,245L,1715L,12005L,84035L,588245L,4117715L,28824005L,201768035L,1412376245L,9886633715L,69206436005L,484445052035L,3391115364245L,23737807549715L,166164652848005L,1163152569936035L,8142067989552245L,56994475926865715L,398961331488060005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196661Inst : IEnumerable<long>
{
public static readonly long[] Value=A196661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196661.Bytes);
public long this[int i]=>Value[i];

public static A196661Inst Instance=new A196661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196662
{
public static readonly BigInteger[] Value={ 1L,7L,70L,700L,7000L,70000L,700000L,7000000L,70000000L,700000000L,7000000000L,70000000000L,700000000000L,7000000000000L,70000000000000L,700000000000000L,7000000000000000L,70000000000000000L,700000000000000000L,7000000000000000000L,BigInteger.Parse("70000000000000000000") };
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
public class A196662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196662Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196662.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196662.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196662Inst Instance=new A196662Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196663
{
public static readonly BigInteger[] Value={ 1L,9L,117L,1521L,19773L,257049L,3341637L,43441281L,564736653L,7341576489L,95440494357L,1240726426641L,16129443546333L,209682766102329L,2725875959330277L,35436387471293601L,460673037126816813L,5988749482648618569L,BigInteger.Parse("77853743274432041397"),BigInteger.Parse("1012098662567616538161") };
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
public class A196663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196663Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196663.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196663.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196663Inst Instance=new A196663Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196664
{
public static readonly BigInteger[] Value={ 1L,11L,176L,2816L,45056L,720896L,11534336L,184549376L,2952790016L,47244640256L,755914244096L,12094627905536L,193514046488576L,3096224743817216L,49539595901075456L,792633534417207296L,12682136550675316736UL,BigInteger.Parse("202914184810805067776"),BigInteger.Parse("3246626956972881084416") };
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
public class A196664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196664.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196664Inst Instance=new A196664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196665
{
public static readonly BigInteger[] Value={ 1L,13L,247L,4693L,89167L,1694173L,32189287L,611596453L,11620332607L,220786319533L,4194940071127L,79703861351413L,1514373365676847L,28773093947860093L,546688785009341767L,10387086915177493573UL,BigInteger.Parse("197354651388372377887"),BigInteger.Parse("3749738376379075179853") };
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
public class A196665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196665Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196665.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196665.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196665Inst Instance=new A196665Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196666
{
public static readonly BigInteger[] Value={ 1L,15L,330L,7260L,159720L,3513840L,77304480L,1700698560L,37415368320L,823138103040L,18109038266880L,398398841871360L,8764774521169920L,192825039465738240L,4242150868246241280L,BigInteger.Parse("93327319101417308160"),BigInteger.Parse("2053201020231180779520"),BigInteger.Parse("45170422445085977149440") };
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
public class A196666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196666Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196666.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196666.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196666Inst Instance=new A196666Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196667
{
public static readonly long[] Value={ 109L,113L,139L,181L,197L,199L,241L,271L,281L,283L,293L,313L,317L,443L,449L,461L,463L,467L,479L,491L,503L,509L,523L,619L,643L,647L,653L,659L,661L,673L,677L,683L,691L,701L,761L,769L,773L,829L,859L,863L,883L,887L,1033L,1039L,1049L,1051L,1061L,1063L,1069L,1091L,1093L,1097L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196667Inst : IEnumerable<long>
{
public static readonly long[] Value=A196667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196667.Bytes);
public long this[int i]=>Value[i];

public static A196667Inst Instance=new A196667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196668
{
public static readonly long[] Value={ 17L,29L,41L,53L,61L,71L,83L,89L,101L,103L,113L,127L,137L,149L,151L,157L,193L,211L,239L,241L,251L,257L,269L,293L,307L,311L,313L,317L,331L,353L,359L,373L,379L,389L,397L,401L,433L,439L,443L,457L,461L,463L,479L,499L,503L,509L,521L,523L,569L,571L,577L,587L,593L,599L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196668Inst : IEnumerable<long>
{
public static readonly long[] Value=A196668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196668.Bytes);
public long this[int i]=>Value[i];

public static A196668Inst Instance=new A196668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196669
{
public static readonly long[] Value={ 11L,19L,29L,61L,71L,97L,101L,107L,109L,113L,127L,131L,149L,151L,173L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,257L,269L,281L,307L,311L,313L,317L,347L,349L,359L,373L,383L,389L,401L,409L,419L,421L,433L,439L,461L,479L,503L,509L,557L,563L,569L,571L,607L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196669Inst : IEnumerable<long>
{
public static readonly long[] Value=A196669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196669.Bytes);
public long this[int i]=>Value[i];

public static A196669Inst Instance=new A196669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196670
{
public static readonly long[] Value={ 5L,7L,17L,19L,31L,37L,41L,43L,53L,59L,67L,73L,79L,83L,101L,103L,107L,127L,131L,149L,157L,163L,179L,181L,197L,199L,211L,223L,227L,257L,269L,277L,281L,317L,331L,337L,347L,353L,379L,389L,419L,421L,439L,461L,463L,467L,479L,491L,499L,509L,541L,563L,569L,577L,617L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196670Inst : IEnumerable<long>
{
public static readonly long[] Value=A196670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196670.Bytes);
public long this[int i]=>Value[i];

public static A196670Inst Instance=new A196670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196671
{
public static readonly long[] Value={ 0L,0L,42L,516L,4498L,414123L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196671Inst : IEnumerable<long>
{
public static readonly long[] Value=A196671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196671.Bytes);
public long this[int i]=>Value[i];

public static A196671Inst Instance=new A196671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196672
{
public static readonly long[] Value={ 4L,26L,42L,126L,146L,162L,176L,470L,542L,1370L,1516L,4412L,8196L,14928L,27542L,30974L,51588L,62906L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196672Inst : IEnumerable<long>
{
public static readonly long[] Value=A196672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196672.Bytes);
public long this[int i]=>Value[i];

public static A196672Inst Instance=new A196672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196673
{
public static readonly long[] Value={ 109L,113L,139L,317L,887L,1327L,1913L,3089L,8297L,11177L,29761L,45707L,113383L,164893L,291377L,401417L,638371L,1045841L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196673Inst : IEnumerable<long>
{
public static readonly long[] Value=A196673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196673.Bytes);
public long this[int i]=>Value[i];

public static A196673Inst Instance=new A196673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196674
{
public static readonly long[] Value={ 510L,10271L,11259L,11987L,14730L,18772L,18884L,21845L,24083L,33723L,46789L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196674Inst : IEnumerable<long>
{
public static readonly long[] Value=A196674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196674.Bytes);
public long this[int i]=>Value[i];

public static A196674Inst Instance=new A196674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196675
{
public static readonly long[] Value={ 164051L,231299L,255919L,274177L,343517L,447827L,450451L,528167L,587519L,847607L,1209469L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196675Inst : IEnumerable<long>
{
public static readonly long[] Value=A196675.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196675.Bytes);
public long this[int i]=>Value[i];

public static A196675Inst Instance=new A196675Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196676
{
public static readonly BigInteger[] Value={ 1L,17L,425L,10625L,265625L,6640625L,166015625L,4150390625L,103759765625L,2593994140625L,64849853515625L,1621246337890625L,40531158447265625L,1013278961181640625L,BigInteger.Parse("25331974029541015625"),BigInteger.Parse("633299350738525390625") };
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
public class A196676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196676Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196676.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196676.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196676Inst Instance=new A196676Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196677
{
public static readonly long[] Value={ 30L,42L,330L,462L,681L,772L,824L,890L,989L,2180L,3030L,4242L,4542L,4722L,8074L,9775L,17331L,23980L,33330L,35823L,36213L,43263L,46662L,47324L,55805L,62121L,62421L,65301L,65451L,66441L,66741L,68181L,68331L,68631L,68781L,69171L,71215L,71452L,73565L,74391L,74417L,74572L,74972L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196677Inst : IEnumerable<long>
{
public static readonly long[] Value=A196677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196677.Bytes);
public long this[int i]=>Value[i];

public static A196677Inst Instance=new A196677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196678
{
public static readonly long[] Value={ 1L,5L,30L,200L,1425L,10626L,81900L,647280L,5217300L,42724825L,354465254L,2973052680L,25168220350L,214762810500L,1845308367000L,15951899986272L,138638564739180L,1210677947695620L,10617706139119000L,93477423115076000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196678Inst : IEnumerable<long>
{
public static readonly long[] Value=A196678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196678.Bytes);
public long this[int i]=>Value[i];

public static A196678Inst Instance=new A196678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196679
{
public static readonly long[] Value={ 1L,9L,58L,2245L,188078L,39696088L,23029545105L,36239510088523L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196679Inst : IEnumerable<long>
{
public static readonly long[] Value=A196679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196679.Bytes);
public long this[int i]=>Value[i];

public static A196679Inst Instance=new A196679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196680
{
public static readonly long[] Value={ 4L,20L,58L,292L,1235L,5186L,22461L,96256L,413032L,1780597L,7673860L,33017186L,142219489L,612618957L,2638803566L,11367909928L,48973948677L,210982341958L,908945163931L,3915948771137L,16870934284560L,72684969189462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196680Inst : IEnumerable<long>
{
public static readonly long[] Value=A196680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196680.Bytes);
public long this[int i]=>Value[i];

public static A196680Inst Instance=new A196680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196681
{
public static readonly long[] Value={ 5L,61L,292L,2245L,15395L,109528L,796557L,5702355L,40479328L,289195575L,2074543871L,14876511544L,106491873717L,761738952927L,5453371319038L,39065425553179L,279802106777205L,2003379491308618L,14343725864416775L,102713433223681069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196681Inst : IEnumerable<long>
{
public static readonly long[] Value=A196681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196681.Bytes);
public long this[int i]=>Value[i];

public static A196681Inst Instance=new A196681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196682
{
public static readonly long[] Value={ 9L,189L,1235L,15395L,188078L,2169685L,25142624L,291420839L,3417608122L,40048090008L,466852430720L,5449232674091L,63760228123954L,745737298355388L,8713522565183852L,101832009256003145L,1190660595164563844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196682Inst : IEnumerable<long>
{
public static readonly long[] Value=A196682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196682.Bytes);
public long this[int i]=>Value[i];

public static A196682Inst Instance=new A196682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196683
{
public static readonly BigInteger[] Value={ 16L,544L,5186L,109528L,2169685L,39696088L,741925729L,14189246566L,269528695666L,5096101360077L,96554573632988L,1834601649407584L,34805324258849319L,659906675083272359L,12522345994463073108UL,BigInteger.Parse("237662773521226652080") };
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
public class A196683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196683Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196683.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196683.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196683Inst Instance=new A196683Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196684
{
public static readonly BigInteger[] Value={ 25L,1629L,22461L,796557L,25142624L,741925729L,23029545105L,718199634805L,22138818455076L,682005890331480L,21125269566890884L,654095412346594187L,BigInteger.Parse("20229325302713363751"),BigInteger.Parse("625878086264793074895"),BigInteger.Parse("19368465617464223064077") };
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
public class A196684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196684Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196684.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196684.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196684Inst Instance=new A196684Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196685
{
public static readonly long[] Value={ 1L,3L,3L,4L,9L,4L,5L,20L,20L,5L,9L,61L,58L,61L,9L,16L,189L,292L,292L,189L,16L,25L,544L,1235L,2245L,1235L,544L,25L,39L,1629L,5186L,15395L,15395L,5186L,1629L,39L,64L,4973L,22461L,109528L,188078L,109528L,22461L,4973L,64L,105L,15040L,96256L,796557L,2169685L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196685Inst : IEnumerable<long>
{
public static readonly long[] Value=A196685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196685.Bytes);
public long this[int i]=>Value[i];

public static A196685Inst Instance=new A196685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196686
{
public static readonly long[] Value={ 1L,2L,1L,2L,3L,4L,3L,2L,3L,4L,5L,4L,5L,6L,7L,8L,7L,8L,7L,6L,5L,4L,3L,2L,3L,4L,3L,4L,3L,4L,5L,6L,5L,4L,3L,2L,1L,2L,3L,4L,5L,4L,5L,6L,7L,8L,9L,10L,11L,12L,11L,12L,11L,10L,9L,10L,11L,10L,11L,10L,9L,10L,11L,10L,11L,10L,11L,10L,11L,10L,9L,8L,7L,6L,5L,4L,3L,2L,1L,2L,3L,2L,1L,0L,-1L,-2L,-1L,-2L,-3L,-4L,-3L,-2L,-3L,-4L,-3L,-2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196686Inst : IEnumerable<long>
{
public static readonly long[] Value=A196686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196686.Bytes);
public long this[int i]=>Value[i];

public static A196686Inst Instance=new A196686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196687
{
public static readonly BigInteger[] Value={ 1L,4L,24L,336L,5520L,203040L,7025760L,510370560L,30163311360L,3577017024000L,319851801561600L,55850407258060800L,7021439018770176000L,BigInteger.Parse("1692163531361176473600"),BigInteger.Parse("284409062346887622144000"),BigInteger.Parse("90395009213694143422464000"),BigInteger.Parse("19571060809440210728706048000"),BigInteger.Parse("7929132907666579072319471616000") };
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
public class A196687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196687Inst Instance=new A196687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196688
{
public static readonly BigInteger[] Value={ 0L,0L,6L,120L,4440L,157680L,9187920L,557665920L,50759291520L,4795586208000L,636749560339200L,86796062772249600L,15877174512431232000UL,BigInteger.Parse("2953945462595410483200"),BigInteger.Parse("712801595188655900928000"),BigInteger.Parse("173684063741850454560768000"),BigInteger.Parse("53471242848053479728254976000"),BigInteger.Parse("16530628080065352033845256192000") };
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
public class A196688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196688Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196688.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196688.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196688Inst Instance=new A196688Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196689
{
public static readonly BigInteger[] Value={ 1L,5L,76L,3394L,546956L,279754939L,465819437152L,2520182960610600L,BigInteger.Parse("44155322347113863050"),BigInteger.Parse("2500562115488233367551895") };
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
public class A196689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196689Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196689.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196689.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196689Inst Instance=new A196689Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196690
{
public static readonly long[] Value={ 2L,5L,11L,34L,101L,299L,890L,2643L,7855L,23340L,69355L,206087L,612384L,1819689L,5407175L,16067330L,47743801L,141869903L,421564034L,1252670447L,3722289195L,11060719828L,32866743207L,97662975451L,290203891328L,862335989181L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196690Inst : IEnumerable<long>
{
public static readonly long[] Value=A196690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196690.Bytes);
public long this[int i]=>Value[i];

public static A196690Inst Instance=new A196690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196691
{
public static readonly long[] Value={ 3L,11L,76L,408L,2025L,10548L,55431L,289038L,1506376L,7857827L,40992713L,213825921L,1115337571L,5817828688L,30347027526L,158296067515L,825703442256L,4307033134922L,22466340292902L,117188887827705L,611280485474823L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196691Inst : IEnumerable<long>
{
public static readonly long[] Value=A196691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196691.Bytes);
public long this[int i]=>Value[i];

public static A196691Inst Instance=new A196691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196692
{
public static readonly long[] Value={ 4L,34L,408L,3394L,30971L,299031L,2810070L,26244524L,246996575L,2321651409L,21799587340L,204807147248L,1924170449803L,18075934246323L,169812333953160L,1595296606004722L,14986865956373055L,140792748879421565L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196692Inst : IEnumerable<long>
{
public static readonly long[] Value=A196692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196692.Bytes);
public long this[int i]=>Value[i];

public static A196692Inst Instance=new A196692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196693
{
public static readonly ulong[] Value={ 6L,101L,2025L,30971L,546956L,9357578L,155701871L,2639528950L,44828048153L,758613680168L,12846211728943L,217575496074187L,3684345603278538L,62394309228790776L,1056662398209397764L,17894419295053374921UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196693Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A196693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196693.Bytes);
public ulong this[int i]=>Value[i];

public static A196693Inst Instance=new A196693Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196694
{
public static readonly BigInteger[] Value={ 9L,299L,10548L,299031L,9357578L,279754939L,8471917814L,259951215394L,7909511305426L,240483051204609L,7323897043978887L,223005036035867054L,6789276300324773462L,BigInteger.Parse("206701527466790215255"),BigInteger.Parse("6293073883527501713425") };
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
public class A196694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196694Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196694.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196694.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196694Inst Instance=new A196694Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196695
{
public static readonly BigInteger[] Value={ 13L,890L,55431L,2810070L,155701871L,8471917814L,465819437152L,25583402376768L,1398455518363119L,76661027104639150L,4203790099076060084L,BigInteger.Parse("230345827821159257944"),BigInteger.Parse("12623159468847996681154"),BigInteger.Parse("691830641310960796256835") };
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
public class A196695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196695Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196695.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196695.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196695Inst Instance=new A196695Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196696
{
public static readonly long[] Value={ 1L,2L,2L,3L,5L,3L,4L,11L,11L,4L,6L,34L,76L,34L,6L,9L,101L,408L,408L,101L,9L,13L,299L,2025L,3394L,2025L,299L,13L,19L,890L,10548L,30971L,30971L,10548L,890L,19L,28L,2643L,55431L,299031L,546956L,299031L,55431L,2643L,28L,41L,7855L,289038L,2810070L,9357578L,9357578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196696Inst : IEnumerable<long>
{
public static readonly long[] Value=A196696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196696.Bytes);
public long this[int i]=>Value[i];

public static A196696Inst Instance=new A196696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196697
{
public static readonly long[] Value={ 1L,4L,5L,6L,7L,9L,7L,11L,10L,12L,7L,12L,8L,12L,9L,14L,11L,19L,13L,22L,7L,9L,11L,16L,4L,8L,9L,7L,12L,18L,14L,15L,11L,10L,10L,18L,8L,12L,11L,18L,12L,23L,5L,12L,13L,16L,13L,22L,8L,9L,16L,13L,9L,13L,14L,11L,11L,10L,10L,20L,15L,10L,10L,13L,9L,22L,11L,10L,10L,12L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196697Inst : IEnumerable<long>
{
public static readonly long[] Value=A196697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196697.Bytes);
public long this[int i]=>Value[i];

public static A196697Inst Instance=new A196697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196698
{
public static readonly long[] Value={ 2L,4L,6L,8L,7L,11L,7L,10L,11L,11L,8L,10L,9L,11L,14L,11L,10L,14L,7L,16L,12L,12L,7L,17L,10L,7L,15L,13L,4L,11L,11L,11L,13L,6L,12L,18L,9L,12L,17L,14L,13L,11L,10L,11L,13L,6L,7L,17L,9L,14L,9L,10L,13L,20L,8L,11L,10L,9L,8L,16L,12L,12L,13L,8L,12L,14L,8L,8L,10L,13L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196698Inst : IEnumerable<long>
{
public static readonly long[] Value=A196698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196698.Bytes);
public long this[int i]=>Value[i];

public static A196698Inst Instance=new A196698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196699
{
public static readonly long[] Value={ 1L,11L,207L,16676L,4114365L,3444722540L,9630587515529L,90075372757265811L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196699Inst : IEnumerable<long>
{
public static readonly long[] Value=A196699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196699.Bytes);
public long this[int i]=>Value[i];

public static A196699Inst Instance=new A196699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196700
{
public static readonly long[] Value={ 1L,2L,4L,6L,12L,22L,40L,74L,136L,250L,460L,846L,1556L,2862L,5264L,9682L,17808L,32754L,60244L,110806L,203804L,374854L,689464L,1268122L,2332440L,4290026L,7890588L,14513054L,26693668L,49097310L,90304032L,166095010L,305496352L,561895394L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196700Inst : IEnumerable<long>
{
public static readonly long[] Value=A196700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196700.Bytes);
public long this[int i]=>Value[i];

public static A196700Inst Instance=new A196700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196701
{
public static readonly long[] Value={ 2L,11L,38L,136L,488L,1744L,6208L,22202L,79292L,282984L,1010760L,3609442L,12887556L,46021868L,164340008L,586827146L,2095503116L,7482801488L,26720080488L,95414259450L,340712829860L,1216643200052L,4344485254120L,15513628195858L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196701Inst : IEnumerable<long>
{
public static readonly long[] Value=A196701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196701.Bytes);
public long this[int i]=>Value[i];

public static A196701Inst Instance=new A196701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196702
{
public static readonly long[] Value={ 4L,38L,207L,1366L,8672L,55436L,353591L,2257739L,14423220L,92115943L,588320201L,3757410951L,23997532467L,153266354657L,978872278459L,6251798756146L,39928597422454L,255013470704155L,1628704187503479L,10402106496493731L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196702Inst : IEnumerable<long>
{
public static readonly long[] Value=A196702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196702.Bytes);
public long this[int i]=>Value[i];

public static A196702Inst Instance=new A196702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196703
{
public static readonly long[] Value={ 6L,136L,1366L,16676L,193326L,2264381L,26495227L,310276380L,3632827590L,42527506151L,497870194993L,5828719769741L,68238349389070L,798880050071593L,9352648440980667L,109493443755493253L,1281863203314446240L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A196703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196703Inst : IEnumerable<long>
{
public static readonly long[] Value=A196703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A196703.Bytes);
public long this[int i]=>Value[i];

public static A196703Inst Instance=new A196703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A196704
{
public static readonly BigInteger[] Value={ 12L,488L,8672L,193326L,4114365L,88057485L,1883754015L,40313628190L,862817869506L,18466264182264L,395214121573203L,8458285032169106L,181022745479257594L,3874225541604098047L,BigInteger.Parse("82915675332387910699"),BigInteger.Parse("1774550041727447332819") };
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
public class A196704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A196704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A196704Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A196704.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A196704.Bytes);
public BigInteger this[int i]=>Value[i];

public static A196704Inst Instance=new A196704Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}