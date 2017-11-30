using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A013673
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,3L,0L,5L,8L,8L,2L,3L,6L,3L,0L,7L,0L,2L,0L,4L,9L,3L,5L,5L,1L,7L,2L,8L,5L,1L,0L,6L,4L,5L,0L,6L,2L,5L,8L,7L,6L,2L,7L,9L,4L,8L,7L,0L,6L,8L,5L,8L,1L,7L,7L,5L,0L,6L,5L,6L,9L,9L,3L,2L,8L,9L,3L,3L,3L,2L,2L,6L,7L,1L,5L,6L,3L,4L,2L,2L,7L,9L,5L,7L,3L,0L,7L,2L,3L,3L,4L,3L,4L,7L,0L,1L,7L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013673Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013673.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013673Inst : IEnumerable<long>
{
public static readonly long[] Value=A013673.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013673.Bytes);
public long this[int i]=>Value[i];

public static A013673Inst Instance=new A013673Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013672
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,6L,1L,2L,4L,8L,1L,3L,5L,0L,5L,8L,7L,0L,4L,8L,2L,9L,2L,5L,8L,5L,4L,5L,1L,0L,5L,1L,3L,5L,3L,3L,3L,7L,4L,7L,4L,8L,1L,6L,9L,6L,1L,6L,9L,1L,5L,4L,5L,4L,9L,4L,8L,2L,7L,5L,5L,2L,0L,2L,2L,5L,2L,8L,6L,2L,9L,4L,1L,0L,2L,3L,1L,7L,7L,4L,2L,0L,8L,7L,6L,6L,5L,9L,7L,8L,2L,9L,7L,1L,9L,9L,8L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013672Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013672.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013672Inst : IEnumerable<long>
{
public static readonly long[] Value=A013672.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013672.Bytes);
public long this[int i]=>Value[i];

public static A013672Inst Instance=new A013672Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013671
{
public static readonly long[] Value={ 1L,0L,0L,0L,1L,2L,2L,7L,1L,3L,3L,4L,7L,5L,7L,8L,4L,8L,9L,1L,4L,6L,7L,5L,1L,8L,3L,6L,5L,2L,6L,3L,5L,7L,3L,9L,5L,7L,1L,4L,2L,7L,5L,1L,0L,5L,8L,9L,5L,5L,0L,9L,8L,4L,5L,1L,3L,6L,7L,0L,2L,6L,7L,1L,6L,2L,0L,8L,9L,6L,7L,2L,6L,8L,2L,9L,8L,4L,4L,2L,0L,9L,8L,1L,2L,8L,9L,2L,7L,1L,3L,9L,5L,3L,2L,6L,8L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013671Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013671.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013671Inst : IEnumerable<long>
{
public static readonly long[] Value=A013671.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013671.Bytes);
public long this[int i]=>Value[i];

public static A013671Inst Instance=new A013671Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013670
{
public static readonly long[] Value={ 1L,0L,0L,0L,2L,4L,6L,0L,8L,6L,5L,5L,3L,3L,0L,8L,0L,4L,8L,2L,9L,8L,6L,3L,7L,9L,9L,8L,0L,4L,7L,7L,3L,9L,6L,7L,0L,9L,6L,0L,4L,1L,6L,0L,8L,8L,4L,5L,8L,0L,0L,3L,4L,0L,4L,5L,3L,3L,0L,4L,0L,9L,5L,2L,1L,3L,3L,2L,5L,2L,0L,1L,9L,6L,8L,1L,9L,4L,0L,9L,1L,3L,0L,4L,9L,0L,4L,2L,8L,0L,8L,5L,5L,1L,9L,0L,0L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013670Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013670.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013670Inst : IEnumerable<long>
{
public static readonly long[] Value=A013670.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013670.Bytes);
public long this[int i]=>Value[i];

public static A013670Inst Instance=new A013670Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013669
{
public static readonly long[] Value={ 1L,0L,0L,0L,4L,9L,4L,1L,8L,8L,6L,0L,4L,1L,1L,9L,4L,6L,4L,5L,5L,8L,7L,0L,2L,2L,8L,2L,5L,2L,6L,4L,6L,9L,9L,3L,6L,4L,6L,8L,6L,0L,6L,4L,3L,5L,7L,5L,8L,2L,0L,8L,6L,1L,7L,1L,1L,9L,1L,4L,1L,4L,3L,6L,1L,0L,0L,0L,5L,4L,0L,5L,9L,7L,9L,8L,2L,1L,9L,8L,1L,4L,7L,0L,2L,5L,9L,1L,8L,4L,3L,0L,2L,3L,5L,6L,0L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013669Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013669.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013669Inst : IEnumerable<long>
{
public static readonly long[] Value=A013669.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013669.Bytes);
public long this[int i]=>Value[i];

public static A013669Inst Instance=new A013669Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013668
{
public static readonly long[] Value={ 1L,0L,0L,0L,9L,9L,4L,5L,7L,5L,1L,2L,7L,8L,1L,8L,0L,8L,5L,3L,3L,7L,1L,4L,5L,9L,5L,8L,9L,0L,0L,3L,1L,9L,0L,1L,7L,0L,0L,6L,0L,1L,9L,5L,3L,1L,5L,6L,4L,4L,7L,7L,5L,1L,7L,2L,5L,7L,7L,8L,8L,9L,9L,4L,6L,3L,6L,2L,9L,1L,4L,6L,5L,1L,5L,1L,9L,1L,2L,9L,5L,4L,3L,9L,7L,0L,4L,1L,9L,6L,8L,6L,1L,0L,3L,8L,5L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013668Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013668.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013668Inst : IEnumerable<long>
{
public static readonly long[] Value=A013668.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013668.Bytes);
public long this[int i]=>Value[i];

public static A013668Inst Instance=new A013668Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013667
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,0L,8L,3L,9L,2L,8L,2L,6L,0L,8L,2L,2L,1L,4L,4L,1L,7L,8L,5L,2L,7L,6L,9L,2L,3L,2L,4L,1L,2L,0L,6L,0L,4L,8L,5L,6L,0L,5L,8L,5L,1L,3L,9L,4L,8L,8L,8L,7L,5L,6L,5L,4L,8L,5L,9L,6L,6L,1L,5L,9L,0L,9L,7L,8L,5L,0L,5L,3L,3L,9L,0L,2L,5L,8L,3L,9L,8L,9L,5L,0L,3L,9L,3L,0L,6L,9L,1L,2L,7L,1L,6L,9L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013667Inst : IEnumerable<long>
{
public static readonly long[] Value=A013667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013667.Bytes);
public long this[int i]=>Value[i];

public static A013667Inst Instance=new A013667Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013666
{
public static readonly long[] Value={ 1L,0L,0L,4L,0L,7L,7L,3L,5L,6L,1L,9L,7L,9L,4L,4L,3L,3L,9L,3L,7L,8L,6L,8L,5L,2L,3L,8L,5L,0L,8L,6L,5L,2L,4L,6L,5L,2L,5L,8L,9L,6L,0L,7L,9L,0L,6L,4L,9L,8L,5L,0L,0L,2L,0L,3L,2L,9L,1L,1L,0L,2L,0L,2L,6L,5L,2L,5L,8L,2L,9L,5L,2L,5L,7L,4L,7L,4L,8L,8L,1L,4L,3L,9L,5L,2L,8L,7L,2L,3L,0L,3L,7L,2L,3L,7L,1L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013666Inst : IEnumerable<long>
{
public static readonly long[] Value=A013666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013666.Bytes);
public long this[int i]=>Value[i];

public static A013666Inst Instance=new A013666Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013665
{
public static readonly long[] Value={ 1L,0L,0L,8L,3L,4L,9L,2L,7L,7L,3L,8L,1L,9L,2L,2L,8L,2L,6L,8L,3L,9L,7L,9L,7L,5L,4L,9L,8L,4L,9L,7L,9L,6L,7L,5L,9L,5L,9L,9L,8L,6L,3L,5L,6L,0L,5L,6L,5L,2L,3L,8L,7L,0L,6L,4L,1L,7L,2L,8L,3L,1L,3L,6L,5L,7L,1L,6L,0L,1L,4L,7L,8L,3L,1L,7L,3L,5L,5L,7L,3L,5L,3L,4L,6L,0L,9L,6L,9L,6L,8L,9L,1L,3L,8L,5L,1L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013665Inst : IEnumerable<long>
{
public static readonly long[] Value=A013665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013665.Bytes);
public long this[int i]=>Value[i];

public static A013665Inst Instance=new A013665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013664
{
public static readonly long[] Value={ 1L,0L,1L,7L,3L,4L,3L,0L,6L,1L,9L,8L,4L,4L,4L,9L,1L,3L,9L,7L,1L,4L,5L,1L,7L,9L,2L,9L,7L,9L,0L,9L,2L,0L,5L,2L,7L,9L,0L,1L,8L,1L,7L,4L,9L,0L,0L,3L,2L,8L,5L,3L,5L,6L,1L,8L,4L,2L,4L,0L,8L,6L,6L,4L,0L,0L,4L,3L,3L,2L,1L,8L,2L,9L,0L,1L,9L,5L,7L,8L,9L,7L,8L,8L,2L,7L,7L,3L,9L,7L,7L,9L,3L,8L,5L,3L,5L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013664Inst : IEnumerable<long>
{
public static readonly long[] Value=A013664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013664.Bytes);
public long this[int i]=>Value[i];

public static A013664Inst Instance=new A013664Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013663
{
public static readonly long[] Value={ 1L,0L,3L,6L,9L,2L,7L,7L,5L,5L,1L,4L,3L,3L,6L,9L,9L,2L,6L,3L,3L,1L,3L,6L,5L,4L,8L,6L,4L,5L,7L,0L,3L,4L,1L,6L,8L,0L,5L,7L,0L,8L,0L,9L,1L,9L,5L,0L,1L,9L,1L,2L,8L,1L,1L,9L,7L,4L,1L,9L,2L,6L,7L,7L,9L,0L,3L,8L,0L,3L,5L,8L,9L,7L,8L,6L,2L,8L,1L,4L,8L,4L,5L,6L,0L,0L,4L,3L,1L,0L,6L,5L,5L,7L,1L,3L,3L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013663Inst : IEnumerable<long>
{
public static readonly long[] Value=A013663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013663.Bytes);
public long this[int i]=>Value[i];

public static A013663Inst Instance=new A013663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013662
{
public static readonly long[] Value={ 1L,0L,8L,2L,3L,2L,3L,2L,3L,3L,7L,1L,1L,1L,3L,8L,1L,9L,1L,5L,1L,6L,0L,0L,3L,6L,9L,6L,5L,4L,1L,1L,6L,7L,9L,0L,2L,7L,7L,4L,7L,5L,0L,9L,5L,1L,9L,1L,8L,7L,2L,6L,9L,0L,7L,6L,8L,2L,9L,7L,6L,2L,1L,5L,4L,4L,4L,1L,2L,0L,6L,1L,6L,1L,8L,6L,9L,6L,8L,8L,4L,6L,5L,5L,6L,9L,0L,9L,6L,3L,5L,9L,4L,1L,6L,9L,9L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013662Inst : IEnumerable<long>
{
public static readonly long[] Value=A013662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013662.Bytes);
public long this[int i]=>Value[i];

public static A013662Inst Instance=new A013662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013549
{
public static readonly long[] Value={ 1L,2L,4L,10L,41L,76L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013549Inst : IEnumerable<long>
{
public static readonly long[] Value=A013549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013549.Bytes);
public long this[int i]=>Value[i];

public static A013549Inst Instance=new A013549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013548
{
public static readonly BigInteger[] Value={ 1L,-1L,221L,-244939L,1846213L,-526960582373L,23968139993843L,-5189795464140757L,BigInteger.Parse("36594801159269740631"),BigInteger.Parse("-16691319229288614334663751"),BigInteger.Parse("11409300606349966887237659743"),BigInteger.Parse("-198510162914463324156683262269") };
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
public class A013548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013548Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013548.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013548.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013548Inst Instance=new A013548Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013547
{
public static readonly BigInteger[] Value={ 1L,1L,-211L,169339L,-205787L,124654123973L,4233334384067L,458968419865477L,460700758945363763L,BigInteger.Parse("1003433160159825045756551"),BigInteger.Parse("1160527066076017343605453327"),BigInteger.Parse("537107192671326620106145350461"),BigInteger.Parse("11100661279966114788004381836713"),BigInteger.Parse("90437772951214017777023420366691881") };
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
public class A013547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013547Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013547.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013547.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013547Inst Instance=new A013547Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013546
{
public static readonly BigInteger[] Value={ 1L,1L,-215L,199159L,-4128623L,257347648013L,-111384981593L,1407269115959761L,69849267671401979L,BigInteger.Parse("467410556088873329284747"),BigInteger.Parse("429563383515510620615310131"),BigInteger.Parse("652256640736921402479041889329"),BigInteger.Parse("137438707390027290209533044701"),BigInteger.Parse("432938003151091640246284451153923"),BigInteger.Parse("5720446637387424876679468922735017734533") };
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
public class A013546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013546Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013546.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013546.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013546Inst Instance=new A013546Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013545
{
public static readonly BigInteger[] Value={ -1L,13L,29L,397L,74927L,2570951L,495301L,2978520989L,879781928617L,1962442468445621L,4485273725677799419L,17810142018975186977UL };
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
public class A013545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013545Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013545.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013545.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013545Inst Instance=new A013545Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013544
{
public static readonly BigInteger[] Value={ -1L,7L,-1013L,64763L,-3009173L,5341411709L,-857007547621L,28828641126011L,-1030088087041163819L,BigInteger.Parse("108508429719458111069"),BigInteger.Parse("-2005462402042629244533103"),BigInteger.Parse("41348510060126079043949299"),BigInteger.Parse("-132583025047910486114666220223") };
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
public class A013544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013544Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013544.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013544.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013544Inst Instance=new A013544Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013543
{
public static readonly BigInteger[] Value={ -1L,55L,-95L,18167L,-22118287L,51054985L,-10169116451L,211416785949641L,-36975734097804001L,BigInteger.Parse("764839113579826244863"),BigInteger.Parse("-45988950723178614316250507"),BigInteger.Parse("61286790868827586032169553"),BigInteger.Parse("-25771544562210083470157315437") };
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
public class A013543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013543Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013543.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013543.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013543Inst Instance=new A013543Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013542
{
public static readonly BigInteger[] Value={ -1L,53L,3341L,391337L,710371933L,6178130243L,225570264096917L,1546226961439379L,BigInteger.Parse("5665951032145572087083"),BigInteger.Parse("-1602619428542796266047"),BigInteger.Parse("218332153959703843484481031721"),BigInteger.Parse("-149315097238822774731841867") };
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
public class A013542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013542Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013542.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013542.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013542Inst Instance=new A013542Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013541
{
public static readonly BigInteger[] Value={ 1L,-1L,217L,-214279L,824071L,-337533513773L,8320611986431L,-2303253020856673L,7111553692366818727L,BigInteger.Parse("-4825610634542923917792887"),BigInteger.Parse("6031202702741413913839327"),BigInteger.Parse("-1707209475196496091030335944673") };
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
public class A013541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013541Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013541.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013541.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013541Inst Instance=new A013541Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013540
{
public static readonly BigInteger[] Value={ -1L,7L,-17L,913L,-93959L,9405719L,-8909477L,211410621413L,-6740064210937L,2805742760628347L,-761503407533329723L,BigInteger.Parse("340317674208644677253"),BigInteger.Parse("-38791272133810800467"),BigInteger.Parse("1468818906393936912860264741") };
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
public class A013540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013540Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013540.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013540.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013540Inst Instance=new A013540Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013539
{
public static readonly BigInteger[] Value={ -1L,13L,877L,2675L,8260913L,410433607L,223758294041L,27276568423051L,127639993821278611L,10512596641186789291UL,BigInteger.Parse("8302408982767874894797"),BigInteger.Parse("3077103479886222660379217") };
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
public class A013539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013539Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013539.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013539.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013539Inst Instance=new A013539Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013538
{
public static readonly BigInteger[] Value={ -1L,53L,73L,45137L,11226497L,129163393L,474807665L,198247921612319L,618559606844489L,BigInteger.Parse("395129918156594369761"),BigInteger.Parse("2883495145728730085501149"),BigInteger.Parse("704455206007099333581073"),BigInteger.Parse("4366595916673463219275798447"),BigInteger.Parse("10742815369857597784418536545975463") };
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
public class A013538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013538Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013538.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013538.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013538Inst Instance=new A013538Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013537
{
public static readonly BigInteger[] Value={ -1L,55L,-4219L,802171L,-109684277L,760100160121L,-265779449377027L,417652078505070229L,BigInteger.Parse("-7396136516120375032117"),BigInteger.Parse("1432995839205684739321951"),BigInteger.Parse("-63523043223346003438419401363"),BigInteger.Parse("2351819493900615585072181702093") };
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
public class A013537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013537Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013537.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013537.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013537Inst Instance=new A013537Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013536
{
public static readonly BigInteger[] Value={ 1L,-1L,1L,53L,-215L,3341L,199159L,391337L,-4128623L,710371933L,257347648013L,6178130243L,-111384981593L,225570264096917L,1407269115959761L,1546226961439379L,69849267671401979L,BigInteger.Parse("5665951032145572087083"),BigInteger.Parse("467410556088873329284747"),BigInteger.Parse("-1602619428542796266047"),BigInteger.Parse("429563383515510620615310131"),BigInteger.Parse("218332153959703843484481031721") };
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
public class A013536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013536Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013536.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013536.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013536Inst Instance=new A013536Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013535
{
public static readonly BigInteger[] Value={ 1L,1L,5L,5449L,6973L,518819753L,1489058191L,293416964947L,2531578641757L,8778884852410565513L,BigInteger.Parse("2503198198587351877067"),BigInteger.Parse("2378459715706347981795671"),BigInteger.Parse("2343990771779851025499037"),BigInteger.Parse("521048260968673067986908628597"),BigInteger.Parse("35145358095152621756454620279473") };
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
public class A013535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013535Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013535.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013535.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013535Inst Instance=new A013535Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013534
{
public static readonly BigInteger[] Value={ 1L,-1L,1L,-5029L,6697L,-375719873L,186044689L,-1770350411L,102625697881591L,BigInteger.Parse("-15912188224095499151"),BigInteger.Parse("1419184560088744177499"),BigInteger.Parse("-323645955378411578735051"),BigInteger.Parse("935339682040604214800761"),BigInteger.Parse("-36813244507954712597112169117"),BigInteger.Parse("45816041290074218754101655557981") };
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
public class A013534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013534Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013534.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013534.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013534Inst Instance=new A013534Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013533
{
public static readonly BigInteger[] Value={ 1L,-1L,67L,-319L,172747L,-5036627L,12689179L,-142848518639L,9522619510673L,-15014600586761717L,BigInteger.Parse("98523462918652219853"),BigInteger.Parse("-281638034717631160979"),BigInteger.Parse("20971906033995645898061"),BigInteger.Parse("-1307646596002305911998781633") };
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
public class A013533Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013533.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013533Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013533.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013533.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013533Inst Instance=new A013533Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013532
{
public static readonly BigInteger[] Value={ 1L,1L,949L,2647L,6091583L,309884803L,24257706533L,19423358539261L,264554745901944637L,217615549372227323L,BigInteger.Parse("1019034322058704876807657"),BigInteger.Parse("1439067424977073452007609"),BigInteger.Parse("742090435456946501950120739"),BigInteger.Parse("92447561714992144826576923831967") };
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
public class A013532Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013532.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013532Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013532.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013532.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013532Inst Instance=new A013532Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013531
{
public static readonly BigInteger[] Value={ 1L,1L,5L,19L,13793L,7487L,235549L,4400752781L,1455564577L,75143281206379L,17910727755514921L,208450205999558953L,8864292850179951461L,BigInteger.Parse("36884532202496983982602507") };
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
public class A013531Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013531.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013531Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013531.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013531.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013531Inst Instance=new A013531Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013530
{
public static readonly BigInteger[] Value={ 1L,-1L,211L,-157L,439801L,-8013839L,890107609L,-1552280998637L,76919615326361L,-25930051873454543L,BigInteger.Parse("659157886816533334709"),BigInteger.Parse("-1513017447627551117359"),BigInteger.Parse("6612344442139455641066609"),BigInteger.Parse("-112537977176478238359834596179") };
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
public class A013530Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013530.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013530Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013530.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013530.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013530Inst Instance=new A013530Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013529
{
public static readonly BigInteger[] Value={ 1L,1L,1L,1L,1L,211L,5029L,157L,6697L,439801L,375719873L,8013839L,186044689L,890107609L,1770350411L,1552280998637L,102625697881591L,76919615326361L,15912188224095499151UL,25930051873454543L,BigInteger.Parse("1419184560088744177499"),BigInteger.Parse("659157886816533334709"),BigInteger.Parse("323645955378411578735051"),BigInteger.Parse("1513017447627551117359"),BigInteger.Parse("935339682040604214800761"),BigInteger.Parse("6612344442139455641066609"),BigInteger.Parse("36813244507954712597112169117"),BigInteger.Parse("112537977176478238359834596179"),BigInteger.Parse("45816041290074218754101655557981") };
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
public class A013529Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013529.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013529Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013529.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013529.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013529Inst Instance=new A013529Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013528
{
public static readonly BigInteger[] Value={ 1L,-1L,-1L,1L,19L,25031L,18421L,-622177L,-283401163L,-24826632949L,-2243454779L,4882905709651L,43798187793808543L,BigInteger.Parse("-46704901267812186793"),BigInteger.Parse("-5325187532598955153807") };
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
public class A013528Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013528.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013528Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013528.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013528.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013528Inst Instance=new A013528Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013527
{
public static readonly BigInteger[] Value={ 1L,1L,13L,397L,4453L,24649L,12478897L,47378857957L,11289999097969L,1143069714638779L,1293273763150662781L,15203530875840895739UL,BigInteger.Parse("46398798213229213203983"),BigInteger.Parse("209490216975221386279672393"),BigInteger.Parse("157153880464155360205476452597") };
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
public class A013527Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013527.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013527Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013527.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013527.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013527Inst Instance=new A013527Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013526
{
public static readonly BigInteger[] Value={ 1L,1L,3L,59L,871L,325249L,35797L,24362249L,342232522657L,8224154352439L,23157229065769L,9926476934520521L,BigInteger.Parse("37638416003805990839"),BigInteger.Parse("296699416391356495667713"),BigInteger.Parse("691054566545631371393") };
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
public class A013526Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013526.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013526Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013526.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013526.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013526Inst Instance=new A013526Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013525
{
public static readonly BigInteger[] Value={ 1L,0L,2L,30L,692L,25260L,1351382L,99680490L,9695756072L,1202439837720L,185185594118762L,34674437196568950L,7757267081778543452L,BigInteger.Parse("2043536254646561946180"),BigInteger.Parse("626129820701814932734142"),BigInteger.Parse("220771946624511552276841410") };
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
public class A013525Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013525.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013525Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013525.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013525.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013525Inst Instance=new A013525Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013524
{
public static readonly BigInteger[] Value={ 1L,0L,-1L,-1L,-1L,13L,7951L,21599L,-294997L,-275833L,-60527057L,-6338125867L,37620769159L,10425684579701L,5113538085001361L,-25594556368763237L,-6013201989263028181L,BigInteger.Parse("-3771502911169983097219"),BigInteger.Parse("18335649295377317231411"),BigInteger.Parse("669255665793644548301365603") };
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
public class A013524Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013524.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013524Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013524.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013524.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013524Inst Instance=new A013524Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013523
{
public static readonly BigInteger[] Value={ 2L,48L,768L,645120L,37158912L,81749606400L,784796221440L,42849873690624000L,548478383239987200L,BigInteger.Parse("63777066403145711616000"),BigInteger.Parse("4285818862291391820595200"),BigInteger.Parse("216862434431944426122117120000"),BigInteger.Parse("8007228348256409579893555200000"),BigInteger.Parse("1461479318123759876522171695104000000") };
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
public class A013523Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013523.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013523Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013523.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013523.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013523Inst Instance=new A013523Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013522
{
public static readonly BigInteger[] Value={ 1L,1L,37L,137L,41641L,3887L,241586893L,5721418891L,4315903789009L,2832484672207L,183184249105857781L,2154299222076719401L,BigInteger.Parse("1431144441595717024523"),BigInteger.Parse("386845480523042818420133") };
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
public class A013522Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013522.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013522Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013522.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013522.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013522Inst Instance=new A013522Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013521
{
public static readonly BigInteger[] Value={ 1L,-1L,-7L,-97L,-2063L,-17803L,-250781L,166831871L,43685848289L,447550424579L,84677077231169L,11657476758734011L,BigInteger.Parse("28924058075775365981"),BigInteger.Parse("44287070229737735633567"),BigInteger.Parse("305190813989360271816409") };
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
public class A013521Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013521.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013521Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013521.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013521.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013521Inst Instance=new A013521Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013520
{
public static readonly BigInteger[] Value={ 0L,2L,9L,100L,1237L,18896L,337663L,6941194L,161357425L,4186540456L,119942830785L,3761004532550L,128121728853479L,4711881688294652L,186065500280409423L,7852240169544076190L,BigInteger.Parse("352684377274345906213"),BigInteger.Parse("16798134072300013751064") };
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
public class A013520Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013520.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013520Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013520.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013520.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013520Inst Instance=new A013520Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013519
{
public static readonly BigInteger[] Value={ 1L,1L,3L,181L,59L,3455L,3332389L,173339393L,449509681L,198232237033L,1032475444411L,101635950910031L,71432133543444211L,BigInteger.Parse("671713726985602398481") };
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
public class A013519Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013519.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013519Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013519.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013519.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013519Inst Instance=new A013519Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013518
{
public static readonly BigInteger[] Value={ 1L,1L,3L,83L,8887L,57539L,2419601L,298733192941L,84896691713L,54207578317691L,535009143553922969L,BigInteger.Parse("303988210353762448529"),BigInteger.Parse("39439620915967757710853"),BigInteger.Parse("18146112662693896499335287481") };
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
public class A013518Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013518.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013518Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013518.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013518.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013518Inst Instance=new A013518Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013469
{
public static readonly BigInteger[] Value={ 1L,-2L,12L,-122L,1792L,-35282L,889152L,-27747722L,1045556992L,-46640267042L,2424156352512L,-144890071612442L,9849171061952512L,-754330752297972722L,BigInteger.Parse("64566114865428283392") };
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
public class A013469Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013469.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013469Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013469.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013469.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013469Inst Instance=new A013469Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013468
{
public static readonly long[] Value={ 1L,-1L,-1L,4L,5L,-32L,-55L,390L,961L,-6432L,-22463L,134550L,649761L,-3443208L,-22456551L,105379838L,911433121L,-3787776224L,-42942180863L,157078439014L,2324211078513L,-7384507525560L,-143088139308519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013468Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013468.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013468Inst : IEnumerable<long>
{
public static readonly long[] Value=A013468.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013468.Bytes);
public long this[int i]=>Value[i];

public static A013468Inst Instance=new A013468Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013467
{
public static readonly long[] Value={ 1L,4L,7L,53L,215L,1895L,12122L,132205L,1144627L,14912291L,164213696L,2477432371L,33228911417L,569758644845L,9014907260096L,173288317530505L,3159048447572983L,67337939660404735L,1389152842003647000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013467Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013467.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013467Inst : IEnumerable<long>
{
public static readonly long[] Value=A013467.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013467.Bytes);
public long this[int i]=>Value[i];

public static A013467Inst Instance=new A013467Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013466
{
public static readonly BigInteger[] Value={ 1L,0L,0L,160L,0L,691200L,19712000L,14125363200L,1476034560000L,949310881792000L,219556882022400000L,BigInteger.Parse("161772486589808640000"),BigInteger.Parse("65109683806263050240000"),BigInteger.Parse("58457850571785240576000000") };
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
public class A013466Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013466.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013466Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013466.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013466.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013466Inst Instance=new A013466Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013465
{
public static readonly BigInteger[] Value={ 1L,0L,0L,-160L,0L,-691200L,3942400L,-14125363200L,295206912000L,-902471385088000L,43911376404480000L,BigInteger.Parse("-140627264197754880000"),BigInteger.Parse("12856220870209699840000"),BigInteger.Parse("-45500991975079280640000000") };
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
public class A013465Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013465.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013465Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013465.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013465.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013465Inst Instance=new A013465Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013464
{
public static readonly BigInteger[] Value={ 0L,-4L,0L,-1440L,35840L,-7257600L,790732800L,-208797388800L,48099557376000L,-19670079356928000L,7390762646372352000L,BigInteger.Parse("-4427057815048028160000"),BigInteger.Parse("2474680614543006105600000"),BigInteger.Parse("-2020995311309719496294400000") };
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
public class A013464Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013464.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013464Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013464.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013464.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013464Inst Instance=new A013464Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013463
{
public static readonly BigInteger[] Value={ 0L,-4L,0L,-1440L,17920L,-7257600L,395366400L,-175791616000L,24049778688000L,-13090802909184000L,3482386518507520000L,BigInteger.Parse("-2338795470534082560000"),BigInteger.Parse("1043344639170183168000000"),BigInteger.Parse("-855872901958901432320000000") };
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
public class A013463Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013463.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013463Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013463.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013463.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013463Inst Instance=new A013463Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013462
{
public static readonly long[] Value={ 1L,0L,0L,-4L,0L,0L,160L,-1440L,0L,-17920L,691200L,-7257600L,3942400L,-395366400L,14125363200L,-175791616000L,295206912000L,-24049778688000L,902471385088000L,-13090802909184000L,43911376404480000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013462Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013462.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013462Inst : IEnumerable<long>
{
public static readonly long[] Value=A013462.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013462.Bytes);
public long this[int i]=>Value[i];

public static A013462Inst Instance=new A013462Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013461
{
public static readonly long[] Value={ 1L,0L,0L,-1L,0L,15L,10L,-495L,-840L,29015L,87750L,-2666475L,-12310100L,354343275L,2287605450L,-64350661375L,-549013374000L,15319760415375L,166031512396750L,-4630895520073875L,-61922192590147500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013461Inst : IEnumerable<long>
{
public static readonly long[] Value=A013461.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013461.Bytes);
public long this[int i]=>Value[i];

public static A013461Inst Instance=new A013461Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013460
{
public static readonly long[] Value={ 1L,0L,0L,-3L,0L,23L,90L,-721L,-3864L,32759L,326214L,-2672461L,-38496876L,310461227L,6363118762L,-49895013169L,-1391451773264L,10516703525327L,390207547318222L,-2811203923750741L,-136581823796686036L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013460Inst : IEnumerable<long>
{
public static readonly long[] Value=A013460.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013460.Bytes);
public long this[int i]=>Value[i];

public static A013460Inst Instance=new A013460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013459
{
public static readonly long[] Value={ 1L,0L,1L,-4L,9L,-40L,385L,-2700L,15505L,-145360L,1886625L,-19796500L,190881625L,-2654379000L,44269902625L,-625468889500L,8553276590625L,-156119043652000L,3194978818578625L,-57041478987070500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013459Inst : IEnumerable<long>
{
public static readonly long[] Value=A013459.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013459.Bytes);
public long this[int i]=>Value[i];

public static A013459Inst Instance=new A013459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013458
{
public static readonly BigInteger[] Value={ 1L,0L,0L,0L,0L,-8064L,-2838528L,-863070208L,-280413765632L,-103486230003712L,-44246647746887680L,BigInteger.Parse("-22012763373859241984"),BigInteger.Parse("-12714213783118211448832"),BigInteger.Parse("-8481868824110022304727040"),BigInteger.Parse("-6494340221977598984831631360") };
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
public class A013458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013458Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013458.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013458.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013458Inst Instance=new A013458Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013457
{
public static readonly BigInteger[] Value={ 8L,448L,32384L,3275008L,456633344L,85209957376L,20642665299968L,6317122591227904L,2385636036677599232L,BigInteger.Parse("1090226048919008706560"),BigInteger.Parse("593123978260373222981632"),BigInteger.Parse("378879965375277796067115008") };
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
public class A013457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013457Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013457.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013457.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013457Inst Instance=new A013457Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013456
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,-8L,0L,-448L,0L,-32384L,8064L,-3275008L,2838528L,-456633344L,863070208L,-85339110400L,280413765632L,-20783183790080L,103486230003712L,-6429447050002432L,44250652523855872L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013456Inst : IEnumerable<long>
{
public static readonly long[] Value=A013456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013456.Bytes);
public long this[int i]=>Value[i];

public static A013456Inst Instance=new A013456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013455
{
public static readonly BigInteger[] Value={ 1L,0L,0L,160L,0L,261120L,19712000L,1538068480L,557613056000L,72297758064640L,26395258519552000L,9009548633571328000L,BigInteger.Parse("3030117499561574400000"),BigInteger.Parse("1720760994441294994472960"),BigInteger.Parse("838542041341593366036480000") };
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
public class A013455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013455Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013455.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013455.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013455Inst Instance=new A013455Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013454
{
public static readonly BigInteger[] Value={ 1L,0L,0L,-160L,0L,-261120L,3942400L,-1538068480L,111522611200L,-25458261360640L,5279051703910400L,-1021353507684352000L,BigInteger.Parse("440307608869404672000"),BigInteger.Parse("-89935097031558126632960") };
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
public class A013454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013454Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013454.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013454.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013454Inst Instance=new A013454Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013453
{
public static readonly BigInteger[] Value={ 0L,4L,0L,544L,35840L,707584L,298721280L,26768052224L,5564833464320L,1787224334270464L,379247341296680960L,BigInteger.Parse("181364573942845538304"),BigInteger.Parse("71776324876296729395200"),BigInteger.Parse("35085662010847230106271744") };
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
public class A013453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013453Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013453.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013453.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013453Inst Instance=new A013453Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013452
{
public static readonly BigInteger[] Value={ 4L,0L,544L,-17920L,707584L,-149360640L,5242548224L,-2782416732160L,166243180478464L,-109528131284500480L,13239205658628194304UL,BigInteger.Parse("-8328889253838297497600"),BigInteger.Parse("1938205426199431158431744") };
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
public class A013452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013452Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013452.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013452.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013452Inst Instance=new A013452Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013451
{
public static readonly long[] Value={ 1L,0L,0L,4L,0L,0L,160L,544L,0L,17920L,261120L,707584L,3942400L,149360640L,1538068480L,5242548224L,111522611200L,2782416732160L,25458261360640L,166243180478464L,5279051703910400L,109528131284500480L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013451Inst : IEnumerable<long>
{
public static readonly long[] Value=A013451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013451.Bytes);
public long this[int i]=>Value[i];

public static A013451Inst Instance=new A013451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013450
{
public static readonly long[] Value={ 1L,0L,0L,3L,0L,7L,90L,497L,1176L,4471L,185094L,1537877L,1964028L,-3633797L,1848048202L,22918664225L,-75962374768L,-1620122697905L,67890529994062L,1135357942624877L,-11941170933349628L,-252473078493886301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013450Inst : IEnumerable<long>
{
public static readonly long[] Value=A013450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013450.Bytes);
public long this[int i]=>Value[i];

public static A013450Inst Instance=new A013450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013449
{
public static readonly long[] Value={ 1L,0L,0L,1L,0L,15L,10L,271L,840L,8215L,60870L,423091L,4980580L,35126715L,501501130L,4192844111L,63445348720L,652228720015L,10063325322190L,125163350892331L,1976669210391260L,28804173376146115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013449Inst : IEnumerable<long>
{
public static readonly long[] Value=A013449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013449.Bytes);
public long this[int i]=>Value[i];

public static A013449Inst Instance=new A013449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013448
{
public static readonly BigInteger[] Value={ 1L,0L,0L,-160L,1792L,-484224L,54495232L,-9441003520L,2598020579328L,-756380393635840L,305071008569196544L,BigInteger.Parse("-144297159065656885248"),BigInteger.Parse("81729693136918543335424"),BigInteger.Parse("-55094722790449057575731200") };
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
public class A013448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013448Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013448.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013448.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013448Inst Instance=new A013448Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013447
{
public static readonly BigInteger[] Value={ 1L,0L,0L,160L,-1792L,484224L,-15071232L,6570936320L,-461050544128L,285431558799360L,-41198126773469184L,BigInteger.Parse("31834693166688370688"),BigInteger.Parse("-8575650915562515595264"),BigInteger.Parse("7808988993818084822220800") };
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
public class A013447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013447Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013447.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013447.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013447Inst Instance=new A013447Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013446
{
public static readonly BigInteger[] Value={ 1L,0L,0L,160L,-1792L,484224L,-30840832L,7718963200L,-1315838558208L,426971596029952L,-136067874243248128L,BigInteger.Parse("61019499461102272512"),BigInteger.Parse("-30246038986591439945728"),BigInteger.Parse("18590454932996390870056960") };
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
public class A013446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013446Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013446.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013446.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013446Inst Instance=new A013446Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013445
{
public static readonly BigInteger[] Value={ 4L,-8L,992L,-68224L,5165312L,-1019810816L,186916489216L,-51926843359232L,18052796043493376L,-7489482677372846080L,BigInteger.Parse("3888725315407646818304"),BigInteger.Parse("-2359682003031000489132032"),BigInteger.Parse("1689998575261701932163530752") };
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
public class A013445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013445Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013445.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013445.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013445Inst Instance=new A013445Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013444
{
public static readonly BigInteger[] Value={ 1L,0L,0L,-160L,1792L,-484224L,38725632L,-8292976640L,1743232565248L,-521161362997248L,188842450602393600L,BigInteger.Parse("-83511992640895975424"),BigInteger.Parse("44545415648776825077760"),BigInteger.Parse("-27875257165637958804439040") };
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
public class A013444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013444Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013444.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013444.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013444Inst Instance=new A013444Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013443
{
public static readonly BigInteger[] Value={ 4L,-8L,992L,3456L,2799872L,106544128L,37168683008L,4255728041984L,1543239875821568L,355403465489907712L,BigInteger.Parse("155864209273777553408"),BigInteger.Parse("58585654628727325196288"),BigInteger.Parse("32351390426329866422976512") };
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
public class A013443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013443Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013443.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013443.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013443Inst Instance=new A013443Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013442
{
public static readonly BigInteger[] Value={ 4L,-8L,992L,-14464L,3391232L,-175044608L,64560399360L,-8423762821120L,4197760943882240L,-1054662864854450176L,BigInteger.Parse("677817013904397697024"),BigInteger.Parse("-277456857021505605206016"),BigInteger.Parse("226696976060712490528407552") };
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
public class A013442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013442Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013442.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013442.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013442Inst Instance=new A013442Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013441
{
public static readonly BigInteger[] Value={ 4L,-8L,992L,-50304L,4573952L,-738222080L,127954033664L,-34953731964928L,10769261343309824L,-4380269574963986432L,BigInteger.Parse("2085941501322197073920"),BigInteger.Parse("-1202553346613607891730432"),BigInteger.Parse("808239805736578791916961792") };
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
public class A013441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013441Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013441.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013441.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013441Inst Instance=new A013441Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013440
{
public static readonly long[] Value={ 1L,0L,0L,4L,0L,-8L,160L,992L,-1792L,-14464L,484224L,3391232L,-30840832L,-175044608L,7718963200L,53080130560L,-1315838558208L,-6862446264320L,426971596029952L,2514483259473920L,-136067874243248128L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013440Inst : IEnumerable<long>
{
public static readonly long[] Value=A013440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013440.Bytes);
public long this[int i]=>Value[i];

public static A013440Inst Instance=new A013440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013439
{
public static readonly long[] Value={ 1L,0L,1L,0L,9L,-8L,225L,-616L,11025L,-57584L,901089L,-7218288L,111426777L,-1206961208L,19455493057L,-263225301400L,4553837345057L,-73099331076960L,1373357039852353L,-25286525625615712L,517610171023053737L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013439Inst : IEnumerable<long>
{
public static readonly long[] Value=A013439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013439.Bytes);
public long this[int i]=>Value[i];

public static A013439Inst Instance=new A013439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013438
{
public static readonly BigInteger[] Value={ 1L,0L,0L,-10L,-840L,-87750L,-12248500L,-2253971850L,-533589966000L,-158691603820750L,-58067784952807500L,BigInteger.Parse("-25679245305449531250"),BigInteger.Parse("-13515821293834796365000"),BigInteger.Parse("-8355912675896675805093750") };
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
public class A013438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013438Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013438.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013438.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013438Inst Instance=new A013438Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013437
{
public static readonly BigInteger[] Value={ 1L,0L,0L,10L,840L,87750L,12402500L,2338055850L,572148486000L,177069963820750L,67752690483757500L,BigInteger.Parse("31441329951467231250"),BigInteger.Parse("17409362545770168545000"),BigInteger.Parse("11342985795968641587093750"),BigInteger.Parse("8592815549188913685325312500") };
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
public class A013437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013437Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013437.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013437.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013437Inst Instance=new A013437Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013436
{
public static readonly BigInteger[] Value={ 1L,0L,0L,10L,840L,87750L,12340900L,2304422250L,556725078000L,169707184396750L,63859173696337500L,BigInteger.Parse("29112458631692231250"),BigInteger.Parse("15824678904821697625000"),BigInteger.Parse("10117021949736621549093750"),BigInteger.Parse("7518098018091686976236812500") };
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
public class A013436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013436Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013436.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013436.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013436Inst Instance=new A013436Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013435
{
public static readonly BigInteger[] Value={ 0L,15L,495L,29015L,2666475L,354343275L,64361872575L,15331195839375L,4639834754377875L,1739923436670397875L,BigInteger.Parse("792214640482949058375"),BigInteger.Parse("430673843640390204684375"),BigInteger.Parse("275621285783640234105646875"),BigInteger.Parse("205164378528197702536594546875"),BigInteger.Parse("175791115887829825909515376359375") };
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
public class A013435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013435Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013435.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013435.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013435Inst Instance=new A013435Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013434
{
public static readonly BigInteger[] Value={ 1L,0L,0L,-10L,-840L,-87750L,-12310100L,-2287605450L,-549013374000L,-166031512396750L,-61922192590147500L,BigInteger.Parse("-27960041702488691250"),BigInteger.Parse("-15045975711682274645000"),BigInteger.Parse("-9519627048988069071093750") };
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
public class A013434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013434Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013434.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013434.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013434Inst Instance=new A013434Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013433
{
public static readonly BigInteger[] Value={ 0L,1L,15L,495L,28735L,2597175L,337740975L,59815330575L,13857008709375L,4071452200086375L,1480690661198331375L,BigInteger.Parse("653488912610356197375"),BigInteger.Parse("344332933648569891309375"),BigInteger.Parse("213657034023415650312084375") };
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
public class A013433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013433Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013433.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013433.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013433Inst Instance=new A013433Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013432
{
public static readonly BigInteger[] Value={ 0L,1L,15L,495L,29855L,2874375L,404150175L,78074371375L,19828087485375L,6403087440228375L,2561659553274989375L,BigInteger.Parse("1243334307147747189375"),BigInteger.Parse("719656795107349242609375"),BigInteger.Parse("489659786386680109910734375") };
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
public class A013432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013432Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013432.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013432.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013432Inst Instance=new A013432Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013431
{
public static readonly BigInteger[] Value={ 0L,1L,15L,495L,29575L,2805075L,387547875L,73496998575L,18322452939375L,5810121991600875L,2283796491396190875L,BigInteger.Parse("1089828106992320070375"),BigInteger.Parse("620645663306405750934375"),BigInteger.Parse("415796249727049685923771875"),BigInteger.Parse("323721378608985101109612121875"),BigInteger.Parse("289840773808099328924207553609375") };
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
public class A013431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013431Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013431.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013431.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013431Inst Instance=new A013431Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013430
{
public static readonly long[] Value={ 1L,0L,0L,-1L,0L,-15L,10L,-495L,840L,-29575L,87750L,-2805075L,12340900L,-387547875L,2304422250L,-73485787375L,556725078000L,-18311017515375L,169707184396750L,-5801182757296875L,63859173696337500L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013430Inst : IEnumerable<long>
{
public static readonly long[] Value=A013430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013430.Bytes);
public long this[int i]=>Value[i];

public static A013430Inst Instance=new A013430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013429
{
public static readonly BigInteger[] Value={ 1L,0L,0L,-90L,1176L,-185094L,6953628L,-2271831562L,113771489552L,-90523142172238L,2740534463632996L,-9209167403962507058L,BigInteger.Parse("-464269042403340299048"),BigInteger.Parse("-2066044589238157561264950") };
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
public class A013429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013429Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013429.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013429.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013429Inst Instance=new A013429Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013428
{
public static readonly BigInteger[] Value={ 1L,0L,0L,90L,-1176L,185094L,5520372L,1212373162L,360563171248L,54782671966798L,28420007004983564L,9501613654091931218UL,BigInteger.Parse("4976784878396711868488"),BigInteger.Parse("2978748297366502676647350") };
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
public class A013428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013428Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013428.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013428.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013428Inst Instance=new A013428Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013427
{
public static readonly BigInteger[] Value={ 1L,0L,0L,90L,-1176L,185094L,530772L,1636156522L,170829306928L,60742435952974L,18173279227072940L,7353969776707569554L,BigInteger.Parse("3655980234829231451912"),BigInteger.Parse("2065776616635942000462390"),BigInteger.Parse("1427955074795894359873706436"),BigInteger.Parse("1109745897830641117410245879226") };
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
public class A013427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013427Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013427.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013427.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013427Inst Instance=new A013427Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013426
{
public static readonly BigInteger[] Value={ 3L,-7L,497L,-4471L,1537877L,3633797L,25642985825L,1187863670705L,1419759682006637L,193121697188029661L,BigInteger.Parse("200696541857404028889"),BigInteger.Parse("55695588453425762984841"),BigInteger.Parse("60791734371206895835586277") };
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
public class A013426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013426Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013426.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013426.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013426Inst Instance=new A013426Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013425
{
public static readonly BigInteger[] Value={ 1L,0L,0L,-90L,1176L,-185094L,1964028L,-1848048202L,-75962374768L,-67890529994062L,-11941170933349628L,-7295480526681684722L,BigInteger.Parse("-2786657669471759954024"),BigInteger.Parse("-1863106309893276602345910") };
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
public class A013425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013425Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013425.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013425.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013425Inst Instance=new A013425Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013424
{
public static readonly BigInteger[] Value={ 3L,-7L,497L,-12031L,1828937L,-78420175L,33163987313L,-1847431936639L,1836279812106137L,-90066800149588687L,BigInteger.Parse("250185010809212552449"),BigInteger.Parse("-1037398294518312251519"),BigInteger.Parse("71571989564012181483901417") };
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
public class A013424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013424Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013424.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013424.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013424Inst Instance=new A013424Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013423
{
public static readonly BigInteger[] Value={ 3L,-7L,497L,18209L,664697L,249795713L,20788071761L,7484066815937L,2018810597689577L,693966952243632545L,BigInteger.Parse("344692722450514980225"),BigInteger.Parse("170245123653326940700257"),BigInteger.Parse("112403414827841060460901977") };
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
public class A013423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013423Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013423.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013423.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013423Inst Instance=new A013423Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013422
{
public static readonly BigInteger[] Value={ 0L,3L,-7L,497L,10649L,955757L,167741741L,20817188849L,5637483533393L,1653225944489237L,560689820639903957L,BigInteger.Parse("269465649695982142009"),BigInteger.Parse("138258119776900090716601"),BigInteger.Parse("87774869737967098700912797"),BigInteger.Parse("65239835100565334768577561149"),BigInteger.Parse("54460490625029012562328972397057") };
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
public class A013422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013422Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013422.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013422.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013422Inst Instance=new A013422Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013421
{
public static readonly long[] Value={ 1L,0L,0L,3L,0L,-7L,90L,497L,-1176L,10649L,185094L,955757L,530772L,167741741L,1636156522L,18092867249L,170829306928L,6069742560593L,60742435952974L,1368824205107477L,18173279227072940L,584561380993184597L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013421Inst : IEnumerable<long>
{
public static readonly long[] Value=A013421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013421.Bytes);
public long this[int i]=>Value[i];

public static A013421Inst Instance=new A013421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013420
{
public static readonly BigInteger[] Value={ 1L,0L,0L,40L,0L,108000L,1232000L,1647734400L,57657600000L,85927162048000L,6053574009600000L,11452742596189440000UL,BigInteger.Parse("1349295190949488640000"),BigInteger.Parse("3261229190521061760000000"),BigInteger.Parse("577775664177165642240000000") };
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
public class A013420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013420Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013420.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013420.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013420Inst Instance=new A013420Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013419
{
public static readonly BigInteger[] Value={ 1L,0L,0L,-40L,0L,-108000L,246400L,-1647734400L,11531520000L,-85195294912000L,1210714801920000L,BigInteger.Parse("-11246246283767040000"),BigInteger.Parse("269211710490511360000"),BigInteger.Parse("-3174485131400558976000000"),BigInteger.Parse("114873496767979282944000000") };
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
public class A013419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013419Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013419.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013419.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013419Inst Instance=new A013419Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013418
{
public static readonly BigInteger[] Value={ 0L,2L,0L,450L,4480L,1786050L,61776000L,37240453250L,2713505184000L,2464296285701250L,308006231110240000L,BigInteger.Parse("397784819452992221250"),BigInteger.Parse("76036685958833418000000"),BigInteger.Parse("132964856302641623934781250") };
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
public class A013418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013418Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013418.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013418.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013418Inst Instance=new A013418Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013417
{
public static readonly BigInteger[] Value={ 2L,0L,450L,2240L,1786050L,30888000L,36926539650L,1356752592000L,2425187135621250L,154415644664112000L,BigInteger.Parse("389167059569139101250"),BigInteger.Parse("38253175174710405000000"),BigInteger.Parse("129492439672113021377981250") };
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
public class A013417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013417Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013417.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013417.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013417Inst Instance=new A013417Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013416
{
public static readonly long[] Value={ 1L,0L,0L,2L,0L,0L,40L,450L,0L,2240L,108000L,1786050L,246400L,30888000L,1647734400L,36567781250L,11531520000L,1356752592000L,85195294912000L,2380490964101250L,1210714801920000L,153377369153840000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A013416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013416Inst : IEnumerable<long>
{
public static readonly long[] Value=A013416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A013416.Bytes);
public long this[int i]=>Value[i];

public static A013416Inst Instance=new A013416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013415
{
public static readonly BigInteger[] Value={ 1L,0L,0L,-90L,2520L,-368550L,36798300L,-8485126650L,1746971226000L,-623950950372750L,216093789514102500L,BigInteger.Parse("-111905269600936061250"),BigInteger.Parse("58297381976449590975000"),BigInteger.Parse("-41488228251938936311593750") };
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
public class A013415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013415Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013415.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013415Inst Instance=new A013415Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A013414
{
public static readonly BigInteger[] Value={ 1L,0L,0L,90L,-2520L,368550L,-24324300L,6214858650L,-725350626000L,318282066852750L,-56464293738352500L,BigInteger.Parse("40214549353890161250"),BigInteger.Parse("-9894502805503110795000"),BigInteger.Parse("10823754426851479957593750") };
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
public class A013414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A013414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A013414Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A013414.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A013414.Bytes);
public BigInteger this[int i]=>Value[i];

public static A013414Inst Instance=new A013414Inst();

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