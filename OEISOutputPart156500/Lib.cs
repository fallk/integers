using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A199605
{
public static readonly long[] Value={ 9L,3L,0L,4L,9L,5L,0L,0L,2L,6L,3L,5L,9L,7L,0L,1L,0L,9L,7L,6L,3L,3L,4L,1L,0L,2L,4L,0L,2L,5L,4L,7L,8L,5L,1L,2L,5L,8L,6L,4L,4L,8L,8L,2L,4L,4L,1L,4L,8L,8L,7L,7L,2L,8L,1L,5L,2L,2L,7L,2L,8L,2L,8L,2L,0L,8L,3L,0L,6L,9L,2L,4L,0L,1L,9L,7L,5L,5L,2L,4L,2L,5L,1L,0L,1L,9L,2L,8L,9L,1L,3L,1L,7L,8L,3L,6L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199605Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199605.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199605Inst : IEnumerable<long>
{
public static readonly long[] Value=A199605.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199605.Bytes);
public long this[int i]=>Value[i];

public static A199605Inst Instance=new A199605Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199606
{
public static readonly long[] Value={ 3L,0L,1L,7L,9L,6L,3L,0L,8L,1L,0L,6L,8L,6L,2L,8L,8L,7L,2L,6L,6L,7L,8L,1L,4L,4L,3L,3L,8L,8L,5L,7L,6L,8L,9L,7L,0L,3L,7L,8L,3L,2L,7L,2L,9L,4L,7L,3L,8L,3L,3L,3L,0L,9L,4L,0L,6L,2L,7L,6L,8L,4L,4L,5L,7L,5L,7L,0L,0L,2L,3L,7L,8L,0L,9L,9L,2L,1L,2L,9L,5L,1L,4L,6L,0L,3L,3L,7L,8L,7L,6L,8L,4L,3L,4L,7L,5L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199606Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199606.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199606Inst : IEnumerable<long>
{
public static readonly long[] Value=A199606.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199606.Bytes);
public long this[int i]=>Value[i];

public static A199606Inst Instance=new A199606Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199607
{
public static readonly long[] Value={ 5L,9L,7L,3L,3L,9L,2L,5L,0L,3L,6L,4L,8L,5L,3L,9L,7L,5L,0L,0L,4L,9L,7L,3L,6L,1L,3L,5L,9L,9L,7L,6L,6L,9L,0L,2L,8L,3L,3L,1L,8L,5L,7L,5L,6L,4L,1L,8L,4L,9L,2L,4L,1L,1L,3L,2L,7L,4L,2L,3L,8L,5L,1L,2L,2L,2L,8L,8L,6L,9L,5L,9L,3L,7L,4L,7L,8L,7L,0L,0L,7L,9L,2L,5L,4L,4L,7L,4L,1L,3L,0L,9L,1L,3L,3L,4L,4L,3L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199607Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199607.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199607Inst : IEnumerable<long>
{
public static readonly long[] Value=A199607.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199607.Bytes);
public long this[int i]=>Value[i];

public static A199607Inst Instance=new A199607Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199608
{
public static readonly long[] Value={ 3L,0L,4L,8L,1L,3L,8L,5L,9L,5L,3L,6L,5L,1L,1L,6L,6L,8L,9L,1L,4L,4L,6L,0L,5L,0L,5L,9L,3L,7L,3L,9L,0L,5L,2L,2L,0L,8L,5L,4L,6L,4L,6L,8L,6L,6L,9L,9L,5L,5L,4L,2L,6L,9L,2L,1L,5L,9L,2L,4L,3L,6L,0L,5L,4L,8L,2L,5L,1L,2L,3L,3L,6L,9L,6L,4L,0L,1L,1L,0L,6L,2L,4L,0L,2L,2L,9L,6L,6L,8L,6L,6L,4L,7L,6L,6L,7L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199608Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199608.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199608Inst : IEnumerable<long>
{
public static readonly long[] Value=A199608.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199608.Bytes);
public long this[int i]=>Value[i];

public static A199608Inst Instance=new A199608Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199609
{
public static readonly long[] Value={ 1L,1L,4L,2L,2L,5L,6L,4L,0L,2L,2L,4L,4L,7L,4L,0L,1L,1L,0L,0L,4L,4L,6L,1L,5L,8L,7L,8L,2L,3L,5L,8L,6L,4L,3L,5L,2L,5L,1L,5L,3L,4L,4L,8L,3L,4L,4L,5L,7L,6L,4L,5L,7L,4L,8L,1L,0L,1L,7L,4L,4L,4L,6L,2L,4L,3L,1L,6L,6L,5L,1L,6L,7L,4L,3L,3L,7L,0L,9L,4L,5L,1L,6L,0L,9L,7L,2L,6L,6L,3L,4L,9L,3L,4L,7L,6L,2L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199609Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199609.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199609Inst : IEnumerable<long>
{
public static readonly long[] Value=A199609.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199609.Bytes);
public long this[int i]=>Value[i];

public static A199609Inst Instance=new A199609Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199610
{
public static readonly long[] Value={ 3L,0L,6L,5L,6L,2L,0L,7L,6L,0L,3L,3L,6L,8L,5L,8L,5L,6L,1L,8L,6L,7L,4L,5L,7L,5L,5L,2L,8L,5L,0L,8L,2L,1L,3L,2L,5L,0L,6L,5L,4L,0L,2L,0L,6L,8L,2L,0L,1L,7L,0L,6L,2L,6L,3L,9L,9L,4L,5L,6L,9L,0L,5L,4L,3L,3L,1L,2L,5L,4L,8L,2L,7L,3L,8L,3L,4L,7L,4L,3L,0L,4L,4L,5L,7L,0L,8L,1L,7L,8L,0L,0L,8L,7L,6L,1L,4L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199610Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199610.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199610Inst : IEnumerable<long>
{
public static readonly long[] Value=A199610.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199610.Bytes);
public long this[int i]=>Value[i];

public static A199610Inst Instance=new A199610Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199611
{
public static readonly long[] Value={ 1L,2L,5L,2L,3L,5L,3L,2L,3L,4L,0L,0L,2L,5L,8L,8L,7L,6L,3L,1L,8L,6L,3L,2L,8L,1L,2L,1L,9L,7L,5L,3L,8L,0L,4L,3L,5L,9L,0L,1L,2L,8L,0L,6L,1L,0L,5L,6L,6L,1L,8L,9L,9L,9L,2L,3L,8L,6L,1L,4L,4L,3L,1L,3L,0L,8L,0L,8L,0L,2L,4L,1L,3L,3L,5L,3L,2L,6L,7L,5L,6L,7L,8L,9L,0L,9L,6L,2L,7L,6L,9L,1L,9L,2L,7L,6L,2L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199611Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199611.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199611Inst : IEnumerable<long>
{
public static readonly long[] Value=A199611.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199611.Bytes);
public long this[int i]=>Value[i];

public static A199611Inst Instance=new A199611Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199612
{
public static readonly long[] Value={ 3L,5L,9L,5L,3L,0L,4L,8L,6L,7L,1L,6L,1L,5L,4L,7L,9L,9L,1L,8L,7L,7L,6L,0L,6L,9L,3L,5L,0L,8L,3L,4L,1L,8L,7L,1L,4L,9L,1L,3L,1L,1L,1L,4L,3L,7L,7L,7L,5L,5L,2L,9L,3L,2L,5L,1L,8L,5L,5L,2L,2L,4L,8L,6L,9L,1L,2L,8L,2L,5L,3L,0L,1L,8L,4L,3L,4L,6L,3L,7L,8L,9L,3L,9L,0L,1L,3L,7L,9L,2L,1L,4L,0L,7L,2L,6L,9L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199612Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199612.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199612Inst : IEnumerable<long>
{
public static readonly long[] Value=A199612.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199612.Bytes);
public long this[int i]=>Value[i];

public static A199612Inst Instance=new A199612Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199613
{
public static readonly long[] Value={ 1L,0L,7L,7L,3L,0L,9L,9L,1L,7L,5L,2L,4L,0L,7L,2L,0L,3L,0L,3L,3L,9L,9L,7L,9L,6L,1L,5L,1L,2L,6L,8L,1L,3L,6L,6L,4L,7L,9L,1L,6L,5L,3L,9L,9L,5L,8L,3L,8L,5L,8L,7L,9L,3L,4L,0L,9L,3L,3L,1L,5L,0L,2L,2L,5L,4L,2L,0L,7L,7L,4L,2L,2L,3L,3L,2L,4L,7L,1L,0L,7L,3L,0L,2L,3L,3L,9L,5L,0L,3L,9L,8L,7L,4L,5L,2L,2L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199613Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199613.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199613Inst : IEnumerable<long>
{
public static readonly long[] Value=A199613.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199613.Bytes);
public long this[int i]=>Value[i];

public static A199613Inst Instance=new A199613Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199614
{
public static readonly long[] Value={ 3L,5L,5L,3L,2L,4L,1L,6L,8L,0L,6L,8L,2L,8L,9L,2L,5L,2L,3L,9L,5L,7L,2L,6L,5L,5L,5L,6L,2L,3L,4L,4L,9L,4L,9L,0L,2L,0L,6L,7L,7L,6L,2L,6L,1L,8L,6L,1L,7L,2L,3L,9L,1L,5L,4L,2L,8L,6L,0L,0L,4L,2L,8L,8L,8L,6L,6L,0L,4L,0L,7L,4L,9L,0L,2L,5L,6L,2L,7L,1L,6L,0L,1L,8L,7L,4L,7L,3L,5L,7L,2L,1L,8L,0L,8L,2L,6L,7L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199614Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199614.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199614Inst : IEnumerable<long>
{
public static readonly long[] Value=A199614.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199614.Bytes);
public long this[int i]=>Value[i];

public static A199614Inst Instance=new A199614Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199615
{
public static readonly long[] Value={ 8L,5L,6L,3L,7L,4L,0L,4L,9L,7L,4L,4L,3L,4L,6L,1L,0L,9L,3L,2L,2L,0L,7L,8L,0L,6L,2L,5L,6L,4L,7L,2L,9L,1L,9L,9L,4L,7L,6L,6L,0L,0L,5L,0L,8L,8L,7L,5L,4L,8L,2L,4L,0L,9L,4L,3L,3L,1L,0L,1L,4L,8L,8L,7L,0L,6L,8L,7L,1L,6L,7L,3L,4L,6L,5L,9L,9L,3L,0L,2L,8L,3L,6L,5L,7L,7L,2L,0L,9L,8L,7L,5L,0L,6L,7L,2L,6L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199615Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199615.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199615Inst : IEnumerable<long>
{
public static readonly long[] Value=A199615.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199615.Bytes);
public long this[int i]=>Value[i];

public static A199615Inst Instance=new A199615Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199616
{
public static readonly long[] Value={ 3L,5L,1L,5L,6L,1L,3L,1L,9L,9L,6L,8L,7L,3L,5L,8L,0L,2L,3L,8L,4L,2L,1L,8L,0L,2L,1L,0L,7L,0L,4L,0L,3L,0L,7L,9L,2L,2L,1L,7L,8L,8L,8L,8L,6L,7L,9L,8L,1L,9L,3L,3L,5L,0L,7L,3L,8L,3L,3L,3L,5L,6L,9L,7L,8L,4L,4L,2L,4L,3L,4L,5L,9L,1L,6L,5L,7L,2L,6L,4L,8L,5L,7L,2L,3L,9L,2L,0L,0L,0L,7L,5L,7L,6L,0L,2L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199616Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199616.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199616Inst : IEnumerable<long>
{
public static readonly long[] Value=A199616.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199616.Bytes);
public long this[int i]=>Value[i];

public static A199616Inst Instance=new A199616Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199617
{
public static readonly long[] Value={ 5L,5L,3L,5L,4L,3L,3L,8L,1L,7L,8L,6L,0L,3L,3L,6L,2L,8L,7L,0L,2L,0L,3L,4L,4L,9L,0L,5L,9L,1L,1L,8L,1L,6L,9L,3L,0L,4L,0L,6L,3L,2L,5L,8L,0L,1L,1L,9L,4L,8L,5L,5L,2L,5L,1L,2L,7L,6L,2L,5L,4L,7L,5L,2L,7L,1L,3L,8L,3L,1L,4L,4L,4L,4L,6L,9L,3L,7L,3L,9L,8L,3L,1L,0L,6L,3L,4L,6L,4L,5L,4L,9L,0L,8L,8L,0L,0L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199617Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199617.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199617Inst : IEnumerable<long>
{
public static readonly long[] Value=A199617.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199617.Bytes);
public long this[int i]=>Value[i];

public static A199617Inst Instance=new A199617Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199618
{
public static readonly long[] Value={ 3L,4L,8L,2L,2L,6L,7L,6L,2L,4L,7L,8L,6L,1L,9L,3L,2L,0L,9L,0L,8L,6L,7L,0L,3L,6L,6L,7L,5L,5L,7L,6L,8L,0L,3L,7L,0L,7L,6L,2L,6L,9L,3L,1L,5L,6L,9L,4L,5L,6L,0L,3L,6L,9L,3L,8L,3L,9L,7L,6L,9L,9L,3L,4L,9L,0L,0L,4L,8L,4L,2L,1L,8L,7L,6L,3L,9L,8L,5L,1L,0L,8L,3L,9L,9L,3L,9L,4L,9L,6L,8L,6L,4L,8L,5L,8L,9L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199618Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199618.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199618Inst : IEnumerable<long>
{
public static readonly long[] Value=A199618.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199618.Bytes);
public long this[int i]=>Value[i];

public static A199618Inst Instance=new A199618Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199619
{
public static readonly long[] Value={ 8L,0L,0L,0L,5L,3L,3L,4L,2L,6L,2L,7L,4L,1L,5L,7L,5L,9L,3L,6L,8L,5L,9L,0L,2L,7L,9L,9L,0L,8L,9L,3L,3L,2L,1L,9L,6L,3L,2L,4L,4L,6L,5L,3L,4L,4L,8L,6L,4L,6L,6L,6L,1L,1L,0L,4L,6L,2L,1L,6L,6L,9L,1L,9L,5L,3L,4L,1L,3L,1L,1L,0L,2L,7L,7L,5L,0L,4L,3L,4L,1L,5L,9L,6L,8L,4L,1L,0L,1L,2L,2L,2L,9L,0L,1L,5L,2L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199619Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199619.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199619Inst : IEnumerable<long>
{
public static readonly long[] Value=A199619.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199619.Bytes);
public long this[int i]=>Value[i];

public static A199619Inst Instance=new A199619Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199620
{
public static readonly long[] Value={ 3L,4L,5L,2L,8L,9L,9L,8L,8L,8L,5L,3L,2L,9L,2L,7L,7L,8L,0L,3L,3L,6L,3L,0L,0L,8L,3L,7L,8L,6L,4L,9L,8L,3L,8L,8L,4L,0L,8L,8L,3L,6L,8L,5L,5L,6L,5L,7L,8L,5L,1L,5L,3L,8L,6L,4L,0L,5L,6L,2L,7L,2L,9L,0L,9L,5L,5L,1L,8L,5L,6L,4L,0L,8L,5L,9L,2L,4L,4L,5L,4L,6L,8L,3L,0L,5L,7L,0L,2L,5L,8L,4L,9L,8L,6L,0L,9L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199620Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199620.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199620Inst : IEnumerable<long>
{
public static readonly long[] Value=A199620.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199620.Bytes);
public long this[int i]=>Value[i];

public static A199620Inst Instance=new A199620Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199621
{
public static readonly long[] Value={ 4L,5L,0L,1L,8L,3L,6L,1L,1L,2L,9L,4L,8L,7L,3L,5L,7L,3L,0L,3L,6L,5L,3L,8L,6L,9L,6L,7L,6L,2L,6L,8L,1L,8L,2L,7L,3L,2L,0L,1L,3L,6L,5L,0L,1L,7L,2L,3L,0L,5L,5L,4L,3L,4L,0L,1L,5L,0L,5L,8L,4L,9L,1L,3L,6L,3L,6L,4L,1L,5L,6L,6L,9L,8L,5L,2L,2L,3L,3L,7L,9L,5L,4L,7L,4L,1L,4L,1L,3L,3L,0L,6L,9L,9L,2L,3L,1L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199621Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199621.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199621Inst : IEnumerable<long>
{
public static readonly long[] Value=A199621.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199621.Bytes);
public long this[int i]=>Value[i];

public static A199621Inst Instance=new A199621Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199622
{
public static readonly long[] Value={ 5L,2L,1L,7L,7L,0L,5L,3L,3L,6L,3L,0L,4L,1L,5L,9L,0L,7L,6L,0L,2L,2L,2L,6L,7L,1L,7L,5L,2L,3L,9L,3L,7L,8L,8L,2L,9L,5L,7L,5L,1L,0L,8L,9L,8L,0L,1L,9L,0L,1L,6L,1L,5L,6L,1L,5L,0L,9L,6L,0L,0L,6L,2L,7L,2L,1L,1L,0L,4L,7L,2L,8L,7L,3L,1L,4L,9L,5L,9L,6L,8L,5L,8L,0L,7L,2L,5L,8L,7L,8L,1L,8L,9L,8L,2L,5L,1L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199622Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199622.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199622Inst : IEnumerable<long>
{
public static readonly long[] Value=A199622.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199622.Bytes);
public long this[int i]=>Value[i];

public static A199622Inst Instance=new A199622Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199623
{
public static readonly long[] Value={ 9L,9L,2L,2L,9L,1L,7L,9L,4L,9L,1L,6L,1L,1L,7L,6L,9L,8L,1L,8L,4L,1L,1L,9L,3L,3L,8L,5L,0L,1L,7L,5L,7L,4L,7L,5L,0L,7L,7L,1L,2L,0L,7L,8L,2L,7L,0L,7L,3L,9L,8L,0L,6L,9L,9L,6L,6L,6L,7L,7L,4L,0L,5L,7L,3L,7L,6L,2L,8L,7L,1L,8L,8L,3L,1L,4L,8L,6L,5L,8L,8L,9L,7L,1L,7L,7L,3L,3L,2L,1L,4L,1L,0L,1L,5L,9L,5L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199623Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199623.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199623Inst : IEnumerable<long>
{
public static readonly long[] Value=A199623.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199623.Bytes);
public long this[int i]=>Value[i];

public static A199623Inst Instance=new A199623Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199624
{
public static readonly long[] Value={ 1L,3L,3L,8L,8L,7L,3L,8L,8L,9L,8L,5L,5L,4L,8L,5L,2L,6L,4L,0L,6L,2L,5L,5L,4L,1L,5L,4L,7L,5L,4L,3L,5L,2L,9L,1L,5L,6L,4L,7L,1L,6L,6L,9L,4L,4L,9L,9L,8L,4L,0L,9L,2L,9L,2L,0L,4L,5L,9L,2L,9L,2L,1L,3L,4L,5L,3L,9L,8L,8L,4L,8L,7L,3L,1L,6L,6L,9L,0L,2L,5L,1L,4L,9L,1L,7L,5L,5L,7L,6L,1L,5L,0L,2L,2L,6L,0L,9L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199624Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199624.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199624Inst : IEnumerable<long>
{
public static readonly long[] Value=A199624.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199624.Bytes);
public long this[int i]=>Value[i];

public static A199624Inst Instance=new A199624Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199625
{
public static readonly long[] Value={ 4L,2L,5L,7L,1L,1L,4L,2L,3L,2L,3L,6L,2L,8L,2L,9L,5L,5L,0L,2L,7L,8L,5L,0L,2L,3L,0L,7L,9L,0L,3L,4L,1L,3L,2L,6L,9L,2L,8L,6L,5L,8L,1L,3L,7L,3L,5L,0L,8L,9L,3L,7L,8L,2L,7L,7L,8L,7L,8L,9L,7L,7L,8L,4L,6L,8L,1L,5L,7L,1L,1L,7L,1L,9L,8L,7L,5L,4L,7L,7L,3L,9L,5L,2L,5L,2L,4L,6L,5L,2L,0L,7L,8L,3L,7L,5L,9L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199625Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199625.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199625Inst : IEnumerable<long>
{
public static readonly long[] Value=A199625.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199625.Bytes);
public long this[int i]=>Value[i];

public static A199625Inst Instance=new A199625Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199626
{
public static readonly long[] Value={ 0L,-4L,-6L,-8L,-7L,-12L,-13L,-16L,-14L,-20L,-20L,-24L,-21L,-28L,-27L,-32L,-28L,-36L,-34L,-40L,-35L,-44L,-41L,-48L,-42L,-52L,-48L,-56L,-49L,-60L,-55L,-64L,-56L,-68L,-62L,-72L,-63L,-76L,-69L,-80L,-70L,-84L,-76L,-88L,-77L,-92L,-83L,-96L,-84L,-100L,-90L,-104L,-91L,-108L,-97L,-112L,-98L,-116L,-104L,-120L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199626Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199626.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199626Inst : IEnumerable<long>
{
public static readonly long[] Value=A199626.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199626.Bytes);
public long this[int i]=>Value[i];

public static A199626Inst Instance=new A199626Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199627
{
public static readonly long[] Value={ 1L,2L,1L,1L,2L,2L,4L,7L,8L,9L,12L,15L,16L,17L,20L,23L,24L,25L,28L,31L,32L,33L,36L,39L,40L,41L,44L,47L,48L,49L,52L,55L,56L,57L,60L,63L,64L,65L,68L,71L,72L,73L,76L,79L,80L,81L,84L,87L,88L,89L,92L,95L,96L,97L,100L,103L,104L,105L,108L,111L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199627Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199627.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199627Inst : IEnumerable<long>
{
public static readonly long[] Value=A199627.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199627.Bytes);
public long this[int i]=>Value[i];

public static A199627Inst Instance=new A199627Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199628
{
public static readonly long[] Value={ 1L,4L,7L,14L,32L,50L,71L,122L,185L,238L,319L,430L,528L,626L,752L,884L,1000L,1116L,1249L,1384L,1503L,1620L,1753L,1888L,2007L,2124L,2257L,2392L,2511L,2628L,2761L,2896L,3015L,3132L,3265L,3400L,3519L,3636L,3769L,3904L,4023L,4140L,4273L,4408L,4527L,4644L,4777L,4912L,5031L,5148L,5281L,5416L,5535L,5652L,5785L,5920L,6039L,6156L,6289L,6424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199628Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199628.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199628Inst : IEnumerable<long>
{
public static readonly long[] Value=A199628.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199628.Bytes);
public long this[int i]=>Value[i];

public static A199628Inst Instance=new A199628Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199629
{
public static readonly long[] Value={ 1L,6L,16L,35L,86L,182L,317L,558L,975L,1514L,2249L,3366L,4749L,6338L,8417L,10920L,13563L,16538L,19961L,23514L,27123L,30974L,34997L,38994L,42972L,47048L,51197L,55285L,59313L,63408L,67567L,71660L,75689L,79784L,83943L,88036L,92065L,96160L,100319L,104412L,108441L,112536L,116695L,120788L,124817L,128912L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199629Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199629.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199629Inst : IEnumerable<long>
{
public static readonly long[] Value=A199629.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199629.Bytes);
public long this[int i]=>Value[i];

public static A199629Inst Instance=new A199629Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199630
{
public static readonly long[] Value={ 3175462089L,3175804269L,3204957816L,3206549178L,3210754689L,3254196708L,3260974851L,3275409816L,3284591706L,3290581476L,3406829517L,3410856297L,3459186720L,3469857012L,3475806912L,3501249678L,3512067849L,3519876240L,3549716208L,3564980172L,3587902614L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199630Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199630.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199630Inst : IEnumerable<long>
{
public static readonly long[] Value=A199630.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199630.Bytes);
public long this[int i]=>Value[i];

public static A199630Inst Instance=new A199630Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199631
{
public static readonly long[] Value={ 4680215379L,4752360918L,4765380219L,4915280637L,5063248197L,5164738920L,5382417906L,5426370189L,5429013678L,5628130974L,5679321048L,5697841320L,5762831940L,5783610492L,5786430129L,5903467821L,6019285734L,6053147982L,6095721483L,6143720958L,6158723094L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199631Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199631.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199631Inst : IEnumerable<long>
{
public static readonly long[] Value=A199631.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199631.Bytes);
public long this[int i]=>Value[i];

public static A199631Inst Instance=new A199631Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199632
{
public static readonly long[] Value={ 7351062489L,8105632794L,8401253976L,8731945026L,9164072385L,9238750614L,9615278340L,9847103256L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199632Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199632.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199632Inst : IEnumerable<long>
{
public static readonly long[] Value=A199632.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199632.Bytes);
public long this[int i]=>Value[i];

public static A199632Inst Instance=new A199632Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199633
{
public static readonly long[] Value={ 7025869314L,7143258096L,7931584062L,8094273561L,8920416357L,9247560381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199633Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199633.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199633Inst : IEnumerable<long>
{
public static readonly long[] Value=A199633.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199633.Bytes);
public long this[int i]=>Value[i];

public static A199633Inst Instance=new A199633Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199634
{
public static readonly long[] Value={ 3265920L,534L,74L,13L,8L,6L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199634Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199634.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199634Inst : IEnumerable<long>
{
public static readonly long[] Value=A199634.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199634.Bytes);
public long this[int i]=>Value[i];

public static A199634Inst Instance=new A199634Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199635
{
public static readonly long[] Value={ 8L,9L,11L,19L,20L,27L,29L,38L,49L,55L,57L,64L,66L,67L,74L,78L,87L,104L,105L,114L,122L,154L,171L,179L,198L,202L,211L,237L,249L,250L,276L,295L,297L,315L,343L,373L,390L,393L,399L,428L,429L,441L,479L,485L,489L,497L,534L,535L,583L,604L,610L,619L,690L,767L,786L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199635Inst : IEnumerable<long>
{
public static readonly long[] Value=A199635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199635.Bytes);
public long this[int i]=>Value[i];

public static A199635Inst Instance=new A199635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199636
{
public static readonly long[] Value={ 5L,3L,21L,13L,85L,17L,53L,11L,35L,113L,341L,7L,23L,69L,75L,213L,227L,15L,45L,141L,151L,453L,1365L,9L,29L,93L,277L,301L,853L,909L,19L,61L,181L,201L,565L,605L,1813L,5461L,37L,117L,369L,373L,401L,403L,1109L,1137L,1205L,3413L,3637L,25L,77L,81L,241L,245L,267L,725L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199636Inst : IEnumerable<long>
{
public static readonly long[] Value=A199636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199636.Bytes);
public long this[int i]=>Value[i];

public static A199636Inst Instance=new A199636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199637
{
public static readonly long[] Value={ 5L,3L,21L,13L,85L,17L,11L,7L,15L,9L,19L,37L,25L,49L,33L,65L,43L,87L,57L,39L,79L,153L,105L,203L,135L,271L,185L,123L,247L,169L,329L,219L,159L,295L,569L,379L,283L,505L,377L,251L,167L,111L,223L,445L,297L,593L,395L,263L,175L,351L,233L,155L,103L,207L,137L,91L,183L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199637Inst : IEnumerable<long>
{
public static readonly long[] Value=A199637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199637.Bytes);
public long this[int i]=>Value[i];

public static A199637Inst Instance=new A199637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199638
{
public static readonly long[] Value={ 5L,3L,21L,13L,85L,53L,341L,227L,1365L,909L,5461L,3637L,21845L,14563L,87381L,58253L,349525L,233013L,1398101L,932067L,5592405L,3728269L,22369621L,14913077L,89478485L,59652323L,357913941L,238609293L,1431655765L,954437173L,5726623061L,3817748707L,22906492245L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199638Inst : IEnumerable<long>
{
public static readonly long[] Value=A199638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199638.Bytes);
public long this[int i]=>Value[i];

public static A199638Inst Instance=new A199638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199639
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,12L,16L,19L,22L,24L,28L,31L,32L,43L,48L,64L,76L,79L,96L,103L,112L,128L,139L,142L,163L,166L,184L,192L,199L,211L,223L,256L,262L,268L,271L,283L,304L,307L,316L,331L,352L,367L,376L,379L,384L,412L,439L,448L,454L,463L,496L,499L,512L,526L,547L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199639Inst : IEnumerable<long>
{
public static readonly long[] Value=A199639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199639.Bytes);
public long this[int i]=>Value[i];

public static A199639Inst Instance=new A199639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199640
{
public static readonly long[] Value={ 0L,3L,112L,29229L,32177372L,176701683386L,4539946639286136L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199640Inst : IEnumerable<long>
{
public static readonly long[] Value=A199640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199640.Bytes);
public long this[int i]=>Value[i];

public static A199640Inst Instance=new A199640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199641
{
public static readonly long[] Value={ 1L,3L,13L,60L,288L,1384L,6628L,31772L,152304L,730036L,3499340L,16773680L,80402532L,385399644L,1847365808L,8855120468L,42445929772L,203459338800L,975257291396L,4674775757500L,22407962058928L,107409807372276L,514855687878924L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199641Inst : IEnumerable<long>
{
public static readonly long[] Value=A199641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199641.Bytes);
public long this[int i]=>Value[i];

public static A199641Inst Instance=new A199641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199642
{
public static readonly long[] Value={ 1L,13L,112L,1265L,12748L,134748L,1396083L,14584050L,151837464L,1582988477L,16494233432L,171904221068L,1791430664487L,18669394073270L,194560012081184L,2027588187779377L,21130256645906468L,220206564513115724L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199642Inst : IEnumerable<long>
{
public static readonly long[] Value=A199642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199642.Bytes);
public long this[int i]=>Value[i];

public static A199642Inst Instance=new A199642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199643
{
public static readonly BigInteger[] Value={ 2L,60L,1265L,29229L,658770L,15066222L,342328663L,7797114144L,177447181083L,4039488090307L,91947444344704L,2092999963213610L,47642308975551650L,1084472533833020100L,BigInteger.Parse("24685590900071146822"),BigInteger.Parse("561912613968766782369") };
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
public class A199643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199643Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199643.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199643.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199643Inst Instance=new A199643Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199644
{
public static readonly BigInteger[] Value={ 3L,288L,12748L,658770L,32177372L,1614250077L,80053957248L,3988024796446L,198328767139736L,9869645990489747L,491026123739354858L,BigInteger.Parse("24431608808618462704"),BigInteger.Parse("1215575822472077464282"),BigInteger.Parse("60480991464785183388557") };
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
public class A199644Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199644.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199644Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199644.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199644.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199644Inst Instance=new A199644Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199645
{
public static readonly BigInteger[] Value={ 6L,1384L,134748L,15066222L,1614250077L,176701683386L,19161971644783L,2085499380111100L,226676302441401393L,BigInteger.Parse("24649864713781053665"),BigInteger.Parse("2680046304287719376722"),BigInteger.Parse("291407720701800854792287") };
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
public class A199645Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199645.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199645Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199645.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199645.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199645Inst Instance=new A199645Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199646
{
public static readonly BigInteger[] Value={ 11L,6628L,1396083L,342328663L,80053957248L,19161971644783L,4539946639286136L,1079929763429897946L,BigInteger.Parse("256503858825070983388") };
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
public class A199646Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199646.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199646Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199646.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199646.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199646Inst Instance=new A199646Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199647
{
public static readonly long[] Value={ 0L,1L,1L,1L,3L,1L,2L,13L,13L,2L,3L,60L,112L,60L,3L,6L,288L,1265L,1265L,288L,6L,11L,1384L,12748L,29229L,12748L,1384L,11L,22L,6628L,134748L,658770L,658770L,134748L,6628L,22L,43L,31772L,1396083L,15066222L,32177372L,15066222L,1396083L,31772L,43L,86L,152304L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199647Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199647.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199647Inst : IEnumerable<long>
{
public static readonly long[] Value=A199647.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199647.Bytes);
public long this[int i]=>Value[i];

public static A199647Inst Instance=new A199647Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199648
{
public static readonly BigInteger[] Value={ 1L,14L,2584L,3695683L,39209840355L,3083761998081891L,BigInteger.Parse("1797997097480559332224"),BigInteger.Parse("7771716024559573445914487875") };
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
public class A199648Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199648.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199648Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199648.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199648.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199648Inst Instance=new A199648Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199649
{
public static readonly long[] Value={ 2L,14L,113L,953L,8037L,67774L,571530L,4819638L,40643380L,342740340L,2890284724L,24373395288L,205537673480L,1733272476824L,14616461440144L,123258718919184L,1039424750772560L,8765333779162336L,73916920107029408L,623331776719986016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199649Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199649.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199649Inst : IEnumerable<long>
{
public static readonly long[] Value=A199649.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199649.Bytes);
public long this[int i]=>Value[i];

public static A199649Inst Instance=new A199649Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199650
{
public static readonly BigInteger[] Value={ 5L,113L,2584L,59212L,1357484L,31120632L,713445976L,16355879648L,374961537040L,8596061907680L,197066293538400L,4517780870646656L,103570953858672192L,2374383085485820032L,BigInteger.Parse("54433167085958461312"),BigInteger.Parse("1247890324488906825728") };
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
public class A199650Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199650.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199650Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199650.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199650.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199650Inst Instance=new A199650Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199651
{
public static readonly BigInteger[] Value={ 14L,953L,59212L,3695683L,230693158L,14399942873L,898852775335L,56106912155198L,3502225890582058L,218610965399514236L,13645822881807986686UL,BigInteger.Parse("851780155556891684028"),BigInteger.Parse("53168609887984551128913"),BigInteger.Parse("3318815376219262701965237") };
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
public class A199651Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199651.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199651Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199651.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199651.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199651Inst Instance=new A199651Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199652
{
public static readonly BigInteger[] Value={ 41L,8037L,1357484L,230693158L,39209840355L,6663970316970L,1132589231853096L,192491652879392515L,BigInteger.Parse("32715334199617664326"),BigInteger.Parse("5560205218374521415185"),BigInteger.Parse("944996676143473092852595"),BigInteger.Parse("160608949278619262130353064") };
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
public class A199652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199652Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199652.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199652.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199652Inst Instance=new A199652Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199653
{
public static readonly BigInteger[] Value={ 122L,67774L,31120632L,14399942873L,6663970316970L,3083761998081891L,1427019666767669979L,BigInteger.Parse("660357476435139192982"),BigInteger.Parse("305582323780950052573456"),BigInteger.Parse("141409100632588861437301956"),BigInteger.Parse("65437468685616944338442793185") };
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
public class A199653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199653Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199653.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199653.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199653Inst Instance=new A199653Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199654
{
public static readonly BigInteger[] Value={ 365L,571530L,713445976L,898852775335L,1132589231853096L,1427019666767669979L,BigInteger.Parse("1797997097480559332224"),BigInteger.Parse("2265416280260844187870380"),BigInteger.Parse("2854348741463033805904551375"),BigInteger.Parse("3596383952736036093799275624989") };
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
public class A199654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199654Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199654.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199654.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199654Inst Instance=new A199654Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199655
{
public static readonly long[] Value={ 1L,2L,2L,5L,14L,5L,14L,113L,113L,14L,41L,953L,2584L,953L,41L,122L,8037L,59212L,59212L,8037L,122L,365L,67774L,1357484L,3695683L,1357484L,67774L,365L,1094L,571530L,31120632L,230693158L,230693158L,31120632L,571530L,1094L,3281L,4819638L,713445976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199655Inst : IEnumerable<long>
{
public static readonly long[] Value=A199655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199655.Bytes);
public long this[int i]=>Value[i];

public static A199655Inst Instance=new A199655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199656
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,19L,1L,15L,65L,175L,1L,31L,211L,781L,2101L,1L,63L,665L,3367L,11529L,31031L,1L,127L,2059L,14197L,61741L,201811L,543607L,1L,255L,6305L,58975L,325089L,1288991L,4085185L,11012415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199656Inst : IEnumerable<long>
{
public static readonly long[] Value=A199656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199656.Bytes);
public long this[int i]=>Value[i];

public static A199656Inst Instance=new A199656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199657
{
public static readonly long[] Value={ 25L,333L,1667438L,9252915567L,136727214560643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199657Inst : IEnumerable<long>
{
public static readonly long[] Value=A199657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199657.Bytes);
public long this[int i]=>Value[i];

public static A199657Inst Instance=new A199657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199658
{
public static readonly long[] Value={ 8L,106L,530762L,2945294501L,43521624105025L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199658Inst : IEnumerable<long>
{
public static readonly long[] Value=A199658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199658.Bytes);
public long this[int i]=>Value[i];

public static A199658Inst Instance=new A199658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199659
{
public static readonly long[] Value={ 1L,-3L,0L,8L,-9L,0L,17L,-27L,0L,46L,-57L,0L,98L,-126L,0L,198L,-243L,0L,371L,-465L,0L,692L,-828L,0L,1205L,-1458L,0L,2082L,-2463L,0L,3463L,-4104L,0L,5678L,-6642L,0L,9085L,-10623L,0L,14370L,-16632L,0L,22273L,-25758L,0L,34178L,-39246L,0L,51674L,-59220L,0L,77362L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199659Inst : IEnumerable<long>
{
public static readonly long[] Value=A199659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199659.Bytes);
public long this[int i]=>Value[i];

public static A199659Inst Instance=new A199659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199660
{
public static readonly long[] Value={ 1L,1L,2L,1L,5L,2L,20L,6L,114L,24L,864L,120L,8280L,720L,96480L,5040L,1325520L,40320L,20966400L,362880L,374855040L,3628800L,7468070400L,39916800L,163938297600L,479001600L,3929729126400L,6227020800L,102104460057600L,87178291200L,2857878742118400L,1307674368000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199660Inst : IEnumerable<long>
{
public static readonly long[] Value=A199660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199660.Bytes);
public long this[int i]=>Value[i];

public static A199660Inst Instance=new A199660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199661
{
public static readonly long[] Value={ 5L,8L,1L,1L,4L,8L,2L,2L,7L,2L,0L,3L,4L,1L,2L,1L,1L,1L,9L,8L,6L,7L,9L,7L,6L,7L,4L,6L,2L,0L,6L,4L,9L,6L,4L,4L,1L,8L,5L,6L,1L,6L,2L,0L,1L,6L,1L,1L,7L,0L,7L,3L,7L,6L,2L,0L,1L,5L,4L,7L,9L,9L,6L,6L,0L,2L,2L,5L,9L,3L,2L,1L,8L,0L,0L,7L,7L,5L,4L,2L,9L,9L,7L,1L,8L,6L,2L,4L,3L,7L,4L,6L,6L,1L,7L,1L,7L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199661Inst : IEnumerable<long>
{
public static readonly long[] Value=A199661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199661.Bytes);
public long this[int i]=>Value[i];

public static A199661Inst Instance=new A199661Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199662
{
public static readonly long[] Value={ 3L,1L,6L,7L,5L,0L,8L,2L,8L,7L,7L,1L,2L,2L,1L,1L,7L,1L,8L,8L,6L,7L,9L,6L,1L,8L,0L,6L,1L,0L,9L,6L,1L,7L,9L,7L,9L,9L,7L,1L,7L,1L,8L,9L,4L,6L,2L,9L,3L,3L,7L,5L,0L,8L,2L,0L,8L,4L,6L,3L,7L,9L,0L,0L,9L,7L,7L,1L,5L,3L,5L,3L,6L,2L,0L,4L,8L,6L,3L,3L,7L,5L,0L,5L,6L,7L,0L,8L,2L,3L,5L,6L,1L,1L,2L,2L,9L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199662Inst : IEnumerable<long>
{
public static readonly long[] Value=A199662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199662.Bytes);
public long this[int i]=>Value[i];

public static A199662Inst Instance=new A199662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199663
{
public static readonly long[] Value={ 3L,3L,9L,6L,3L,1L,2L,6L,0L,3L,1L,9L,1L,7L,8L,8L,7L,5L,3L,6L,7L,4L,6L,6L,6L,6L,2L,4L,7L,8L,8L,0L,8L,0L,5L,3L,1L,0L,7L,7L,8L,8L,4L,2L,3L,0L,7L,5L,8L,5L,8L,3L,6L,7L,9L,4L,4L,2L,5L,8L,9L,3L,3L,9L,1L,4L,2L,6L,9L,0L,4L,8L,9L,8L,1L,0L,0L,4L,4L,8L,4L,3L,5L,4L,8L,0L,0L,1L,3L,6L,6L,3L,6L,7L,4L,9L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199663Inst : IEnumerable<long>
{
public static readonly long[] Value=A199663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199663.Bytes);
public long this[int i]=>Value[i];

public static A199663Inst Instance=new A199663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199664
{
public static readonly long[] Value={ 6L,6L,5L,5L,9L,9L,0L,7L,7L,3L,3L,0L,6L,7L,6L,1L,5L,2L,5L,0L,5L,2L,6L,5L,1L,9L,2L,2L,6L,8L,8L,5L,3L,0L,2L,8L,5L,4L,3L,4L,8L,9L,7L,4L,7L,9L,1L,5L,0L,6L,1L,4L,7L,2L,4L,8L,9L,4L,2L,4L,2L,2L,3L,7L,9L,0L,9L,6L,8L,0L,5L,6L,1L,6L,1L,3L,3L,8L,6L,2L,2L,1L,1L,6L,4L,8L,5L,2L,3L,8L,1L,0L,0L,5L,5L,9L,0L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199664Inst : IEnumerable<long>
{
public static readonly long[] Value=A199664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199664.Bytes);
public long this[int i]=>Value[i];

public static A199664Inst Instance=new A199664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199665
{
public static readonly long[] Value={ 9L,4L,7L,9L,7L,2L,6L,4L,7L,8L,8L,9L,8L,1L,4L,2L,4L,4L,0L,4L,2L,0L,5L,0L,6L,9L,6L,1L,9L,7L,5L,5L,0L,2L,2L,3L,4L,0L,0L,4L,3L,8L,1L,4L,9L,4L,1L,5L,5L,9L,3L,8L,6L,5L,5L,0L,1L,9L,5L,0L,6L,5L,6L,2L,0L,1L,0L,5L,5L,9L,7L,4L,0L,7L,4L,5L,0L,6L,2L,1L,6L,8L,5L,0L,2L,5L,1L,0L,1L,5L,1L,7L,3L,0L,9L,3L,9L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199665Inst : IEnumerable<long>
{
public static readonly long[] Value=A199665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199665.Bytes);
public long this[int i]=>Value[i];

public static A199665Inst Instance=new A199665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199666
{
public static readonly long[] Value={ 5L,6L,3L,5L,6L,9L,2L,0L,4L,2L,2L,5L,5L,1L,5L,6L,4L,2L,4L,9L,0L,5L,0L,1L,8L,0L,7L,1L,3L,5L,1L,3L,2L,0L,4L,5L,0L,6L,1L,0L,7L,4L,4L,7L,2L,4L,3L,2L,6L,8L,7L,2L,9L,5L,8L,0L,3L,4L,8L,3L,5L,5L,1L,2L,7L,8L,6L,1L,1L,1L,5L,2L,8L,6L,2L,5L,9L,0L,0L,1L,3L,7L,8L,1L,1L,0L,6L,7L,0L,2L,5L,4L,8L,3L,7L,3L,1L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199666Inst : IEnumerable<long>
{
public static readonly long[] Value=A199666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199666.Bytes);
public long this[int i]=>Value[i];

public static A199666Inst Instance=new A199666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199667
{
public static readonly long[] Value={ 3L,0L,7L,3L,2L,0L,6L,2L,1L,1L,8L,2L,8L,1L,9L,4L,0L,7L,3L,4L,1L,1L,9L,6L,6L,6L,9L,3L,8L,6L,1L,5L,4L,9L,1L,9L,8L,2L,5L,4L,5L,0L,8L,1L,6L,4L,8L,4L,3L,3L,6L,2L,0L,7L,1L,8L,6L,5L,5L,8L,1L,5L,0L,8L,0L,0L,3L,9L,2L,5L,4L,8L,6L,2L,7L,6L,6L,1L,5L,9L,2L,9L,6L,3L,3L,6L,7L,8L,6L,6L,7L,5L,0L,0L,8L,2L,3L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199667Inst : IEnumerable<long>
{
public static readonly long[] Value=A199667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199667.Bytes);
public long this[int i]=>Value[i];

public static A199667Inst Instance=new A199667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199668
{
public static readonly long[] Value={ 3L,5L,3L,9L,0L,4L,4L,5L,9L,0L,7L,0L,7L,6L,7L,0L,0L,9L,6L,9L,0L,0L,0L,7L,1L,0L,2L,7L,2L,4L,6L,6L,4L,6L,4L,6L,9L,9L,1L,2L,0L,3L,8L,6L,5L,8L,0L,0L,6L,9L,0L,2L,6L,6L,0L,2L,1L,1L,9L,5L,5L,6L,6L,0L,8L,6L,7L,0L,2L,0L,6L,3L,7L,4L,7L,6L,7L,8L,0L,9L,7L,9L,4L,8L,2L,0L,8L,9L,0L,6L,2L,8L,8L,3L,9L,5L,1L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199668Inst : IEnumerable<long>
{
public static readonly long[] Value=A199668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199668.Bytes);
public long this[int i]=>Value[i];

public static A199668Inst Instance=new A199668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199669
{
public static readonly long[] Value={ 7L,1L,9L,8L,5L,9L,8L,6L,7L,2L,0L,4L,1L,1L,7L,6L,4L,9L,3L,6L,1L,1L,3L,3L,4L,4L,0L,9L,1L,0L,7L,0L,0L,9L,5L,3L,2L,3L,1L,1L,8L,6L,0L,3L,7L,4L,7L,5L,9L,5L,9L,4L,6L,2L,6L,8L,9L,8L,0L,2L,9L,4L,6L,0L,8L,9L,6L,0L,5L,8L,6L,9L,6L,8L,7L,8L,1L,5L,3L,9L,7L,6L,4L,6L,5L,0L,5L,2L,2L,5L,9L,0L,1L,5L,4L,3L,0L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199669Inst : IEnumerable<long>
{
public static readonly long[] Value=A199669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199669.Bytes);
public long this[int i]=>Value[i];

public static A199669Inst Instance=new A199669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199670
{
public static readonly BigInteger[] Value={ 1L,1L,3L,16L,119L,1134L,13201L,181594L,2882061L,51836302L,1041959555L,23148374886L,563234624575L,14895783741202L,425457081218169L,13052033357204842L,428016906877603589L,14941465218939490686UL,BigInteger.Parse("553193807213161191259"),BigInteger.Parse("21651761774465075118502"),BigInteger.Parse("893244763931287659927399") };
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
public class A199670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199670Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199670.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199670.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199670Inst Instance=new A199670Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199671
{
public static readonly long[] Value={ 22L,355L,1667793L,9254583360L,136736469144003L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199671Inst : IEnumerable<long>
{
public static readonly long[] Value=A199671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199671.Bytes);
public long this[int i]=>Value[i];

public static A199671Inst Instance=new A199671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199672
{
public static readonly long[] Value={ 7L,113L,530875L,2945825376L,43524569930401L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199672Inst : IEnumerable<long>
{
public static readonly long[] Value=A199672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199672.Bytes);
public long this[int i]=>Value[i];

public static A199672Inst Instance=new A199672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199673
{
public static readonly long[] Value={ 1L,2L,2L,3L,12L,6L,4L,48L,72L,24L,5L,160L,540L,480L,120L,6L,480L,3240L,5760L,3600L,720L,7L,1344L,17010L,53760L,63000L,30240L,5040L,8L,3584L,81648L,430080L,840000L,725760L,282240L,40320L,9L,9216L,367416L,3096576L,9450000L,13063680L,8890560L,2903040L,362880L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199673Inst : IEnumerable<long>
{
public static readonly long[] Value=A199673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199673.Bytes);
public long this[int i]=>Value[i];

public static A199673Inst Instance=new A199673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199674
{
public static readonly long[] Value={ 1L,17L,186L,1273L,5614L,16403L,31726L,39159L,27945L,8748L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199674Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199674.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199674Inst : IEnumerable<long>
{
public static readonly long[] Value=A199674.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199674.Bytes);
public long this[int i]=>Value[i];

public static A199674Inst Instance=new A199674Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199675
{
public static readonly BigInteger[] Value={ 1L,1L,2L,7L,31L,170L,1129L,8737L,77198L,767683L,8482519L,103093958L,1366897597L,19633740673L,303706037546L,5033465370031L,88983532209967L,1671402633292562L,33241154368669921L,697834148797749601L,15420722865332961206UL,BigInteger.Parse("357805114894717632331"),BigInteger.Parse("8697446048869287663271") };
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
public class A199675Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199675.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199675Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199675.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199675.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199675Inst Instance=new A199675Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199676
{
public static readonly long[] Value={ 1L,1L,3L,5L,18L,57L,285L,1513L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199676Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199676.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199676Inst : IEnumerable<long>
{
public static readonly long[] Value=A199676.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199676.Bytes);
public long this[int i]=>Value[i];

public static A199676Inst Instance=new A199676Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199677
{
public static readonly long[] Value={ 9L,73L,649L,5833L,52489L,472393L,4251529L,38263753L,344373769L,3099363913L,27894275209L,251048476873L,2259436291849L,20334926626633L,183014339639689L,1647129056757193L,14824161510814729L,133417453597332553L,1200757082375992969L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199677Inst : IEnumerable<long>
{
public static readonly long[] Value=A199677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199677.Bytes);
public long this[int i]=>Value[i];

public static A199677Inst Instance=new A199677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199678
{
public static readonly long[] Value={ 11L,91L,811L,7291L,65611L,590491L,5314411L,47829691L,430467211L,3874204891L,34867844011L,313810596091L,2824295364811L,25418658283291L,228767924549611L,2058911320946491L,18530201888518411L,166771816996665691L,1500946352969991211L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199678Inst : IEnumerable<long>
{
public static readonly long[] Value=A199678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199678.Bytes);
public long this[int i]=>Value[i];

public static A199678Inst Instance=new A199678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199679
{
public static readonly long[] Value={ 3L,25L,223L,2005L,18043L,162385L,1461463L,13153165L,118378483L,1065406345L,9588657103L,86297913925L,776681225323L,6990131027905L,62911179251143L,566200613260285L,5095805519342563L,45862249674083065L,412760247066747583L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199679Inst : IEnumerable<long>
{
public static readonly long[] Value=A199679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199679.Bytes);
public long this[int i]=>Value[i];

public static A199679Inst Instance=new A199679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199680
{
public static readonly long[] Value={ 6L,50L,446L,4010L,36086L,324770L,2922926L,26306330L,236756966L,2130812690L,19177314206L,172595827850L,1553362450646L,13980262055810L,125822358502286L,1132401226520570L,10191611038685126L,91724499348166130L,825520494133495166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199680Inst : IEnumerable<long>
{
public static readonly long[] Value=A199680.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199680.Bytes);
public long this[int i]=>Value[i];

public static A199680Inst Instance=new A199680Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199681
{
public static readonly long[] Value={ 12L,100L,892L,8020L,72172L,649540L,5845852L,52612660L,473513932L,4261625380L,38354628412L,345191655700L,3106724901292L,27960524111620L,251644717004572L,2264802453041140L,20383222077370252L,183448998696332260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199681Inst : IEnumerable<long>
{
public static readonly long[] Value=A199681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199681.Bytes);
public long this[int i]=>Value[i];

public static A199681Inst Instance=new A199681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199682
{
public static readonly long[] Value={ 3L,21L,201L,2001L,20001L,200001L,2000001L,20000001L,200000001L,2000000001L,20000000001L,200000000001L,2000000000001L,20000000000001L,200000000000001L,2000000000000001L,20000000000000001L,200000000000000001L,2000000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199682Inst : IEnumerable<long>
{
public static readonly long[] Value=A199682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199682.Bytes);
public long this[int i]=>Value[i];

public static A199682Inst Instance=new A199682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199683
{
public static readonly long[] Value={ 4L,31L,301L,3001L,30001L,300001L,3000001L,30000001L,300000001L,3000000001L,30000000001L,300000000001L,3000000000001L,30000000000001L,300000000000001L,3000000000000001L,30000000000000001L,300000000000000001L,3000000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199683Inst : IEnumerable<long>
{
public static readonly long[] Value=A199683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199683.Bytes);
public long this[int i]=>Value[i];

public static A199683Inst Instance=new A199683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199684
{
public static readonly long[] Value={ 5L,41L,401L,4001L,40001L,400001L,4000001L,40000001L,400000001L,4000000001L,40000000001L,400000000001L,4000000000001L,40000000000001L,400000000000001L,4000000000000001L,40000000000000001L,400000000000000001L,4000000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199684Inst : IEnumerable<long>
{
public static readonly long[] Value=A199684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199684.Bytes);
public long this[int i]=>Value[i];

public static A199684Inst Instance=new A199684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199685
{
public static readonly long[] Value={ 6L,51L,501L,5001L,50001L,500001L,5000001L,50000001L,500000001L,5000000001L,50000000001L,500000000001L,5000000000001L,50000000000001L,500000000000001L,5000000000000001L,50000000000000001L,500000000000000001L,5000000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199685Inst : IEnumerable<long>
{
public static readonly long[] Value=A199685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199685.Bytes);
public long this[int i]=>Value[i];

public static A199685Inst Instance=new A199685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199686
{
public static readonly long[] Value={ 7L,61L,601L,6001L,60001L,600001L,6000001L,60000001L,600000001L,6000000001L,60000000001L,600000000001L,6000000000001L,60000000000001L,600000000000001L,6000000000000001L,60000000000000001L,600000000000000001L,6000000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199686Inst : IEnumerable<long>
{
public static readonly long[] Value=A199686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199686.Bytes);
public long this[int i]=>Value[i];

public static A199686Inst Instance=new A199686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199687
{
public static readonly long[] Value={ 8L,71L,701L,7001L,70001L,700001L,7000001L,70000001L,700000001L,7000000001L,70000000001L,700000000001L,7000000000001L,70000000000001L,700000000000001L,7000000000000001L,70000000000000001L,700000000000000001L,7000000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199687Inst : IEnumerable<long>
{
public static readonly long[] Value=A199687.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199687.Bytes);
public long this[int i]=>Value[i];

public static A199687Inst Instance=new A199687Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199688
{
public static readonly long[] Value={ 3L,27L,267L,2667L,26667L,266667L,2666667L,26666667L,266666667L,2666666667L,26666666667L,266666666667L,2666666666667L,26666666666667L,266666666666667L,2666666666666667L,26666666666666667L,266666666666666667L,2666666666666666667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199688Inst : IEnumerable<long>
{
public static readonly long[] Value=A199688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199688.Bytes);
public long this[int i]=>Value[i];

public static A199688Inst Instance=new A199688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199689
{
public static readonly long[] Value={ 9L,81L,801L,8001L,80001L,800001L,8000001L,80000001L,800000001L,8000000001L,80000000001L,800000000001L,8000000000001L,80000000000001L,800000000000001L,8000000000000001L,80000000000000001L,800000000000000001L,8000000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199689Inst : IEnumerable<long>
{
public static readonly long[] Value=A199689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199689.Bytes);
public long this[int i]=>Value[i];

public static A199689Inst Instance=new A199689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199690
{
public static readonly long[] Value={ 4L,37L,367L,3667L,36667L,366667L,3666667L,36666667L,366666667L,3666666667L,36666666667L,366666666667L,3666666666667L,36666666666667L,366666666666667L,3666666666666667L,36666666666666667L,366666666666666667L,3666666666666666667L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199690Inst : IEnumerable<long>
{
public static readonly long[] Value=A199690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199690.Bytes);
public long this[int i]=>Value[i];

public static A199690Inst Instance=new A199690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199691
{
public static readonly long[] Value={ 12L,111L,1101L,11001L,110001L,1100001L,11000001L,110000001L,1100000001L,11000000001L,110000000001L,1100000000001L,11000000000001L,110000000000001L,1100000000000001L,11000000000000001L,110000000000000001L,1100000000000000001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199691Inst : IEnumerable<long>
{
public static readonly long[] Value=A199691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199691.Bytes);
public long this[int i]=>Value[i];

public static A199691Inst Instance=new A199691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199692
{
public static readonly long[] Value={ 5L,41L,73L,149L,157L,277L,313L,613L,617L,709L,929L,1117L,1201L,1741L,1753L,1873L,2381L,2897L,2969L,3469L,3613L,3637L,3697L,4513L,4597L,5101L,5953L,6173L,6857L,6869L,7577L,8089L,8581L,9661L,10369L,10513L,11717L,12097L,12653L,12973L,13001L,13649L,14461L,15313L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199692Inst : IEnumerable<long>
{
public static readonly long[] Value=A199692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199692.Bytes);
public long this[int i]=>Value[i];

public static A199692Inst Instance=new A199692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199693
{
public static readonly long[] Value={ 12L,4L,16L,126L,6L,2L,2L,8L,8L,16L,2L,6L,8L,48L,8L,6L,4L,24L,4L,24L,12L,24L,2L,8L,2L,896L,6L,224L,28L,6L,8L,4L,2L,4L,64L,4L,4L,224L,8L,8L,2L,4L,12L,124L,24L,14L,256L,32L,2L,14L,62L,2L,4L,24L,14L,24L,4L,28L,6L,12L,8L,4L,2L,8L,2L,4L,2L,32L,16L,60L,24L,56L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199693Inst : IEnumerable<long>
{
public static readonly long[] Value=A199693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199693.Bytes);
public long this[int i]=>Value[i];

public static A199693Inst Instance=new A199693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199694
{
public static readonly long[] Value={ 1L,2L,4L,8L,19L,42L,99L,208L,443L,906L,1853L,3780L,7595L,15246L,30537L,61160L,122413L,244930L,489985L,980080L,1960257L,3920646L,7841419L,15682972L,31366187L,62732582L,125465509L,250931320L,501863047L,1003726454L,2007453193L,4014906880L,8029814297L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199694Inst : IEnumerable<long>
{
public static readonly long[] Value=A199694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199694.Bytes);
public long this[int i]=>Value[i];

public static A199694Inst Instance=new A199694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199695
{
public static readonly BigInteger[] Value={ 1L,1L,2L,9L,175L,8281L,1856261L,649893049L,817291210163L,1847322434679121L,14368726069959027071UL,BigInteger.Parse("342031303262647675287601"),BigInteger.Parse("13964481217238950868653586531"),BigInteger.Parse("1889891784470148590323094656731121"),BigInteger.Parse("586215019967842464352819482405063771511") };
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
public class A199695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199695Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199695.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199695.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199695Inst Instance=new A199695Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199696
{
public static readonly BigInteger[] Value={ 1L,1L,2L,3L,35L,91L,7337L,25493L,9351479L,42980489L,78695113801L,584834423801L,4754839123536133L,43472885623916761L,BigInteger.Parse("1887750276489057845213"),BigInteger.Parse("21019416307292530253881"),BigInteger.Parse("4675204650607654300508731931"),BigInteger.Parse("77008997457626136207428248409") };
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
public class A199696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199696Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A199696.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A199696.Bytes);
public BigInteger this[int i]=>Value[i];

public static A199696Inst Instance=new A199696Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199697
{
public static readonly long[] Value={ 1L,2L,6L,8L,14L,32L,56L,100L,204L,388L,722L,1416L,2750L,5256L,10222L,19944L,38650L,75272L,147142L,287120L,561018L,1098752L,2152092L,4217620L,8276376L,16250292L,31921374L,62754072L,123440514L,242921784L,478310952L,942260548L,1856994908L,3661288036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199697Inst : IEnumerable<long>
{
public static readonly long[] Value=A199697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199697.Bytes);
public long this[int i]=>Value[i];

public static A199697Inst Instance=new A199697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199698
{
public static readonly long[] Value={ 1L,4L,14L,52L,200L,708L,2642L,10000L,37984L,144876L,554120L,2128672L,8204180L,31697564L,122734614L,476170124L,1850664202L,7204005752L,28081918548L,109604285492L,428278469018L,1675246478864L,6559126501510L,25703606447364L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199698Inst : IEnumerable<long>
{
public static readonly long[] Value=A199698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199698.Bytes);
public long this[int i]=>Value[i];

public static A199698Inst Instance=new A199698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199699
{
public static readonly long[] Value={ 1L,6L,32L,168L,892L,4964L,27854L,156920L,891684L,5095360L,29236016L,168361392L,972601784L,5633548460L,32706291872L,190266981972L,1108856802378L,6472638961608L,37836350087956L,221461180199752L,1297757839607606L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199699Inst : IEnumerable<long>
{
public static readonly long[] Value=A199699.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199699.Bytes);
public long this[int i]=>Value[i];

public static A199699Inst Instance=new A199699Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199700
{
public static readonly long[] Value={ 1L,8L,52L,380L,2734L,20116L,149942L,1128388L,8545180L,65055556L,497505902L,3818857188L,29405977172L,227044808964L,1757143904470L,13626887453432L,105870556547144L,823864569255344L,6420445347122416L,50100342760566184L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199700Inst : IEnumerable<long>
{
public static readonly long[] Value=A199700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199700.Bytes);
public long this[int i]=>Value[i];

public static A199700Inst Instance=new A199700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199701
{
public static readonly long[] Value={ 1L,10L,82L,724L,6504L,59992L,559028L,5252900L,49700882L,472873888L,4519281222L,43353372676L,417214414596L,4026070558436L,38943205468034L,377469980604452L,3665456335373858L,35651726951195532L,347268836196275908L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199701Inst : IEnumerable<long>
{
public static readonly long[] Value=A199701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199701.Bytes);
public long this[int i]=>Value[i];

public static A199701Inst Instance=new A199701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199702
{
public static readonly long[] Value={ 1L,12L,114L,1236L,13324L,147072L,1643204L,18527516L,210316392L,2400684208L,27527644696L,316844861020L,3658598730648L,42361908912360L,491666143730354L,5718341649577364L,66629811252553344L,777637357808739752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199702Inst : IEnumerable<long>
{
public static readonly long[] Value=A199702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199702.Bytes);
public long this[int i]=>Value[i];

public static A199702Inst Instance=new A199702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199703
{
public static readonly long[] Value={ 1L,14L,156L,1940L,24394L,314532L,4099204L,53901956L,713719390L,9503449352L,127119684220L,1706849222504L,22991898594206L,310564824249656L,4205016717658718L,57054704774633892L,775562100878527252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199703Inst : IEnumerable<long>
{
public static readonly long[] Value=A199703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199703.Bytes);
public long this[int i]=>Value[i];

public static A199703Inst Instance=new A199703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A199704
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,6L,1L,6L,14L,8L,1L,8L,32L,52L,14L,1L,10L,52L,168L,200L,32L,1L,12L,82L,380L,892L,708L,56L,1L,14L,114L,724L,2734L,4964L,2642L,100L,1L,16L,156L,1236L,6504L,20116L,27854L,10000L,204L,1L,18L,200L,1940L,13324L,59992L,149942L,156920L,37984L,388L,1L,20L,254L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A199704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A199704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A199704Inst : IEnumerable<long>
{
public static readonly long[] Value=A199704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A199704.Bytes);
public long this[int i]=>Value[i];

public static A199704Inst Instance=new A199704Inst();

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