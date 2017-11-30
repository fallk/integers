using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

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

public static class A039772
{
public static readonly long[] Value={ 28L,52L,66L,70L,76L,112L,124L,130L,148L,154L,172L,176L,186L,190L,196L,208L,232L,238L,244L,246L,268L,276L,280L,286L,292L,304L,310L,316L,322L,344L,364L,366L,370L,388L,396L,406L,412L,418L,426L,430L,436L,442L,448L,490L,496L,506L,508L,520L,532L,556L,568L,574L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039772Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039772.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039772Inst : IEnumerable<long>
{
public static readonly long[] Value=A039772.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039772.Bytes);
public long this[int i]=>Value[i];

public static A039772Inst Instance=new A039772Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039771
{
public static readonly long[] Value={ 1L,2L,15L,16L,20L,24L,30L,85L,128L,136L,160L,170L,192L,204L,240L,247L,259L,327L,333L,351L,399L,405L,436L,494L,518L,532L,648L,654L,666L,684L,702L,756L,771L,798L,810L,1024L,1028L,1088L,1111L,1255L,1280L,1360L,1375L,1536L,1542L,1632L,1843L,1853L,1875L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039771Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039771.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039771Inst : IEnumerable<long>
{
public static readonly long[] Value=A039771.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039771.Bytes);
public long this[int i]=>Value[i];

public static A039771Inst Instance=new A039771Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039770
{
public static readonly long[] Value={ 1L,2L,5L,8L,10L,12L,17L,32L,34L,37L,40L,48L,57L,60L,63L,74L,76L,85L,101L,108L,114L,125L,126L,128L,136L,160L,170L,185L,192L,197L,202L,204L,219L,240L,250L,257L,273L,285L,292L,296L,304L,315L,364L,370L,380L,394L,401L,432L,438L,444L,451L,456L,468L,489L,504L,505L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039770Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039770.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039770Inst : IEnumerable<long>
{
public static readonly long[] Value=A039770.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039770.Bytes);
public long this[int i]=>Value[i];

public static A039770Inst Instance=new A039770Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039769
{
public static readonly long[] Value={ 9L,15L,21L,25L,27L,28L,33L,35L,39L,45L,49L,51L,52L,55L,57L,63L,65L,66L,69L,70L,75L,76L,77L,81L,85L,87L,91L,93L,95L,99L,105L,111L,112L,115L,117L,119L,121L,123L,124L,125L,129L,130L,133L,135L,141L,143L,145L,147L,148L,153L,154L,155L,159L,161L,165L,169L,171L,172L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039769Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039769.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039769Inst : IEnumerable<long>
{
public static readonly long[] Value=A039769.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039769.Bytes);
public long this[int i]=>Value[i];

public static A039769Inst Instance=new A039769Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039768
{
public static readonly long[] Value={ 2L,3L,105L,133L,153L,185L,345L,377L,425L,585L,637L,665L,777L,805L,825L,873L,897L,905L,949L,1017L,1090L,1113L,1209L,1225L,1261L,1305L,1309L,1385L,1449L,1525L,1545L,1573L,1645L,1681L,1785L,1813L,1833L,1865L,1885L,1957L,1981L,2009L,2057L,2077L,2105L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039768Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039768.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039768Inst : IEnumerable<long>
{
public static readonly long[] Value=A039768.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039768.Bytes);
public long this[int i]=>Value[i];

public static A039768Inst Instance=new A039768Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039767
{
public static readonly long[] Value={ 4L,6L,8L,10L,12L,14L,15L,18L,20L,24L,26L,27L,30L,32L,35L,38L,39L,42L,44L,48L,50L,51L,54L,55L,60L,62L,63L,68L,72L,74L,75L,80L,81L,82L,84L,87L,90L,95L,98L,99L,102L,104L,108L,110L,114L,119L,122L,123L,126L,128L,132L,135L,138L,140L,143L,147L,150L,152L,158L,159L,164L,168L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039767Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039767.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039767Inst : IEnumerable<long>
{
public static readonly long[] Value=A039767.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039767.Bytes);
public long this[int i]=>Value[i];

public static A039767Inst Instance=new A039767Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039766
{
public static readonly long[] Value={ 1L,3L,21L,33L,57L,69L,77L,85L,93L,105L,125L,129L,141L,161L,175L,177L,201L,205L,209L,213L,221L,237L,249L,253L,309L,321L,329L,345L,365L,381L,393L,413L,417L,437L,445L,453L,473L,475L,485L,489L,493L,497L,501L,517L,533L,537L,565L,573L,581L,597L,629L,633L,649L,665L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039766Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039766.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039766Inst : IEnumerable<long>
{
public static readonly long[] Value=A039766.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039766.Bytes);
public long this[int i]=>Value[i];

public static A039766Inst Instance=new A039766Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039765
{
public static readonly long[] Value={ 0L,0L,4L,31L,240L,1931L,16396L,147589L,1408224L,14214559L,151394940L,1696783221L,19958826080L,245788962199L,3161635135340L,42390110260685L,591257152058944L,8563898444592927L,128598641049231996L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039765Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039765.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039765Inst : IEnumerable<long>
{
public static readonly long[] Value=A039765.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039765.Bytes);
public long this[int i]=>Value[i];

public static A039765Inst Instance=new A039765Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039764
{
public static readonly long[] Value={ 1L,1L,4L,15L,72L,403L,2546L,17867L,137528L,1149079L,10335766L,99425087L,1017259964L,11018905667L,125860969266L,1510764243699L,18999827156304L,249687992188015L,3420706820299374L,48751337014396167L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039764Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039764.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039764Inst : IEnumerable<long>
{
public static readonly long[] Value=A039764.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039764.Bytes);
public long this[int i]=>Value[i];

public static A039764Inst Instance=new A039764Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039763
{
public static readonly long[] Value={ 1L,1L,0L,1L,-2L,1L,1L,-6L,11L,-6L,1L,-12L,50L,-84L,45L,1L,-20L,150L,-520L,809L,-420L,1L,-30L,355L,-2100L,6439L,-9390L,4725L,1L,-42L,721L,-6510L,33019L,-92358L,127539L,-62370L,1L,-56L,1316L,-16856L,127694L,-578984L,1505524L,-1984584L,945945L,1L,-72L,2220L,-38304L,405174L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039763Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039763.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039763Inst : IEnumerable<long>
{
public static readonly long[] Value=A039763.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039763.Bytes);
public long this[int i]=>Value[i];

public static A039763Inst Instance=new A039763Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039762
{
public static readonly long[] Value={ 1L,0L,1L,1L,-2L,1L,-6L,11L,-6L,1L,45L,-84L,50L,-12L,1L,-420L,809L,-520L,150L,-20L,1L,4725L,-9390L,6439L,-2100L,355L,-30L,1L,-62370L,127539L,-92358L,33019L,-6510L,721L,-42L,1L,945945L,-1984584L,1505524L,-578984L,127694L,-16856L,1316L,-56L,1L,-16216200L,34812945L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039762Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039762.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039762Inst : IEnumerable<long>
{
public static readonly long[] Value=A039762.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039762.Bytes);
public long this[int i]=>Value[i];

public static A039762Inst Instance=new A039762Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039761
{
public static readonly long[] Value={ 1L,1L,0L,1L,2L,1L,1L,6L,7L,1L,1L,12L,34L,24L,1L,1L,20L,110L,190L,81L,1L,1L,30L,275L,920L,1051L,268L,1L,1L,42L,581L,3255L,7371L,5747L,869L,1L,1L,56L,1092L,9296L,35686L,57568L,31060L,2768L,1L,1L,72L,1884L,22764L,134022L,373926L,441652L,166068L,8689L,1L,1L,90L,3045L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039761Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039761.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039761Inst : IEnumerable<long>
{
public static readonly long[] Value=A039761.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039761.Bytes);
public long this[int i]=>Value[i];

public static A039761Inst Instance=new A039761Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039760
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,1L,1L,7L,6L,1L,1L,24L,34L,12L,1L,1L,81L,190L,110L,20L,1L,1L,268L,1051L,920L,275L,30L,1L,1L,869L,5747L,7371L,3255L,581L,42L,1L,1L,2768L,31060L,57568L,35686L,9296L,1092L,56L,1L,1L,8689L,166068L,441652L,373926L,134022L,22764L,1884L,72L,1L,1L,26964L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039760Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039760.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039760Inst : IEnumerable<long>
{
public static readonly long[] Value=A039760.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039760.Bytes);
public long this[int i]=>Value[i];

public static A039760Inst Instance=new A039760Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039759
{
public static readonly BigInteger[] Value={ 0L,1L,8L,58L,432L,3396L,28384L,252456L,2385280L,23874448L,252380800L,2809461920L,32841595136L,402105388608L,5144478074368L,68625615724160L,952603633463296L,13735016459768064L,205358227932235776L,3179027634604907008L,BigInteger.Parse("50881656554805620736"),BigInteger.Parse("840901491722391454720"),BigInteger.Parse("14332437167995507302400") };
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
public class A039759Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039759.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039759Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A039759.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A039759.Bytes);
public BigInteger this[int i]=>Value[i];

public static A039759Inst Instance=new A039759Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039758
{
public static readonly long[] Value={ 1L,1L,-1L,1L,-4L,3L,1L,-9L,23L,-15L,1L,-16L,86L,-176L,105L,1L,-25L,230L,-950L,1689L,-945L,1L,-36L,505L,-3480L,12139L,-19524L,10395L,1L,-49L,973L,-10045L,57379L,-177331L,264207L,-135135L,1L,-64L,1708L,-24640L,208054L,-1038016L,2924172L,-4098240L,2027025L,1L,-81L,2796L,-53676L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039758Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039758.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039758Inst : IEnumerable<long>
{
public static readonly long[] Value=A039758.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039758.Bytes);
public long this[int i]=>Value[i];

public static A039758Inst Instance=new A039758Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039757
{
public static readonly long[] Value={ 1L,-1L,1L,3L,-4L,1L,-15L,23L,-9L,1L,105L,-176L,86L,-16L,1L,-945L,1689L,-950L,230L,-25L,1L,10395L,-19524L,12139L,-3480L,505L,-36L,1L,-135135L,264207L,-177331L,57379L,-10045L,973L,-49L,1L,2027025L,-4098240L,2924172L,-1038016L,208054L,-24640L,1708L,-64L,1L,-34459425L,71697105L,-53809164L,20570444L,-4574934L,626934L,-53676L,2796L,-81L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039757Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039757.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039757Inst : IEnumerable<long>
{
public static readonly long[] Value=A039757.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039757.Bytes);
public long this[int i]=>Value[i];

public static A039757Inst Instance=new A039757Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039708
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,4L,5L,6L,6L,7L,8L,8L,9L,9L,10L,11L,11L,12L,12L,13L,14L,14L,15L,15L,16L,17L,17L,18L,18L,19L,19L,20L,21L,21L,22L,22L,23L,23L,24L,25L,25L,26L,26L,27L,27L,28L,29L,29L,30L,30L,31L,31L,32L,32L,33L,34L,34L,35L,35L,36L,36L,37L,37L,38L,39L,39L,40L,40L,41L,41L,42L,42L,43L,44L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039708Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039708.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039708Inst : IEnumerable<long>
{
public static readonly long[] Value=A039708.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039708.Bytes);
public long this[int i]=>Value[i];

public static A039708Inst Instance=new A039708Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039707
{
public static readonly long[] Value={ 1L,2L,4L,11L,33L,142L,822L,6910L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039707Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039707.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039707Inst : IEnumerable<long>
{
public static readonly long[] Value=A039707.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039707.Bytes);
public long this[int i]=>Value[i];

public static A039707Inst Instance=new A039707Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039706
{
public static readonly long[] Value={ 2L,3L,5L,7L,3L,5L,1L,3L,7L,5L,7L,5L,1L,3L,7L,5L,3L,5L,3L,7L,1L,7L,3L,1L,1L,5L,7L,3L,5L,1L,7L,3L,1L,3L,5L,7L,5L,3L,7L,5L,3L,5L,7L,1L,5L,7L,3L,7L,3L,5L,1L,7L,1L,3L,1L,7L,5L,7L,5L,1L,3L,5L,3L,7L,1L,5L,3L,1L,3L,5L,1L,7L,7L,5L,3L,7L,5L,5L,1L,1L,3L,5L,7L,1L,7L,3L,1L,1L,5L,7L,3L,7L,7L,3L,3L,7L,5L,1L,3L,5L,3L,5L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039706Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039706.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039706Inst : IEnumerable<long>
{
public static readonly long[] Value=A039706.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039706.Bytes);
public long this[int i]=>Value[i];

public static A039706Inst Instance=new A039706Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039705
{
public static readonly long[] Value={ 2L,3L,5L,0L,4L,6L,3L,5L,2L,1L,3L,2L,6L,1L,5L,4L,3L,5L,4L,1L,3L,2L,6L,5L,6L,3L,5L,2L,4L,1L,1L,5L,4L,6L,2L,4L,3L,2L,6L,5L,4L,6L,2L,4L,1L,3L,1L,6L,3L,5L,2L,1L,3L,6L,5L,4L,3L,5L,4L,1L,3L,6L,6L,3L,5L,2L,2L,1L,4L,6L,3L,2L,3L,2L,1L,5L,4L,5L,2L,3L,6L,1L,4L,6L,5L,2L,1L,2L,6L,1L,5L,3L,4L,1L,2L,6L,5L,3L,5L,2L,1L,4L,3L,2L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039705Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039705.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039705Inst : IEnumerable<long>
{
public static readonly long[] Value=A039705.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039705.Bytes);
public long this[int i]=>Value[i];

public static A039705Inst Instance=new A039705Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039704
{
public static readonly long[] Value={ 2L,3L,5L,1L,5L,1L,5L,1L,5L,5L,1L,1L,5L,1L,5L,5L,5L,1L,1L,5L,1L,1L,5L,5L,1L,5L,1L,5L,1L,5L,1L,5L,5L,1L,5L,1L,1L,1L,5L,5L,5L,1L,5L,1L,5L,1L,1L,1L,5L,1L,5L,5L,1L,5L,5L,5L,5L,1L,1L,5L,1L,5L,1L,5L,1L,5L,1L,1L,5L,1L,5L,5L,1L,1L,1L,5L,5L,1L,5L,1L,5L,1L,5L,1L,1L,5L,5L,1L,5L,1L,5L,5L,1L,5L,1L,5L,5L,5L,1L,1L,1L,5L,5L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039704Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039704.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039704Inst : IEnumerable<long>
{
public static readonly long[] Value=A039704.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039704.Bytes);
public long this[int i]=>Value[i];

public static A039704Inst Instance=new A039704Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039703
{
public static readonly long[] Value={ 2L,3L,0L,2L,1L,3L,2L,4L,3L,4L,1L,2L,1L,3L,2L,3L,4L,1L,2L,1L,3L,4L,3L,4L,2L,1L,3L,2L,4L,3L,2L,1L,2L,4L,4L,1L,2L,3L,2L,3L,4L,1L,1L,3L,2L,4L,1L,3L,2L,4L,3L,4L,1L,1L,2L,3L,4L,1L,2L,1L,3L,3L,2L,1L,3L,2L,1L,2L,2L,4L,3L,4L,2L,3L,4L,3L,4L,2L,1L,4L,4L,1L,1L,3L,4L,3L,4L,2L,1L,3L,2L,4L,2L,1L,4L,3L,4L,1L,3L,1L,2L,2L,3L,4L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039703Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039703.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039703Inst : IEnumerable<long>
{
public static readonly long[] Value=A039703.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039703.Bytes);
public long this[int i]=>Value[i];

public static A039703Inst Instance=new A039703Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039702
{
public static readonly long[] Value={ 2L,3L,1L,3L,3L,1L,1L,3L,3L,1L,3L,1L,1L,3L,3L,1L,3L,1L,3L,3L,1L,3L,3L,1L,1L,1L,3L,3L,1L,1L,3L,3L,1L,3L,1L,3L,1L,3L,3L,1L,3L,1L,3L,1L,1L,3L,3L,3L,3L,1L,1L,3L,1L,3L,1L,3L,1L,3L,1L,1L,3L,1L,3L,3L,1L,1L,3L,1L,3L,1L,1L,3L,3L,1L,3L,3L,1L,1L,1L,1L,3L,1L,3L,1L,3L,3L,1L,1L,1L,3L,3L,3L,3L,3L,3L,3L,1L,1L,3L,1L,3L,1L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039702Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039702.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039702Inst : IEnumerable<long>
{
public static readonly long[] Value=A039702.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039702.Bytes);
public long this[int i]=>Value[i];

public static A039702Inst Instance=new A039702Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039701
{
public static readonly long[] Value={ 2L,0L,2L,1L,2L,1L,2L,1L,2L,2L,1L,1L,2L,1L,2L,2L,2L,1L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,1L,2L,1L,2L,2L,1L,2L,1L,1L,1L,2L,2L,2L,1L,2L,1L,2L,1L,1L,1L,2L,1L,2L,2L,1L,2L,2L,2L,2L,1L,1L,2L,1L,2L,1L,2L,1L,2L,1L,1L,2L,1L,2L,2L,1L,1L,1L,2L,2L,1L,2L,1L,2L,1L,2L,1L,1L,2L,2L,1L,2L,1L,2L,2L,1L,2L,1L,2L,2L,2L,1L,1L,1L,2L,2L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039701Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039701.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039701Inst : IEnumerable<long>
{
public static readonly long[] Value=A039701.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039701.Bytes);
public long this[int i]=>Value[i];

public static A039701Inst Instance=new A039701Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039700
{
public static readonly long[] Value={ 1L,3L,18L,36L,45L,63L,72L,99L,117L,144L,153L,171L,207L,225L,261L,270L,279L,288L,333L,369L,378L,387L,423L,441L,477L,531L,540L,549L,576L,594L,603L,639L,657L,702L,711L,747L,756L,801L,873L,909L,918L,927L,945L,963L,981L,1017L,1026L,1080L,1089L,1125L,1143L,1152L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039700Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039700.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039700Inst : IEnumerable<long>
{
public static readonly long[] Value=A039700.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039700.Bytes);
public long this[int i]=>Value[i];

public static A039700Inst Instance=new A039700Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039699
{
public static readonly BigInteger[] Value={ 1L,8L,168L,5120L,190120L,7939008L,357713664L,16993726464L,839358285480L,42714450658880L,2225741588095168L,118227198981126144L,6380762273973278464L,BigInteger.Parse("349019710593278412800"),BigInteger.Parse("19310744204362333900800") };
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
public class A039699Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039699.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039699Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A039699.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A039699.Bytes);
public BigInteger this[int i]=>Value[i];

public static A039699Inst Instance=new A039699Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039698
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,17L,18L,19L,21L,22L,23L,26L,27L,28L,29L,31L,32L,34L,36L,37L,38L,40L,41L,42L,43L,46L,47L,48L,49L,53L,54L,55L,57L,58L,59L,60L,61L,62L,63L,67L,71L,73L,74L,75L,76L,77L,79L,82L,83L,86L,88L,89L,91L,93L,94L,95L,97L,98L,99L,100L,101L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039698Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039698.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039698Inst : IEnumerable<long>
{
public static readonly long[] Value=A039698.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039698.Bytes);
public long this[int i]=>Value[i];

public static A039698Inst Instance=new A039698Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039697
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,10L,7L,6L,6L,14L,11L,15L,13L,18L,16L,8L,17L,15L,19L,21L,20L,26L,23L,20L,10L,30L,9L,27L,29L,30L,31L,10L,28L,38L,24L,20L,37L,42L,32L,28L,41L,36L,43L,39L,24L,50L,47L,25L,14L,21L,40L,45L,53L,20L,32L,36L,44L,62L,59L,40L,61L,66L,30L,12L,36L,48L,67L,57L,52L,42L,71L,25L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039697Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039697.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039697Inst : IEnumerable<long>
{
public static readonly long[] Value=A039697.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039697.Bytes);
public long this[int i]=>Value[i];

public static A039697Inst Instance=new A039697Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039696
{
public static readonly long[] Value={ 2L,3L,4L,4L,6L,7L,8L,5L,5L,11L,12L,8L,14L,15L,16L,6L,18L,8L,20L,12L,22L,23L,24L,9L,7L,27L,6L,16L,30L,31L,32L,7L,34L,35L,36L,10L,38L,39L,40L,13L,42L,43L,44L,24L,17L,47L,48L,10L,9L,12L,52L,28L,54L,9L,56L,17L,58L,59L,60L,32L,62L,63L,23L,8L,66L,67L,68L,36L,70L,71L,72L,12L,74L,75L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039696Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039696.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039696Inst : IEnumerable<long>
{
public static readonly long[] Value=A039696.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039696.Bytes);
public long this[int i]=>Value[i];

public static A039696Inst Instance=new A039696Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039695
{
public static readonly long[] Value={ 3L,6L,12L,24L,39L,51L,57L,60L,75L,87L,102L,105L,123L,132L,150L,165L,174L,186L,201L,237L,249L,255L,267L,276L,282L,309L,330L,345L,381L,393L,426L,444L,462L,480L,492L,519L,528L,546L,570L,618L,633L,660L,771L,780L,795L,804L,816L,876L,885L,903L,948L,966L,984L,1005L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039695Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039695.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039695Inst : IEnumerable<long>
{
public static readonly long[] Value=A039695.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039695.Bytes);
public long this[int i]=>Value[i];

public static A039695Inst Instance=new A039695Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039694
{
public static readonly long[] Value={ 4L,7L,13L,25L,40L,52L,58L,61L,76L,88L,103L,106L,124L,133L,151L,166L,175L,187L,202L,238L,250L,256L,268L,277L,283L,310L,331L,346L,382L,394L,427L,445L,463L,481L,493L,520L,529L,547L,571L,619L,634L,661L,772L,781L,796L,805L,817L,877L,886L,904L,949L,967L,985L,1006L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039694Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039694.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039694Inst : IEnumerable<long>
{
public static readonly long[] Value=A039694.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039694.Bytes);
public long this[int i]=>Value[i];

public static A039694Inst Instance=new A039694Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039693
{
public static readonly long[] Value={ 2L,5L,11L,23L,38L,50L,56L,59L,74L,86L,101L,104L,122L,131L,149L,164L,173L,185L,200L,236L,248L,254L,266L,275L,281L,308L,329L,344L,380L,392L,425L,443L,461L,479L,491L,518L,527L,545L,569L,617L,632L,659L,770L,779L,794L,803L,815L,875L,884L,902L,947L,965L,983L,1004L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039693Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039693.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039693Inst : IEnumerable<long>
{
public static readonly long[] Value=A039693.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039693.Bytes);
public long this[int i]=>Value[i];

public static A039693Inst Instance=new A039693Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039692
{
public static readonly long[] Value={ 1L,3L,1L,8L,9L,1L,42L,59L,18L,1L,264L,450L,215L,30L,1L,2160L,4114L,2475L,565L,45L,1L,20880L,43512L,30814L,9345L,1225L,63L,1L,236880L,528492L,420756L,154609L,27720L,2338L,84L,1L,3064320L,7235568L,6316316L,2673972L,594489L,69552L,4074L,108L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039692Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039692.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039692Inst : IEnumerable<long>
{
public static readonly long[] Value=A039692.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039692.Bytes);
public long this[int i]=>Value[i];

public static A039692Inst Instance=new A039692Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039691
{
public static readonly long[] Value={ 0L,1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,20L,21L,22L,23L,24L,25L,26L,27L,30L,31L,32L,33L,34L,35L,36L,40L,41L,42L,43L,44L,45L,50L,51L,52L,53L,54L,60L,61L,62L,63L,70L,71L,72L,80L,81L,90L,100L,101L,102L,103L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039691Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039691.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039691Inst : IEnumerable<long>
{
public static readonly long[] Value=A039691.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039691.Bytes);
public long this[int i]=>Value[i];

public static A039691Inst Instance=new A039691Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039690
{
public static readonly long[] Value={ 1L,2L,5L,10L,20L,25L,50L,100L,125L,200L,250L,500L,1000L,1250L,2000L,2500L,5000L,10000L,12500L,20000L,25000L,50000L,100000L,125000L,200000L,250000L,500000L,1000000L,1250000L,2000000L,2500000L,5000000L,10000000L,12500000L,20000000L,25000000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039690Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039690.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039690Inst : IEnumerable<long>
{
public static readonly long[] Value=A039690.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039690.Bytes);
public long this[int i]=>Value[i];

public static A039690Inst Instance=new A039690Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039689
{
public static readonly long[] Value={ 15L,16L,20L,24L,25L,30L,33L,35L,39L,44L,45L,50L,51L,52L,56L,64L,65L,66L,68L,69L,70L,72L,78L,80L,81L,84L,85L,87L,90L,92L,96L,102L,104L,105L,112L,116L,120L,121L,123L,128L,129L,130L,136L,138L,140L,141L,143L,144L,147L,155L,156L,159L,160L,161L,162L,164L,165L,168L,170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039689Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039689.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039689Inst : IEnumerable<long>
{
public static readonly long[] Value=A039689.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039689.Bytes);
public long this[int i]=>Value[i];

public static A039689Inst Instance=new A039689Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039688
{
public static readonly long[] Value={ 120L,672L,523776L,459818240L,1476304896L,31001180160L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039688Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039688.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039688Inst : IEnumerable<long>
{
public static readonly long[] Value=A039688.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039688.Bytes);
public long this[int i]=>Value[i];

public static A039688Inst Instance=new A039688Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039687
{
public static readonly BigInteger[] Value={ 7L,13L,97L,193L,769L,12289L,786433L,3221225473L,206158430209L,6597069766657L,BigInteger.Parse("221360928884514619393"),BigInteger.Parse("2353913150770005286438421033702874906038383291674012942337") };
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
public class A039687Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039687.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039687Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A039687.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A039687.Bytes);
public BigInteger this[int i]=>Value[i];

public static A039687Inst Instance=new A039687Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039686
{
public static readonly long[] Value={ 49L,169L,361L,1225L,1444L,1681L,3249L,4225L,4900L,15625L,16900L,36100L,42025L,49729L,64009L,81225L,93025L,122500L,144400L,168100L,225625L,237169L,324900L,422500L,490000L,519841L,819025L,950625L,970225L,1024144L,1442401L,1562500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039686Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039686.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039686Inst : IEnumerable<long>
{
public static readonly long[] Value=A039686.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039686.Bytes);
public long this[int i]=>Value[i];

public static A039686Inst Instance=new A039686Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039685
{
public static readonly long[] Value={ 38L,462L,538L,962L,1038L,1462L,1538L,1962L,2038L,2462L,2538L,2962L,3038L,3462L,3538L,3962L,4038L,4462L,4538L,4962L,5038L,5462L,5538L,5962L,6038L,6462L,6538L,6962L,7038L,7462L,7538L,7962L,8038L,8462L,8538L,8962L,9038L,9462L,9538L,9962L,10038L,10462L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039685Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039685.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039685Inst : IEnumerable<long>
{
public static readonly long[] Value=A039685.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039685.Bytes);
public long this[int i]=>Value[i];

public static A039685Inst Instance=new A039685Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039684
{
public static readonly long[] Value={ 1089L,10989L,109989L,1099989L,10999989L,109999989L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039684Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039684.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039684Inst : IEnumerable<long>
{
public static readonly long[] Value=A039684.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039684.Bytes);
public long this[int i]=>Value[i];

public static A039684Inst Instance=new A039684Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039683
{
public static readonly long[] Value={ 1L,-2L,1L,8L,-6L,1L,-48L,44L,-12L,1L,384L,-400L,140L,-20L,1L,-3840L,4384L,-1800L,340L,-30L,1L,46080L,-56448L,25984L,-5880L,700L,-42L,1L,-645120L,836352L,-420224L,108304L,-15680L,1288L,-56L,1L,10321920L,-14026752L,7559936L,-2153088L,359184L,-36288L,2184L,-72L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039683Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039683.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039683Inst : IEnumerable<long>
{
public static readonly long[] Value=A039683.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039683.Bytes);
public long this[int i]=>Value[i];

public static A039683Inst Instance=new A039683Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039682
{
public static readonly long[] Value={ 2L,4L,10L,16L,20L,28L,32L,38L,40L,50L,52L,56L,58L,68L,74L,76L,82L,86L,88L,104L,106L,118L,122L,124L,130L,136L,154L,158L,164L,166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039682Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039682.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039682Inst : IEnumerable<long>
{
public static readonly long[] Value=A039682.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039682.Bytes);
public long this[int i]=>Value[i];

public static A039682Inst Instance=new A039682Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039681
{
public static readonly long[] Value={ 1L,5L,7L,11L,13L,19L,23L,25L,29L,37L,41L,49L,59L,61L,65L,77L,83L,91L,97L,101L,103L,115L,121L,131L,133L,137L,149L,151L,155L,163L,173L,175L,181L,185L,187L,205L,211L,223L,227L,235L,247L,253L,275L,277L,281L,283L,295L,299L,319L,325L,329L,331L,347L,353L,367L,379L,389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039681Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039681.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039681Inst : IEnumerable<long>
{
public static readonly long[] Value=A039681.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039681.Bytes);
public long this[int i]=>Value[i];

public static A039681Inst Instance=new A039681Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039680
{
public static readonly BigInteger[] Value={ 1L,12L,124L,1245L,12457L,1245710L,124571011L,12457101113L,1245710111316L,124571011131619L,12457101113161920L,1245710111316192023L,BigInteger.Parse("124571011131619202325") };
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
public class A039680Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039680.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039680Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A039680.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A039680.Bytes);
public BigInteger this[int i]=>Value[i];

public static A039680Inst Instance=new A039680Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039679
{
public static readonly long[] Value={ 2L,5L,7L,11L,101L,131L,151L,181L,353L,757L,787L,919L,929L,10501L,12721L,14341L,16661L,17471L,17971L,18181L,18481L,19991L,30803L,31513L,32323L,35053L,36263L,36563L,38083L,38783L,70207L,70507L,70607L,71317L,71917L,74747L,76667L,79997L,93739L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039679Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039679.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039679Inst : IEnumerable<long>
{
public static readonly long[] Value=A039679.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039679.Bytes);
public long this[int i]=>Value[i];

public static A039679Inst Instance=new A039679Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039678
{
public static readonly long[] Value={ 5L,8L,7L,18L,3L,19L,38L,28L,28L,14L,115L,18L,51L,19L,53L,338L,53L,264L,143L,11L,306L,31L,99L,184L,53L,181L,43L,164L,96L,68L,38L,58L,19L,328L,313L,78L,226L,65L,253L,259L,532L,78L,176L,276L,143L,174L,165L,69L,330L,44L,33L,332L,94L,263L,48L,79L,171L,747L,731L,20L,147L,91L,40L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039678Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039678.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039678Inst : IEnumerable<long>
{
public static readonly long[] Value=A039678.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039678.Bytes);
public long this[int i]=>Value[i];

public static A039678Inst Instance=new A039678Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039677
{
public static readonly long[] Value={ 1L,3L,7L,12L,19L,29L,40L,53L,69L,88L,108L,131L,156L,184L,213L,245L,282L,320L,360L,401L,450L,500L,552L,608L,666L,725L,786L,851L,919L,993L,1069L,1146L,1228L,1311L,1397L,1485L,1576L,1673L,1774L,1877L,1981L,2087L,2202L,2320L,2441L,2563L,2687L,2817L,2948L,3081L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039677Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039677.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039677Inst : IEnumerable<long>
{
public static readonly long[] Value=A039677.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039677.Bytes);
public long this[int i]=>Value[i];

public static A039677Inst Instance=new A039677Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039660
{
public static readonly long[] Value={ 0L,0L,0L,1L,2L,8L,14L,43L,72L,204L,336L,926L,1516L,4144L,6772L,18504L,30236L,82844L,135452L,372581L,609710L,1684220L,2758730L,7652531L,12546332L,34941752L,57337172L,160280987L,263224802L,738363872L,1213502942L,3414804517L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039660Inst : IEnumerable<long>
{
public static readonly long[] Value=A039660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039660.Bytes);
public long this[int i]=>Value[i];

public static A039660Inst Instance=new A039660Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039659
{
public static readonly long[] Value={ 0L,1L,5L,21L,50L,355L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039659Inst : IEnumerable<long>
{
public static readonly long[] Value=A039659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039659.Bytes);
public long this[int i]=>Value[i];

public static A039659Inst Instance=new A039659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A039658
{
public static readonly long[] Value={ 0L,1L,2L,5L,8L,18L,28L,64L,100L,237L,374L,917L,1460L,3679L,5898L,15183L,24468L,64055L,103642L,275011L,446380L,1197616L,1948852L,5277070L,8605288L,23483743L,38362198L,105392983L,172423768L,476459938L,780496108L,2167743688L,3554991268L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A039658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A039658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A039658Inst : IEnumerable<long>
{
public static readonly long[] Value=A039658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A039658.Bytes);
public long this[int i]=>Value[i];

public static A039658Inst Instance=new A039658Inst();

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