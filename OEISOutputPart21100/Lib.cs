using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A040256
{
public static readonly long[] Value={ 16L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L,10L,1L,1L,32L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040256Inst : IEnumerable<long>
{
public static readonly long[] Value=A040256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040256.Bytes);
public long this[int i]=>Value[i];

public static A040256Inst Instance=new A040256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040255
{
public static readonly long[] Value={ 16L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L,2L,32L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040255Inst : IEnumerable<long>
{
public static readonly long[] Value=A040255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040255.Bytes);
public long this[int i]=>Value[i];

public static A040255Inst Instance=new A040255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040254
{
public static readonly long[] Value={ 16L,2L,6L,10L,1L,4L,1L,1L,2L,1L,2L,1L,15L,1L,2L,1L,2L,1L,1L,4L,1L,10L,6L,2L,32L,2L,6L,10L,1L,4L,1L,1L,2L,1L,2L,1L,15L,1L,2L,1L,2L,1L,1L,4L,1L,10L,6L,2L,32L,2L,6L,10L,1L,4L,1L,1L,2L,1L,2L,1L,15L,1L,2L,1L,2L,1L,1L,4L,1L,10L,6L,2L,32L,2L,6L,10L,1L,4L,1L,1L,2L,1L,2L,1L,15L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040254Inst : IEnumerable<long>
{
public static readonly long[] Value=A040254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040254.Bytes);
public long this[int i]=>Value[i];

public static A040254Inst Instance=new A040254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040253
{
public static readonly long[] Value={ 16L,2L,3L,6L,3L,2L,32L,2L,3L,6L,3L,2L,32L,2L,3L,6L,3L,2L,32L,2L,3L,6L,3L,2L,32L,2L,3L,6L,3L,2L,32L,2L,3L,6L,3L,2L,32L,2L,3L,6L,3L,2L,32L,2L,3L,6L,3L,2L,32L,2L,3L,6L,3L,2L,32L,2L,3L,6L,3L,2L,32L,2L,3L,6L,3L,2L,32L,2L,3L,6L,3L,2L,32L,2L,3L,6L,3L,2L,32L,2L,3L,6L,3L,2L,32L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040253Inst : IEnumerable<long>
{
public static readonly long[] Value=A040253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040253.Bytes);
public long this[int i]=>Value[i];

public static A040253Inst Instance=new A040253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040236
{
public static readonly long[] Value={ 15L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L,30L,1L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040236Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040236.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040236Inst : IEnumerable<long>
{
public static readonly long[] Value=A040236.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040236.Bytes);
public long this[int i]=>Value[i];

public static A040236Inst Instance=new A040236Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040235
{
public static readonly long[] Value={ 15L,1L,5L,2L,1L,2L,2L,15L,2L,2L,1L,2L,5L,1L,30L,1L,5L,2L,1L,2L,2L,15L,2L,2L,1L,2L,5L,1L,30L,1L,5L,2L,1L,2L,2L,15L,2L,2L,1L,2L,5L,1L,30L,1L,5L,2L,1L,2L,2L,15L,2L,2L,1L,2L,5L,1L,30L,1L,5L,2L,1L,2L,2L,15L,2L,2L,1L,2L,5L,1L,30L,1L,5L,2L,1L,2L,2L,15L,2L,2L,1L,2L,5L,1L,30L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040235Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040235.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040235Inst : IEnumerable<long>
{
public static readonly long[] Value=A040235.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040235.Bytes);
public long this[int i]=>Value[i];

public static A040235Inst Instance=new A040235Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040234
{
public static readonly long[] Value={ 15L,1L,4L,3L,3L,4L,1L,30L,1L,4L,3L,3L,4L,1L,30L,1L,4L,3L,3L,4L,1L,30L,1L,4L,3L,3L,4L,1L,30L,1L,4L,3L,3L,4L,1L,30L,1L,4L,3L,3L,4L,1L,30L,1L,4L,3L,3L,4L,1L,30L,1L,4L,3L,3L,4L,1L,30L,1L,4L,3L,3L,4L,1L,30L,1L,4L,3L,3L,4L,1L,30L,1L,4L,3L,3L,4L,1L,30L,1L,4L,3L,3L,4L,1L,30L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040234Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040234.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040234Inst : IEnumerable<long>
{
public static readonly long[] Value=A040234.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040234.Bytes);
public long this[int i]=>Value[i];

public static A040234Inst Instance=new A040234Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040233
{
public static readonly long[] Value={ 15L,1L,3L,1L,1L,5L,1L,3L,10L,3L,1L,5L,1L,1L,3L,1L,30L,1L,3L,1L,1L,5L,1L,3L,10L,3L,1L,5L,1L,1L,3L,1L,30L,1L,3L,1L,1L,5L,1L,3L,10L,3L,1L,5L,1L,1L,3L,1L,30L,1L,3L,1L,1L,5L,1L,3L,10L,3L,1L,5L,1L,1L,3L,1L,30L,1L,3L,1L,1L,5L,1L,3L,10L,3L,1L,5L,1L,1L,3L,1L,30L,1L,3L,1L,1L,5L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040233Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040233.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040233Inst : IEnumerable<long>
{
public static readonly long[] Value=A040233.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040233.Bytes);
public long this[int i]=>Value[i];

public static A040233Inst Instance=new A040233Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040232
{
public static readonly long[] Value={ 15L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L,30L,1L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040232Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040232.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040232Inst : IEnumerable<long>
{
public static readonly long[] Value=A040232.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040232.Bytes);
public long this[int i]=>Value[i];

public static A040232Inst Instance=new A040232Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040231
{
public static readonly long[] Value={ 15L,1L,2L,1L,1L,9L,1L,9L,1L,1L,2L,1L,30L,1L,2L,1L,1L,9L,1L,9L,1L,1L,2L,1L,30L,1L,2L,1L,1L,9L,1L,9L,1L,1L,2L,1L,30L,1L,2L,1L,1L,9L,1L,9L,1L,1L,2L,1L,30L,1L,2L,1L,1L,9L,1L,9L,1L,1L,2L,1L,30L,1L,2L,1L,1L,9L,1L,9L,1L,1L,2L,1L,30L,1L,2L,1L,1L,9L,1L,9L,1L,1L,2L,1L,30L,1L,2L,1L,1L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040231Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040231.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040231Inst : IEnumerable<long>
{
public static readonly long[] Value=A040231.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040231.Bytes);
public long this[int i]=>Value[i];

public static A040231Inst Instance=new A040231Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040230
{
public static readonly long[] Value={ 15L,1L,2L,5L,1L,14L,1L,5L,2L,1L,30L,1L,2L,5L,1L,14L,1L,5L,2L,1L,30L,1L,2L,5L,1L,14L,1L,5L,2L,1L,30L,1L,2L,5L,1L,14L,1L,5L,2L,1L,30L,1L,2L,5L,1L,14L,1L,5L,2L,1L,30L,1L,2L,5L,1L,14L,1L,5L,2L,1L,30L,1L,2L,5L,1L,14L,1L,5L,2L,1L,30L,1L,2L,5L,1L,14L,1L,5L,2L,1L,30L,1L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040230Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040230.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040230Inst : IEnumerable<long>
{
public static readonly long[] Value=A040230.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040230.Bytes);
public long this[int i]=>Value[i];

public static A040230Inst Instance=new A040230Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040229
{
public static readonly long[] Value={ 15L,1L,1L,1L,7L,6L,7L,1L,1L,1L,30L,1L,1L,1L,7L,6L,7L,1L,1L,1L,30L,1L,1L,1L,7L,6L,7L,1L,1L,1L,30L,1L,1L,1L,7L,6L,7L,1L,1L,1L,30L,1L,1L,1L,7L,6L,7L,1L,1L,1L,30L,1L,1L,1L,7L,6L,7L,1L,1L,1L,30L,1L,1L,1L,7L,6L,7L,1L,1L,1L,30L,1L,1L,1L,7L,6L,7L,1L,1L,1L,30L,1L,1L,1L,7L,6L,7L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040229Inst : IEnumerable<long>
{
public static readonly long[] Value=A040229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040229.Bytes);
public long this[int i]=>Value[i];

public static A040229Inst Instance=new A040229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040228
{
public static readonly long[] Value={ 15L,1L,1L,1L,1L,1L,2L,1L,5L,1L,1L,9L,1L,6L,1L,9L,1L,1L,5L,1L,2L,1L,1L,1L,1L,1L,30L,1L,1L,1L,1L,1L,2L,1L,5L,1L,1L,9L,1L,6L,1L,9L,1L,1L,5L,1L,2L,1L,1L,1L,1L,1L,30L,1L,1L,1L,1L,1L,2L,1L,5L,1L,1L,9L,1L,6L,1L,9L,1L,1L,5L,1L,2L,1L,1L,1L,1L,1L,30L,1L,1L,1L,1L,1L,2L,1L,5L,1L,1L,9L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040228Inst : IEnumerable<long>
{
public static readonly long[] Value=A040228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040228.Bytes);
public long this[int i]=>Value[i];

public static A040228Inst Instance=new A040228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040227
{
public static readonly long[] Value={ 15L,1L,1L,2L,3L,15L,3L,2L,1L,1L,30L,1L,1L,2L,3L,15L,3L,2L,1L,1L,30L,1L,1L,2L,3L,15L,3L,2L,1L,1L,30L,1L,1L,2L,3L,15L,3L,2L,1L,1L,30L,1L,1L,2L,3L,15L,3L,2L,1L,1L,30L,1L,1L,2L,3L,15L,3L,2L,1L,1L,30L,1L,1L,2L,3L,15L,3L,2L,1L,1L,30L,1L,1L,2L,3L,15L,3L,2L,1L,1L,30L,1L,1L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040227Inst : IEnumerable<long>
{
public static readonly long[] Value=A040227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040227.Bytes);
public long this[int i]=>Value[i];

public static A040227Inst Instance=new A040227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040226
{
public static readonly long[] Value={ 15L,1L,1L,3L,1L,14L,1L,3L,1L,1L,30L,1L,1L,3L,1L,14L,1L,3L,1L,1L,30L,1L,1L,3L,1L,14L,1L,3L,1L,1L,30L,1L,1L,3L,1L,14L,1L,3L,1L,1L,30L,1L,1L,3L,1L,14L,1L,3L,1L,1L,30L,1L,1L,3L,1L,14L,1L,3L,1L,1L,30L,1L,1L,3L,1L,14L,1L,3L,1L,1L,30L,1L,1L,3L,1L,14L,1L,3L,1L,1L,30L,1L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040226Inst : IEnumerable<long>
{
public static readonly long[] Value=A040226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040226.Bytes);
public long this[int i]=>Value[i];

public static A040226Inst Instance=new A040226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040225
{
public static readonly long[] Value={ 15L,1L,1L,9L,1L,5L,3L,3L,1L,1L,3L,3L,5L,1L,9L,1L,1L,30L,1L,1L,9L,1L,5L,3L,3L,1L,1L,3L,3L,5L,1L,9L,1L,1L,30L,1L,1L,9L,1L,5L,3L,3L,1L,1L,3L,3L,5L,1L,9L,1L,1L,30L,1L,1L,9L,1L,5L,3L,3L,1L,1L,3L,3L,5L,1L,9L,1L,1L,30L,1L,1L,9L,1L,5L,3L,3L,1L,1L,3L,3L,5L,1L,9L,1L,1L,30L,1L,1L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040225Inst : IEnumerable<long>
{
public static readonly long[] Value=A040225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040225.Bytes);
public long this[int i]=>Value[i];

public static A040225Inst Instance=new A040225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040224
{
public static readonly long[] Value={ 15L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L,2L,30L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040224Inst : IEnumerable<long>
{
public static readonly long[] Value=A040224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040224.Bytes);
public long this[int i]=>Value[i];

public static A040224Inst Instance=new A040224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040223
{
public static readonly long[] Value={ 15L,2L,5L,1L,2L,4L,15L,4L,2L,1L,5L,2L,30L,2L,5L,1L,2L,4L,15L,4L,2L,1L,5L,2L,30L,2L,5L,1L,2L,4L,15L,4L,2L,1L,5L,2L,30L,2L,5L,1L,2L,4L,15L,4L,2L,1L,5L,2L,30L,2L,5L,1L,2L,4L,15L,4L,2L,1L,5L,2L,30L,2L,5L,1L,2L,4L,15L,4L,2L,1L,5L,2L,30L,2L,5L,1L,2L,4L,15L,4L,2L,1L,5L,2L,30L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040223Inst : IEnumerable<long>
{
public static readonly long[] Value=A040223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040223.Bytes);
public long this[int i]=>Value[i];

public static A040223Inst Instance=new A040223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040222
{
public static readonly long[] Value={ 15L,2L,2L,1L,14L,1L,2L,2L,30L,2L,2L,1L,14L,1L,2L,2L,30L,2L,2L,1L,14L,1L,2L,2L,30L,2L,2L,1L,14L,1L,2L,2L,30L,2L,2L,1L,14L,1L,2L,2L,30L,2L,2L,1L,14L,1L,2L,2L,30L,2L,2L,1L,14L,1L,2L,2L,30L,2L,2L,1L,14L,1L,2L,2L,30L,2L,2L,1L,14L,1L,2L,2L,30L,2L,2L,1L,14L,1L,2L,2L,30L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040222Inst : IEnumerable<long>
{
public static readonly long[] Value=A040222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040222.Bytes);
public long this[int i]=>Value[i];

public static A040222Inst Instance=new A040222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040221
{
public static readonly long[] Value={ 15L,2L,1L,1L,7L,10L,7L,1L,1L,2L,30L,2L,1L,1L,7L,10L,7L,1L,1L,2L,30L,2L,1L,1L,7L,10L,7L,1L,1L,2L,30L,2L,1L,1L,7L,10L,7L,1L,1L,2L,30L,2L,1L,1L,7L,10L,7L,1L,1L,2L,30L,2L,1L,1L,7L,10L,7L,1L,1L,2L,30L,2L,1L,1L,7L,10L,7L,1L,1L,2L,30L,2L,1L,1L,7L,10L,7L,1L,1L,2L,30L,2L,1L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040221Inst : IEnumerable<long>
{
public static readonly long[] Value=A040221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040221.Bytes);
public long this[int i]=>Value[i];

public static A040221Inst Instance=new A040221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040204
{
public static readonly long[] Value={ 14L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L,28L,1L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040204Inst : IEnumerable<long>
{
public static readonly long[] Value=A040204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040204.Bytes);
public long this[int i]=>Value[i];

public static A040204Inst Instance=new A040204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040203
{
public static readonly long[] Value={ 14L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L,28L,1L,3L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040203Inst : IEnumerable<long>
{
public static readonly long[] Value=A040203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040203.Bytes);
public long this[int i]=>Value[i];

public static A040203Inst Instance=new A040203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040202
{
public static readonly long[] Value={ 14L,1L,2L,1L,2L,1L,1L,9L,4L,9L,1L,1L,2L,1L,2L,1L,28L,1L,2L,1L,2L,1L,1L,9L,4L,9L,1L,1L,2L,1L,2L,1L,28L,1L,2L,1L,2L,1L,1L,9L,4L,9L,1L,1L,2L,1L,2L,1L,28L,1L,2L,1L,2L,1L,1L,9L,4L,9L,1L,1L,2L,1L,2L,1L,28L,1L,2L,1L,2L,1L,1L,9L,4L,9L,1L,1L,2L,1L,2L,1L,28L,1L,2L,1L,2L,1L,1L,9L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040202Inst : IEnumerable<long>
{
public static readonly long[] Value=A040202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040202.Bytes);
public long this[int i]=>Value[i];

public static A040202Inst Instance=new A040202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040201
{
public static readonly long[] Value={ 14L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L,3L,2L,1L,28L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040201Inst : IEnumerable<long>
{
public static readonly long[] Value=A040201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040201.Bytes);
public long this[int i]=>Value[i];

public static A040201Inst Instance=new A040201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040200
{
public static readonly long[] Value={ 14L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L,28L,1L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040200Inst : IEnumerable<long>
{
public static readonly long[] Value=A040200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040200.Bytes);
public long this[int i]=>Value[i];

public static A040200Inst Instance=new A040200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040199
{
public static readonly long[] Value={ 14L,1L,1L,1L,2L,3L,1L,4L,9L,1L,1L,5L,3L,14L,3L,5L,1L,1L,9L,4L,1L,3L,2L,1L,1L,1L,28L,1L,1L,1L,2L,3L,1L,4L,9L,1L,1L,5L,3L,14L,3L,5L,1L,1L,9L,4L,1L,3L,2L,1L,1L,1L,28L,1L,1L,1L,2L,3L,1L,4L,9L,1L,1L,5L,3L,14L,3L,5L,1L,1L,9L,4L,1L,3L,2L,1L,1L,1L,28L,1L,1L,1L,2L,3L,1L,4L,9L,1L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040199Inst : IEnumerable<long>
{
public static readonly long[] Value=A040199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040199.Bytes);
public long this[int i]=>Value[i];

public static A040199Inst Instance=new A040199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040198
{
public static readonly long[] Value={ 14L,1L,1L,2L,6L,1L,8L,1L,6L,2L,1L,1L,28L,1L,1L,2L,6L,1L,8L,1L,6L,2L,1L,1L,28L,1L,1L,2L,6L,1L,8L,1L,6L,2L,1L,1L,28L,1L,1L,2L,6L,1L,8L,1L,6L,2L,1L,1L,28L,1L,1L,2L,6L,1L,8L,1L,6L,2L,1L,1L,28L,1L,1L,2L,6L,1L,8L,1L,6L,2L,1L,1L,28L,1L,1L,2L,6L,1L,8L,1L,6L,2L,1L,1L,28L,1L,1L,2L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040198Inst : IEnumerable<long>
{
public static readonly long[] Value=A040198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040198.Bytes);
public long this[int i]=>Value[i];

public static A040198Inst Instance=new A040198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040197
{
public static readonly long[] Value={ 14L,1L,1L,3L,1L,1L,1L,6L,1L,1L,1L,3L,1L,1L,28L,1L,1L,3L,1L,1L,1L,6L,1L,1L,1L,3L,1L,1L,28L,1L,1L,3L,1L,1L,1L,6L,1L,1L,1L,3L,1L,1L,28L,1L,1L,3L,1L,1L,1L,6L,1L,1L,1L,3L,1L,1L,28L,1L,1L,3L,1L,1L,1L,6L,1L,1L,1L,3L,1L,1L,28L,1L,1L,3L,1L,1L,1L,6L,1L,1L,1L,3L,1L,1L,28L,1L,1L,3L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040197Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040197.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040197Inst : IEnumerable<long>
{
public static readonly long[] Value=A040197.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040197.Bytes);
public long this[int i]=>Value[i];

public static A040197Inst Instance=new A040197Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040196
{
public static readonly long[] Value={ 14L,1L,1L,9L,5L,1L,2L,2L,1L,1L,4L,3L,1L,13L,1L,3L,4L,1L,1L,2L,2L,1L,5L,9L,1L,1L,28L,1L,1L,9L,5L,1L,2L,2L,1L,1L,4L,3L,1L,13L,1L,3L,4L,1L,1L,2L,2L,1L,5L,9L,1L,1L,28L,1L,1L,9L,5L,1L,2L,2L,1L,1L,4L,3L,1L,13L,1L,3L,4L,1L,1L,2L,2L,1L,5L,9L,1L,1L,28L,1L,1L,9L,5L,1L,2L,2L,1L,1L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040196Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040196.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040196Inst : IEnumerable<long>
{
public static readonly long[] Value=A040196.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040196.Bytes);
public long this[int i]=>Value[i];

public static A040196Inst Instance=new A040196Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040195
{
public static readonly long[] Value={ 14L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L,2L,28L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040195Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040195.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040195Inst : IEnumerable<long>
{
public static readonly long[] Value=A040195.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040195.Bytes);
public long this[int i]=>Value[i];

public static A040195Inst Instance=new A040195Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040194
{
public static readonly long[] Value={ 14L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L,28L,2L,5L,3L,2L,3L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040194Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040194.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040194Inst : IEnumerable<long>
{
public static readonly long[] Value=A040194.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040194.Bytes);
public long this[int i]=>Value[i];

public static A040194Inst Instance=new A040194Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040193
{
public static readonly long[] Value={ 14L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L,1L,2L,2L,28L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040193Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040193.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040193Inst : IEnumerable<long>
{
public static readonly long[] Value=A040193.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040193.Bytes);
public long this[int i]=>Value[i];

public static A040193Inst Instance=new A040193Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040192
{
public static readonly long[] Value={ 14L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L,28L,2L,1L,1L,2L,1L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040192Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040192.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040192Inst : IEnumerable<long>
{
public static readonly long[] Value=A040192.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040192.Bytes);
public long this[int i]=>Value[i];

public static A040192Inst Instance=new A040192Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040191
{
public static readonly long[] Value={ 14L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L,14L,5L,1L,2L,28L,2L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040191Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040191.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040191Inst : IEnumerable<long>
{
public static readonly long[] Value=A040191.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040191.Bytes);
public long this[int i]=>Value[i];

public static A040191Inst Instance=new A040191Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040190
{
public static readonly long[] Value={ 14L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L,28L,3L,6L,1L,4L,1L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040190Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040190.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040190Inst : IEnumerable<long>
{
public static readonly long[] Value=A040190.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040190.Bytes);
public long this[int i]=>Value[i];

public static A040190Inst Instance=new A040190Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040189
{
public static readonly long[] Value={ 14L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L,28L,3L,1L,1L,6L,1L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040189Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040189.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040189Inst : IEnumerable<long>
{
public static readonly long[] Value=A040189.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040189.Bytes);
public long this[int i]=>Value[i];

public static A040189Inst Instance=new A040189Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040156
{
public static readonly long[] Value={ 13L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040156Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040156.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040156Inst : IEnumerable<long>
{
public static readonly long[] Value=A040156.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040156.Bytes);
public long this[int i]=>Value[i];

public static A040156Inst Instance=new A040156Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040155
{
public static readonly long[] Value={ 12L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L,24L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040155Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040155.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040155Inst : IEnumerable<long>
{
public static readonly long[] Value=A040155.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040155.Bytes);
public long this[int i]=>Value[i];

public static A040155Inst Instance=new A040155Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040154
{
public static readonly long[] Value={ 2L,7L,11L,19L,23L,29L,41L,43L,67L,79L,83L,103L,107L,173L,191L,197L,199L,227L,233L,251L,257L,263L,269L,277L,283L,317L,349L,359L,367L,379L,383L,419L,431L,449L,461L,467L,479L,503L,509L,523L,541L,563L,571L,593L,619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040154Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040154.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040154Inst : IEnumerable<long>
{
public static readonly long[] Value=A040154.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040154.Bytes);
public long this[int i]=>Value[i];

public static A040154Inst Instance=new A040154Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040153
{
public static readonly long[] Value={ 5L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,71L,73L,83L,101L,103L,107L,113L,131L,139L,149L,157L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,241L,269L,277L,281L,283L,307L,311L,313L,317L,337L,347L,349L,367L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040153Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040153.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040153Inst : IEnumerable<long>
{
public static readonly long[] Value=A040153.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040153.Bytes);
public long this[int i]=>Value[i];

public static A040153Inst Instance=new A040153Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040152
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,59L,61L,67L,79L,89L,97L,109L,127L,137L,151L,163L,167L,173L,179L,239L,251L,257L,263L,271L,293L,331L,353L,359L,379L,401L,419L,431L,433L,439L,443L,467L,479L,499L,503L,521L,541L,587L,607L,613L,619L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040152Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040152.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040152Inst : IEnumerable<long>
{
public static readonly long[] Value=A040152.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040152.Bytes);
public long this[int i]=>Value[i];

public static A040152Inst Instance=new A040152Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040151
{
public static readonly long[] Value={ 12L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L,6L,4L,1L,24L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040151Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040151.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040151Inst : IEnumerable<long>
{
public static readonly long[] Value=A040151.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040151.Bytes);
public long this[int i]=>Value[i];

public static A040151Inst Instance=new A040151Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040150
{
public static readonly long[] Value={ 11L,13L,19L,23L,29L,31L,37L,41L,53L,61L,71L,73L,89L,97L,101L,103L,107L,113L,137L,139L,149L,157L,173L,179L,181L,191L,197L,199L,223L,229L,233L,239L,241L,257L,263L,271L,277L,281L,283L,293L,307L,313L,317L,347L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040150Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040150.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040150Inst : IEnumerable<long>
{
public static readonly long[] Value=A040150.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040150.Bytes);
public long this[int i]=>Value[i];

public static A040150Inst Instance=new A040150Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040149
{
public static readonly long[] Value={ 2L,3L,5L,7L,17L,43L,47L,59L,67L,79L,83L,109L,127L,131L,151L,163L,167L,193L,211L,227L,251L,269L,311L,331L,337L,353L,373L,379L,383L,419L,463L,467L,479L,487L,499L,503L,509L,521L,547L,563L,571L,587L,593L,631L,647L,709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040149Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040149.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040149Inst : IEnumerable<long>
{
public static readonly long[] Value=A040149.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040149.Bytes);
public long this[int i]=>Value[i];

public static A040149Inst Instance=new A040149Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040148
{
public static readonly long[] Value={ 3L,7L,13L,17L,23L,37L,41L,43L,47L,53L,67L,73L,83L,89L,97L,101L,103L,107L,109L,113L,127L,137L,149L,157L,163L,167L,173L,181L,193L,197L,223L,227L,233L,241L,257L,263L,269L,277L,281L,283L,293L,307L,313L,317L,337L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040148Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040148.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040148Inst : IEnumerable<long>
{
public static readonly long[] Value=A040148.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040148.Bytes);
public long this[int i]=>Value[i];

public static A040148Inst Instance=new A040148Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040147
{
public static readonly long[] Value={ 2L,5L,11L,19L,29L,31L,59L,61L,71L,79L,131L,139L,151L,179L,191L,199L,211L,229L,239L,251L,271L,311L,331L,349L,359L,379L,401L,409L,419L,421L,431L,439L,449L,479L,491L,499L,509L,521L,569L,571L,599L,619L,631L,659L,661L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040147Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040147.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040147Inst : IEnumerable<long>
{
public static readonly long[] Value=A040147.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040147.Bytes);
public long this[int i]=>Value[i];

public static A040147Inst Instance=new A040147Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040146
{
public static readonly long[] Value={ 5L,7L,11L,13L,17L,23L,29L,37L,41L,43L,47L,53L,61L,73L,83L,89L,97L,109L,113L,131L,137L,139L,163L,173L,181L,191L,193L,197L,199L,239L,241L,251L,257L,263L,269L,271L,281L,283L,293L,311L,317L,337L,347L,353L,359L,367L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040146Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040146.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040146Inst : IEnumerable<long>
{
public static readonly long[] Value=A040146.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040146.Bytes);
public long this[int i]=>Value[i];

public static A040146Inst Instance=new A040146Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040145
{
public static readonly long[] Value={ 2L,3L,19L,31L,59L,67L,71L,79L,101L,103L,107L,127L,149L,151L,157L,167L,179L,211L,223L,227L,229L,233L,277L,307L,313L,331L,349L,379L,383L,397L,431L,439L,457L,461L,487L,523L,547L,557L,563L,577L,593L,599L,607L,613L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040145Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040145.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040145Inst : IEnumerable<long>
{
public static readonly long[] Value=A040145.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040145.Bytes);
public long this[int i]=>Value[i];

public static A040145Inst Instance=new A040145Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040144
{
public static readonly long[] Value={ 5L,11L,13L,19L,29L,37L,43L,53L,59L,61L,67L,83L,89L,97L,101L,107L,109L,113L,131L,139L,149L,157L,163L,173L,179L,181L,193L,197L,211L,227L,229L,233L,241L,251L,257L,269L,277L,281L,283L,293L,307L,313L,317L,331L,347L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040144Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040144.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040144Inst : IEnumerable<long>
{
public static readonly long[] Value=A040144.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040144.Bytes);
public long this[int i]=>Value[i];

public static A040144Inst Instance=new A040144Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040143
{
public static readonly long[] Value={ 12L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L,24L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040143Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040143.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040143Inst : IEnumerable<long>
{
public static readonly long[] Value=A040143.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040143.Bytes);
public long this[int i]=>Value[i];

public static A040143Inst Instance=new A040143Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040142
{
public static readonly long[] Value={ 12L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L,24L,2L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040142Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040142.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040142Inst : IEnumerable<long>
{
public static readonly long[] Value=A040142.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040142.Bytes);
public long this[int i]=>Value[i];

public static A040142Inst Instance=new A040142Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040141
{
public static readonly long[] Value={ 2L,3L,7L,17L,23L,31L,41L,47L,71L,73L,79L,103L,127L,137L,151L,167L,191L,199L,223L,239L,263L,271L,311L,337L,359L,367L,383L,401L,431L,439L,449L,463L,479L,487L,503L,521L,569L,577L,599L,601L,607L,631L,641L,647L,719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040141Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040141.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040141Inst : IEnumerable<long>
{
public static readonly long[] Value=A040141.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040141.Bytes);
public long this[int i]=>Value[i];

public static A040141Inst Instance=new A040141Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040124
{
public static readonly long[] Value={ 2L,3L,11L,23L,37L,47L,59L,61L,71L,83L,107L,131L,157L,167L,179L,191L,193L,227L,239L,251L,263L,311L,313L,347L,349L,359L,373L,383L,397L,419L,431L,433L,443L,467L,479L,491L,503L,563L,577L,587L,599L,601L,613L,647L,659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040124Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040124.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040124Inst : IEnumerable<long>
{
public static readonly long[] Value=A040124.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040124.Bytes);
public long this[int i]=>Value[i];

public static A040124Inst Instance=new A040124Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040123
{
public static readonly long[] Value={ 3L,13L,17L,23L,29L,31L,37L,41L,47L,53L,59L,61L,67L,71L,73L,97L,101L,103L,109L,113L,137L,149L,163L,173L,179L,181L,191L,193L,197L,199L,223L,229L,233L,241L,251L,269L,277L,281L,293L,311L,331L,337L,349L,367L,373L,379L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040123Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040123.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040123Inst : IEnumerable<long>
{
public static readonly long[] Value=A040123.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040123.Bytes);
public long this[int i]=>Value[i];

public static A040123Inst Instance=new A040123Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040122
{
public static readonly long[] Value={ 2L,5L,7L,11L,19L,43L,79L,83L,89L,107L,127L,131L,139L,151L,157L,167L,211L,227L,239L,257L,263L,271L,283L,307L,313L,317L,347L,353L,359L,389L,397L,421L,431L,439L,449L,479L,491L,503L,523L,547L,563L,571L,607L,641L,659L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040122Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040122.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040122Inst : IEnumerable<long>
{
public static readonly long[] Value=A040122.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040122.Bytes);
public long this[int i]=>Value[i];

public static A040122Inst Instance=new A040122Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040121
{
public static readonly long[] Value={ 7L,11L,13L,17L,19L,23L,29L,47L,59L,61L,73L,89L,97L,101L,103L,109L,113L,127L,131L,137L,139L,149L,157L,167L,179L,181L,193L,197L,211L,223L,229L,233L,251L,257L,263L,269L,281L,293L,313L,331L,337L,349L,353L,367L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040121Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040121.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040121Inst : IEnumerable<long>
{
public static readonly long[] Value=A040121.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040121.Bytes);
public long this[int i]=>Value[i];

public static A040121Inst Instance=new A040121Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040120
{
public static readonly long[] Value={ 11L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L,22L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040120Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040120.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040120Inst : IEnumerable<long>
{
public static readonly long[] Value=A040120.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040120.Bytes);
public long this[int i]=>Value[i];

public static A040120Inst Instance=new A040120Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040119
{
public static readonly long[] Value={ 2L,3L,5L,31L,37L,41L,43L,53L,67L,71L,79L,83L,107L,151L,163L,173L,191L,199L,227L,239L,241L,271L,277L,283L,307L,311L,317L,347L,359L,397L,431L,439L,443L,467L,479L,523L,547L,563L,587L,599L,613L,631L,641L,643L,683L,719L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040119Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040119.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040119Inst : IEnumerable<long>
{
public static readonly long[] Value=A040119.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040119.Bytes);
public long this[int i]=>Value[i];

public static A040119Inst Instance=new A040119Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040118
{
public static readonly long[] Value={ 11L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L,2L,2L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040118Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040118.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040118Inst : IEnumerable<long>
{
public static readonly long[] Value=A040118.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040118.Bytes);
public long this[int i]=>Value[i];

public static A040118Inst Instance=new A040118Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040117
{
public static readonly long[] Value={ 5L,17L,29L,41L,53L,89L,101L,113L,137L,149L,173L,197L,233L,257L,269L,281L,293L,317L,353L,389L,401L,449L,461L,509L,521L,557L,569L,593L,617L,641L,653L,677L,701L,761L,773L,797L,809L,821L,857L,881L,929L,941L,953L,977L,1013L,1049L,1061L,1097L,1109L,1181L,1193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040117Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040117.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040117Inst : IEnumerable<long>
{
public static readonly long[] Value=A040117.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040117.Bytes);
public long this[int i]=>Value[i];

public static A040117Inst Instance=new A040117Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040116
{
public static readonly long[] Value={ 2L,3L,7L,11L,13L,19L,23L,31L,37L,43L,47L,59L,61L,67L,71L,73L,79L,83L,97L,103L,107L,109L,127L,131L,139L,151L,157L,163L,167L,179L,181L,191L,193L,199L,211L,223L,227L,229L,239L,241L,251L,263L,271L,277L,283L,307L,311L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040116Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040116.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040116Inst : IEnumerable<long>
{
public static readonly long[] Value=A040116.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040116.Bytes);
public long this[int i]=>Value[i];

public static A040116Inst Instance=new A040116Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040115
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,10L,11L,12L,13L,14L,15L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040115Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040115.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040115Inst : IEnumerable<long>
{
public static readonly long[] Value=A040115.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040115.Bytes);
public long this[int i]=>Value[i];

public static A040115Inst Instance=new A040115Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040114
{
public static readonly long[] Value={ 1L,0L,1L,2L,3L,4L,5L,6L,7L,8L,2L,1L,0L,1L,2L,3L,4L,5L,6L,7L,3L,2L,1L,0L,1L,2L,3L,4L,5L,6L,4L,3L,2L,1L,0L,1L,2L,3L,4L,5L,5L,4L,3L,2L,1L,0L,1L,2L,3L,4L,6L,5L,4L,3L,2L,1L,0L,1L,2L,3L,7L,6L,5L,4L,3L,2L,1L,0L,1L,2L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,9L,8L,7L,6L,5L,4L,3L,2L,1L,0L,1L,0L,1L,1L,1L,2L,1L,3L,1L,4L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040114Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040114.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040114Inst : IEnumerable<long>
{
public static readonly long[] Value=A040114.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040114.Bytes);
public long this[int i]=>Value[i];

public static A040114Inst Instance=new A040114Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040113
{
public static readonly long[] Value={ 5L,11L,13L,17L,23L,41L,43L,53L,61L,67L,71L,73L,79L,89L,97L,101L,107L,127L,137L,149L,151L,157L,163L,173L,179L,181L,191L,197L,211L,229L,233L,239L,241L,257L,263L,269L,277L,281L,293L,313L,317L,331L,337L,347L,349L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040113Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040113.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040113Inst : IEnumerable<long>
{
public static readonly long[] Value=A040113.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040113.Bytes);
public long this[int i]=>Value[i];

public static A040113Inst Instance=new A040113Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040112
{
public static readonly long[] Value={ 2L,3L,7L,19L,29L,31L,37L,47L,59L,83L,103L,109L,113L,131L,139L,167L,193L,199L,223L,227L,251L,271L,283L,307L,311L,367L,383L,389L,419L,439L,449L,457L,467L,479L,503L,523L,563L,587L,607L,613L,619L,643L,647L,653L,691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040112Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040112.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040112Inst : IEnumerable<long>
{
public static readonly long[] Value=A040112.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040112.Bytes);
public long this[int i]=>Value[i];

public static A040112Inst Instance=new A040112Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040111
{
public static readonly long[] Value={ 11L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L,22L,11L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040111Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040111.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040111Inst : IEnumerable<long>
{
public static readonly long[] Value=A040111.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040111.Bytes);
public long this[int i]=>Value[i];

public static A040111Inst Instance=new A040111Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040110
{
public static readonly long[] Value={ 11L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L,22L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040110Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040110.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040110Inst : IEnumerable<long>
{
public static readonly long[] Value=A040110.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040110.Bytes);
public long this[int i]=>Value[i];

public static A040110Inst Instance=new A040110Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040109
{
public static readonly long[] Value={ 10L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L,20L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040109Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040109.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040109Inst : IEnumerable<long>
{
public static readonly long[] Value=A040109.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040109.Bytes);
public long this[int i]=>Value[i];

public static A040109Inst Instance=new A040109Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040092
{
public static readonly long[] Value={ 13L,19L,31L,37L,61L,109L,127L,139L,151L,157L,193L,199L,211L,223L,241L,271L,277L,283L,307L,313L,337L,349L,367L,379L,397L,409L,421L,433L,439L,463L,487L,499L,523L,541L,547L,577L,601L,607L,619L,631L,643L,691L,709L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040092Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040092.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040092Inst : IEnumerable<long>
{
public static readonly long[] Value=A040092.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040092.Bytes);
public long this[int i]=>Value[i];

public static A040092Inst Instance=new A040092Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040091
{
public static readonly long[] Value={ 10L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L,20L,10L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040091Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040091.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040091Inst : IEnumerable<long>
{
public static readonly long[] Value=A040091.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040091.Bytes);
public long this[int i]=>Value[i];

public static A040091Inst Instance=new A040091Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040090
{
public static readonly long[] Value={ 10L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L,20L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040090Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040090.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040090Inst : IEnumerable<long>
{
public static readonly long[] Value=A040090.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040090.Bytes);
public long this[int i]=>Value[i];

public static A040090Inst Instance=new A040090Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040089
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,23L,29L,41L,43L,47L,53L,59L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,113L,131L,137L,149L,163L,167L,173L,179L,181L,191L,197L,227L,229L,233L,239L,251L,257L,263L,269L,281L,293L,311L,317L,331L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040089Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040089.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040089Inst : IEnumerable<long>
{
public static readonly long[] Value=A040089.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040089.Bytes);
public long this[int i]=>Value[i];

public static A040089Inst Instance=new A040089Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040088
{
public static readonly long[] Value={ 19L,31L,37L,61L,67L,97L,103L,109L,127L,139L,151L,157L,181L,193L,199L,211L,223L,271L,307L,313L,331L,337L,373L,379L,397L,409L,421L,463L,487L,499L,523L,541L,547L,571L,577L,601L,607L,613L,619L,643L,673L,709L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040088Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040088.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040088Inst : IEnumerable<long>
{
public static readonly long[] Value=A040088.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040088.Bytes);
public long this[int i]=>Value[i];

public static A040088Inst Instance=new A040088Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040087
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,23L,29L,41L,43L,47L,53L,59L,71L,73L,79L,83L,89L,101L,107L,113L,131L,137L,149L,163L,167L,173L,179L,191L,197L,227L,229L,233L,239L,241L,251L,257L,263L,269L,277L,281L,283L,293L,311L,317L,347L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040087Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040087.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040087Inst : IEnumerable<long>
{
public static readonly long[] Value=A040087.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040087.Bytes);
public long this[int i]=>Value[i];

public static A040087Inst Instance=new A040087Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040086
{
public static readonly long[] Value={ 13L,31L,37L,43L,67L,73L,79L,103L,109L,139L,157L,163L,181L,199L,211L,223L,229L,241L,271L,277L,283L,307L,313L,331L,337L,349L,367L,379L,397L,409L,421L,433L,439L,463L,487L,499L,547L,601L,607L,613L,631L,661L,673L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040086Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040086.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040086Inst : IEnumerable<long>
{
public static readonly long[] Value=A040086.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040086.Bytes);
public long this[int i]=>Value[i];

public static A040086Inst Instance=new A040086Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040085
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,19L,23L,29L,41L,47L,53L,59L,61L,71L,83L,89L,97L,101L,107L,113L,127L,131L,137L,149L,151L,167L,173L,179L,191L,193L,197L,227L,233L,239L,251L,257L,263L,269L,281L,293L,311L,317L,347L,353L,359L,373L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040085Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040085.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040085Inst : IEnumerable<long>
{
public static readonly long[] Value=A040085.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040085.Bytes);
public long this[int i]=>Value[i];

public static A040085Inst Instance=new A040085Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040084
{
public static readonly long[] Value={ 7L,13L,31L,37L,43L,61L,67L,73L,79L,103L,139L,157L,163L,193L,199L,211L,223L,229L,241L,331L,337L,349L,367L,379L,397L,433L,439L,457L,463L,499L,523L,541L,547L,571L,601L,607L,619L,631L,643L,673L,709L,727L,739L,751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040084Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040084.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040084Inst : IEnumerable<long>
{
public static readonly long[] Value=A040084.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040084.Bytes);
public long this[int i]=>Value[i];

public static A040084Inst Instance=new A040084Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040083
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,19L,23L,29L,41L,47L,53L,59L,71L,83L,89L,97L,101L,107L,109L,113L,127L,131L,137L,149L,151L,167L,173L,179L,181L,191L,197L,227L,233L,239L,251L,257L,263L,269L,271L,277L,281L,283L,293L,307L,311L,313L,317L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040083Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040083.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040083Inst : IEnumerable<long>
{
public static readonly long[] Value=A040083.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040083.Bytes);
public long this[int i]=>Value[i];

public static A040083Inst Instance=new A040083Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040082
{
public static readonly BigInteger[] Value={ 1L,1L,1L,2L,2L,22L,564L,1676267L,115618721533L,208904371354363006L,BigInteger.Parse("12216177315369229261482540") };
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
public class A040082Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040082.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040082Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A040082.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A040082.Bytes);
public BigInteger this[int i]=>Value[i];

public static A040082Inst Instance=new A040082Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040081
{
public static readonly long[] Value={ 2L,1L,0L,0L,2L,0L,1L,0L,1L,1L,2L,0L,3L,0L,1L,1L,2L,0L,1L,0L,1L,1L,4L,0L,3L,2L,1L,3L,4L,0L,1L,0L,2L,1L,2L,1L,1L,0L,3L,1L,2L,0L,7L,0L,1L,3L,4L,0L,1L,2L,1L,1L,2L,0L,1L,2L,1L,3L,12L,0L,3L,0L,2L,1L,4L,1L,5L,0L,1L,1L,2L,0L,7L,0L,1L,1L,2L,2L,1L,0L,3L,1L,2L,0L,5L,6L,1L,23L,4L,0L,1L,2L,3L,3L,2L,1L,1L,0L,1L,1L,10L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040081Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040081.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040081Inst : IEnumerable<long>
{
public static readonly long[] Value=A040081.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040081.Bytes);
public long this[int i]=>Value[i];

public static A040081Inst Instance=new A040081Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040080
{
public static readonly long[] Value={ 9L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L,18L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040080Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040080.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040080Inst : IEnumerable<long>
{
public static readonly long[] Value=A040080.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040080.Bytes);
public long this[int i]=>Value[i];

public static A040080Inst Instance=new A040080Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040079
{
public static readonly long[] Value={ 7L,13L,19L,31L,37L,43L,61L,67L,97L,103L,127L,139L,151L,157L,181L,193L,211L,271L,277L,283L,313L,331L,367L,379L,409L,421L,433L,439L,463L,487L,499L,547L,571L,577L,601L,607L,613L,631L,643L,661L,673L,691L,709L,727L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040079Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040079.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040079Inst : IEnumerable<long>
{
public static readonly long[] Value=A040079.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040079.Bytes);
public long this[int i]=>Value[i];

public static A040079Inst Instance=new A040079Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040078
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,23L,29L,41L,47L,53L,59L,71L,73L,79L,83L,89L,101L,107L,109L,113L,131L,137L,149L,163L,167L,173L,179L,191L,197L,199L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,281L,293L,307L,311L,317L,337L,347L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040078Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040078.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040078Inst : IEnumerable<long>
{
public static readonly long[] Value=A040078.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040078.Bytes);
public long this[int i]=>Value[i];

public static A040078Inst Instance=new A040078Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040077
{
public static readonly long[] Value={ 9L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L,18L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040077Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040077.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040077Inst : IEnumerable<long>
{
public static readonly long[] Value=A040077.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040077.Bytes);
public long this[int i]=>Value[i];

public static A040077Inst Instance=new A040077Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040060
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,19L,23L,29L,37L,41L,43L,47L,53L,59L,61L,71L,83L,89L,101L,107L,113L,131L,137L,149L,167L,173L,179L,191L,193L,197L,199L,211L,227L,229L,233L,239L,251L,257L,263L,269L,281L,293L,311L,317L,337L,347L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040060Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040060.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040060Inst : IEnumerable<long>
{
public static readonly long[] Value=A040060.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040060.Bytes);
public long this[int i]=>Value[i];

public static A040060Inst Instance=new A040060Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040059
{
public static readonly long[] Value={ 8L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L,16L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040059Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040059.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040059Inst : IEnumerable<long>
{
public static readonly long[] Value=A040059.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040059.Bytes);
public long this[int i]=>Value[i];

public static A040059Inst Instance=new A040059Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040058
{
public static readonly long[] Value={ 7L,13L,19L,31L,43L,61L,67L,97L,109L,151L,157L,163L,181L,193L,199L,211L,223L,229L,241L,277L,283L,307L,313L,337L,367L,373L,379L,397L,409L,433L,439L,487L,499L,523L,541L,571L,577L,601L,619L,631L,709L,727L,757L,769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040058Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040058.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040058Inst : IEnumerable<long>
{
public static readonly long[] Value=A040058.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040058.Bytes);
public long this[int i]=>Value[i];

public static A040058Inst Instance=new A040058Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040057
{
public static readonly long[] Value={ 8L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L,16L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040057Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040057.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040057Inst : IEnumerable<long>
{
public static readonly long[] Value=A040057.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040057.Bytes);
public long this[int i]=>Value[i];

public static A040057Inst Instance=new A040057Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040056
{
public static readonly long[] Value={ 8L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040056Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040056.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040056Inst : IEnumerable<long>
{
public static readonly long[] Value=A040056.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040056.Bytes);
public long this[int i]=>Value[i];

public static A040056Inst Instance=new A040056Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040055
{
public static readonly long[] Value={ 7L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L,14L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040055Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040055.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040055Inst : IEnumerable<long>
{
public static readonly long[] Value=A040055.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040055.Bytes);
public long this[int i]=>Value[i];

public static A040055Inst Instance=new A040055Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040054
{
public static readonly long[] Value={ 2L,3L,5L,11L,17L,23L,29L,37L,41L,47L,53L,59L,71L,73L,79L,83L,89L,101L,103L,107L,113L,127L,131L,137L,139L,149L,167L,173L,179L,191L,197L,227L,233L,239L,251L,257L,263L,269L,271L,281L,293L,311L,317L,331L,347L,349L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040054Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040054.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040054Inst : IEnumerable<long>
{
public static readonly long[] Value=A040054.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040054.Bytes);
public long this[int i]=>Value[i];

public static A040054Inst Instance=new A040054Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040053
{
public static readonly long[] Value={ 1L,0L,1L,0L,1L,0L,0L,1L,0L,0L,1L,0L,0L,1L,1L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,0L,0L,0L,1L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040053Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040053.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040053Inst : IEnumerable<long>
{
public static readonly long[] Value=A040053.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040053.Bytes);
public long this[int i]=>Value[i];

public static A040053Inst Instance=new A040053Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040052
{
public static readonly long[] Value={ 7L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L,1L,2L,1L,14L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040052Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040052.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040052Inst : IEnumerable<long>
{
public static readonly long[] Value=A040052.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040052.Bytes);
public long this[int i]=>Value[i];

public static A040052Inst Instance=new A040052Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040051
{
public static readonly long[] Value={ 1L,1L,0L,1L,1L,1L,1L,1L,0L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,1L,0L,0L,1L,1L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,1L,1L,1L,1L,1L,0L,1L,0L,1L,1L,0L,0L,0L,1L,1L,0L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,1L,0L,1L,0L,0L,0L,1L,1L,1L,0L,1L,1L,1L,0L,0L,1L,1L,0L,0L,0L,1L,1L,1L,0L,1L,0L,1L,1L,1L,1L,1L,1L,1L,0L,1L,0L,0L,0L,1L,0L,0L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040051Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040051.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040051Inst : IEnumerable<long>
{
public static readonly long[] Value=A040051.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040051.Bytes);
public long this[int i]=>Value[i];

public static A040051Inst Instance=new A040051Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040050
{
public static readonly long[] Value={ 13L,31L,37L,43L,61L,67L,79L,97L,103L,109L,127L,139L,151L,163L,193L,199L,211L,229L,241L,271L,277L,283L,307L,349L,379L,397L,409L,433L,457L,499L,523L,547L,577L,601L,613L,619L,631L,643L,691L,709L,727L,733L,739L,757L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040050Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040050.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040050Inst : IEnumerable<long>
{
public static readonly long[] Value=A040050.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040050.Bytes);
public long this[int i]=>Value[i];

public static A040050Inst Instance=new A040050Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040049
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,19L,23L,29L,41L,47L,53L,59L,71L,73L,83L,89L,101L,107L,113L,131L,137L,149L,157L,167L,173L,179L,181L,191L,197L,223L,227L,233L,239L,251L,257L,263L,269L,281L,293L,311L,313L,317L,331L,337L,347L,353L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040049Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040049.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040049Inst : IEnumerable<long>
{
public static readonly long[] Value=A040049.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040049.Bytes);
public long this[int i]=>Value[i];

public static A040049Inst Instance=new A040049Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040048
{
public static readonly long[] Value={ 7L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L,14L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040048Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040048.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040048Inst : IEnumerable<long>
{
public static readonly long[] Value=A040048.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040048.Bytes);
public long this[int i]=>Value[i];

public static A040048Inst Instance=new A040048Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040047
{
public static readonly long[] Value={ 13L,19L,31L,43L,61L,67L,73L,79L,97L,103L,109L,127L,151L,157L,193L,199L,211L,223L,229L,271L,277L,283L,331L,367L,373L,397L,433L,457L,463L,487L,523L,547L,577L,601L,613L,619L,661L,673L,691L,709L,733L,739L,757L,769L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040047Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040047.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040047Inst : IEnumerable<long>
{
public static readonly long[] Value=A040047.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040047.Bytes);
public long this[int i]=>Value[i];

public static A040047Inst Instance=new A040047Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040046
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,17L,23L,29L,37L,41L,47L,53L,59L,71L,83L,89L,101L,107L,113L,131L,137L,139L,149L,163L,167L,173L,179L,181L,191L,197L,227L,233L,239L,241L,251L,257L,263L,269L,281L,293L,307L,311L,313L,317L,337L,347L,349L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040046Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040046.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040046Inst : IEnumerable<long>
{
public static readonly long[] Value=A040046.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040046.Bytes);
public long this[int i]=>Value[i];

public static A040046Inst Instance=new A040046Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A040045
{
public static readonly long[] Value={ 7L,19L,31L,37L,43L,61L,73L,79L,97L,103L,109L,139L,151L,157L,193L,223L,229L,271L,277L,283L,307L,331L,349L,373L,397L,421L,433L,439L,463L,499L,523L,541L,547L,571L,577L,601L,607L,613L,619L,661L,673L,709L,727L,751L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A040045Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A040045.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A040045Inst : IEnumerable<long>
{
public static readonly long[] Value=A040045.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A040045.Bytes);
public long this[int i]=>Value[i];

public static A040045Inst Instance=new A040045Inst();

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