using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A021381
{
public static readonly long[] Value={ 0L,0L,2L,6L,5L,2L,5L,1L,9L,8L,9L,3L,8L,9L,9L,2L,0L,4L,2L,4L,4L,0L,3L,1L,8L,3L,0L,2L,3L,8L,7L,2L,6L,7L,9L,0L,4L,5L,0L,9L,2L,8L,3L,8L,1L,9L,6L,2L,8L,6L,4L,7L,2L,1L,4L,8L,5L,4L,1L,1L,1L,4L,0L,5L,8L,3L,5L,5L,4L,3L,7L,6L,6L,5L,7L,8L,2L,4L,9L,3L,3L,6L,8L,7L,0L,0L,2L,6L,5L,2L,5L,1L,9L,8L,9L,3L,8L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021381Inst : IEnumerable<long>
{
public static readonly long[] Value=A021381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021381.Bytes);
public long this[int i]=>Value[i];

public static A021381Inst Instance=new A021381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021382
{
public static readonly long[] Value={ 0L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L,6L,4L,5L,5L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021382Inst : IEnumerable<long>
{
public static readonly long[] Value=A021382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021382.Bytes);
public long this[int i]=>Value[i];

public static A021382Inst Instance=new A021382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021383
{
public static readonly long[] Value={ 0L,0L,2L,6L,3L,8L,5L,2L,2L,4L,2L,7L,4L,4L,0L,6L,3L,3L,2L,4L,5L,3L,8L,2L,5L,8L,5L,7L,5L,1L,9L,7L,8L,8L,9L,1L,8L,2L,0L,5L,8L,0L,4L,7L,4L,9L,3L,4L,0L,3L,6L,9L,3L,9L,3L,1L,3L,9L,8L,4L,1L,6L,8L,8L,6L,5L,4L,3L,5L,3L,5L,6L,2L,0L,0L,5L,2L,7L,7L,0L,4L,4L,8L,5L,4L,8L,8L,1L,2L,6L,6L,4L,9L,0L,7L,6L,5L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021383Inst : IEnumerable<long>
{
public static readonly long[] Value=A021383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021383.Bytes);
public long this[int i]=>Value[i];

public static A021383Inst Instance=new A021383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021384
{
public static readonly long[] Value={ 1L,18L,225L,2470L,25701L,261378L,2632345L,26400990L,264329901L,2644608538L,26451412065L,264535693110L,2645444018101L,26454790920498L,264549319337385L,2645498855426830L,26455011267050301L,264550203715341258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021384Inst : IEnumerable<long>
{
public static readonly long[] Value=A021384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021384.Bytes);
public long this[int i]=>Value[i];

public static A021384Inst Instance=new A021384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021385
{
public static readonly long[] Value={ 0L,0L,2L,6L,2L,4L,6L,7L,1L,9L,1L,6L,0L,1L,0L,4L,9L,8L,6L,8L,7L,6L,6L,4L,0L,4L,1L,9L,9L,4L,7L,5L,0L,6L,5L,6L,1L,6L,7L,9L,7L,9L,0L,0L,2L,6L,2L,4L,6L,7L,1L,9L,1L,6L,0L,1L,0L,4L,9L,8L,6L,8L,7L,6L,6L,4L,0L,4L,1L,9L,9L,4L,7L,5L,0L,6L,5L,6L,1L,6L,7L,9L,7L,9L,0L,0L,2L,6L,2L,4L,6L,7L,1L,9L,1L,6L,0L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021385Inst : IEnumerable<long>
{
public static readonly long[] Value=A021385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021385.Bytes);
public long this[int i]=>Value[i];

public static A021385Inst Instance=new A021385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021386
{
public static readonly long[] Value={ 0L,0L,2L,6L,1L,7L,8L,0L,1L,0L,4L,7L,1L,2L,0L,4L,1L,8L,8L,4L,8L,1L,6L,7L,5L,3L,9L,2L,6L,7L,0L,1L,5L,7L,0L,6L,8L,0L,6L,2L,8L,2L,7L,2L,2L,5L,1L,3L,0L,8L,9L,0L,0L,5L,2L,3L,5L,6L,0L,2L,0L,9L,4L,2L,4L,0L,8L,3L,7L,6L,9L,6L,3L,3L,5L,0L,7L,8L,5L,3L,4L,0L,3L,1L,4L,1L,3L,6L,1L,2L,5L,6L,5L,4L,4L,5L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021386Inst : IEnumerable<long>
{
public static readonly long[] Value=A021386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021386.Bytes);
public long this[int i]=>Value[i];

public static A021386Inst Instance=new A021386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021387
{
public static readonly long[] Value={ 0L,0L,2L,6L,1L,0L,9L,6L,6L,0L,5L,7L,4L,4L,1L,2L,5L,3L,2L,6L,3L,7L,0L,7L,5L,7L,1L,8L,0L,1L,5L,6L,6L,5L,7L,9L,6L,3L,4L,4L,6L,4L,7L,5L,1L,9L,5L,8L,2L,2L,4L,5L,4L,3L,0L,8L,0L,9L,3L,9L,9L,4L,7L,7L,8L,0L,6L,7L,8L,8L,5L,1L,1L,7L,4L,9L,3L,4L,7L,2L,5L,8L,4L,8L,5L,6L,3L,9L,6L,8L,6L,6L,8L,4L,0L,7L,3L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021387Inst : IEnumerable<long>
{
public static readonly long[] Value=A021387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021387.Bytes);
public long this[int i]=>Value[i];

public static A021387Inst Instance=new A021387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021388
{
public static readonly long[] Value={ 0L,0L,2L,6L,0L,4L,1L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021388Inst : IEnumerable<long>
{
public static readonly long[] Value=A021388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021388.Bytes);
public long this[int i]=>Value[i];

public static A021388Inst Instance=new A021388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021389
{
public static readonly long[] Value={ 0L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L,5L,9L,7L,4L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021389Inst : IEnumerable<long>
{
public static readonly long[] Value=A021389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021389.Bytes);
public long this[int i]=>Value[i];

public static A021389Inst Instance=new A021389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021406
{
public static readonly long[] Value={ 0L,0L,2L,4L,8L,7L,5L,6L,2L,1L,8L,9L,0L,5L,4L,7L,2L,6L,3L,6L,8L,1L,5L,9L,2L,0L,3L,9L,8L,0L,0L,9L,9L,5L,0L,2L,4L,8L,7L,5L,6L,2L,1L,8L,9L,0L,5L,4L,7L,2L,6L,3L,6L,8L,1L,5L,9L,2L,0L,3L,9L,8L,0L,0L,9L,9L,5L,0L,2L,4L,8L,7L,5L,6L,2L,1L,8L,9L,0L,5L,4L,7L,2L,6L,3L,6L,8L,1L,5L,9L,2L,0L,3L,9L,8L,0L,0L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021406Inst : IEnumerable<long>
{
public static readonly long[] Value=A021406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021406.Bytes);
public long this[int i]=>Value[i];

public static A021406Inst Instance=new A021406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021407
{
public static readonly long[] Value={ 0L,0L,2L,4L,8L,1L,3L,8L,9L,5L,7L,8L,1L,6L,3L,7L,7L,1L,7L,1L,2L,1L,5L,8L,8L,0L,8L,9L,3L,3L,0L,0L,2L,4L,8L,1L,3L,8L,9L,5L,7L,8L,1L,6L,3L,7L,7L,1L,7L,1L,2L,1L,5L,8L,8L,0L,8L,9L,3L,3L,0L,0L,2L,4L,8L,1L,3L,8L,9L,5L,7L,8L,1L,6L,3L,7L,7L,1L,7L,1L,2L,1L,5L,8L,8L,0L,8L,9L,3L,3L,0L,0L,2L,4L,8L,1L,3L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021407Inst : IEnumerable<long>
{
public static readonly long[] Value=A021407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021407.Bytes);
public long this[int i]=>Value[i];

public static A021407Inst Instance=new A021407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021408
{
public static readonly long[] Value={ 0L,0L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L,4L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021408Inst : IEnumerable<long>
{
public static readonly long[] Value=A021408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021408.Bytes);
public long this[int i]=>Value[i];

public static A021408Inst Instance=new A021408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021409
{
public static readonly long[] Value={ 0L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L,8L,0L,2L,4L,6L,9L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021409Inst : IEnumerable<long>
{
public static readonly long[] Value=A021409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021409.Bytes);
public long this[int i]=>Value[i];

public static A021409Inst Instance=new A021409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021410
{
public static readonly long[] Value={ 0L,0L,2L,4L,6L,3L,0L,5L,4L,1L,8L,7L,1L,9L,2L,1L,1L,8L,2L,2L,6L,6L,0L,0L,9L,8L,5L,2L,2L,1L,6L,7L,4L,8L,7L,6L,8L,4L,7L,2L,9L,0L,6L,4L,0L,3L,9L,4L,0L,8L,8L,6L,6L,9L,9L,5L,0L,7L,3L,8L,9L,1L,6L,2L,5L,6L,1L,5L,7L,6L,3L,5L,4L,6L,7L,9L,8L,0L,2L,9L,5L,5L,6L,6L,5L,0L,2L,4L,6L,3L,0L,5L,4L,1L,8L,7L,1L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021410Inst : IEnumerable<long>
{
public static readonly long[] Value=A021410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021410.Bytes);
public long this[int i]=>Value[i];

public static A021410Inst Instance=new A021410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021411
{
public static readonly long[] Value={ 0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L,4L,5L,7L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021411Inst : IEnumerable<long>
{
public static readonly long[] Value=A021411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021411.Bytes);
public long this[int i]=>Value[i];

public static A021411Inst Instance=new A021411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021412
{
public static readonly long[] Value={ 0L,0L,2L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L,4L,5L,0L,9L,8L,0L,3L,9L,2L,1L,5L,6L,8L,6L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021412Inst : IEnumerable<long>
{
public static readonly long[] Value=A021412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021412.Bytes);
public long this[int i]=>Value[i];

public static A021412Inst Instance=new A021412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021413
{
public static readonly long[] Value={ 0L,0L,2L,4L,4L,4L,9L,8L,7L,7L,7L,5L,0L,6L,1L,1L,2L,4L,6L,9L,4L,3L,7L,6L,5L,2L,8L,1L,1L,7L,3L,5L,9L,4L,1L,3L,2L,0L,2L,9L,3L,3L,9L,8L,5L,3L,3L,0L,0L,7L,3L,3L,4L,9L,6L,3L,3L,2L,5L,1L,8L,3L,3L,7L,4L,0L,8L,3L,1L,2L,9L,5L,8L,4L,3L,5L,2L,0L,7L,8L,2L,3L,9L,6L,0L,8L,8L,0L,1L,9L,5L,5L,9L,9L,0L,2L,2L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021413Inst : IEnumerable<long>
{
public static readonly long[] Value=A021413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021413.Bytes);
public long this[int i]=>Value[i];

public static A021413Inst Instance=new A021413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021414
{
public static readonly long[] Value={ 1L,15L,148L,1218L,9079L,63693L,429346L,2815296L,18097717L,114645531L,718257904L,4461736734L,27532164115L,169004094729L,1033087293022L,6293858904732L,38239893731473L,231823257614487L,1402859602945900L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021414Inst : IEnumerable<long>
{
public static readonly long[] Value=A021414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021414.Bytes);
public long this[int i]=>Value[i];

public static A021414Inst Instance=new A021414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021415
{
public static readonly long[] Value={ 0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L,4L,3L,3L,0L,9L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021415Inst : IEnumerable<long>
{
public static readonly long[] Value=A021415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021415.Bytes);
public long this[int i]=>Value[i];

public static A021415Inst Instance=new A021415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021416
{
public static readonly long[] Value={ 0L,0L,2L,4L,2L,7L,1L,8L,4L,4L,6L,6L,0L,1L,9L,4L,1L,7L,4L,7L,5L,7L,2L,8L,1L,5L,5L,3L,3L,9L,8L,0L,5L,8L,2L,5L,2L,4L,2L,7L,1L,8L,4L,4L,6L,6L,0L,1L,9L,4L,1L,7L,4L,7L,5L,7L,2L,8L,1L,5L,5L,3L,3L,9L,8L,0L,5L,8L,2L,5L,2L,4L,2L,7L,1L,8L,4L,4L,6L,6L,0L,1L,9L,4L,1L,7L,4L,7L,5L,7L,2L,8L,1L,5L,5L,3L,3L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021416Inst : IEnumerable<long>
{
public static readonly long[] Value=A021416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021416.Bytes);
public long this[int i]=>Value[i];

public static A021416Inst Instance=new A021416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021417
{
public static readonly long[] Value={ 0L,0L,2L,4L,2L,1L,3L,0L,7L,5L,0L,6L,0L,5L,3L,2L,6L,8L,7L,6L,5L,1L,3L,3L,1L,7L,1L,9L,1L,2L,8L,3L,2L,9L,2L,9L,7L,8L,2L,0L,8L,2L,3L,2L,4L,4L,5L,5L,2L,0L,5L,8L,1L,1L,1L,3L,8L,0L,1L,4L,5L,2L,7L,8L,4L,5L,0L,3L,6L,3L,1L,9L,6L,1L,2L,5L,9L,0L,7L,9L,9L,0L,3L,1L,4L,7L,6L,9L,9L,7L,5L,7L,8L,6L,9L,2L,4L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021417Inst : IEnumerable<long>
{
public static readonly long[] Value=A021417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021417.Bytes);
public long this[int i]=>Value[i];

public static A021417Inst Instance=new A021417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021418
{
public static readonly long[] Value={ 0L,0L,2L,4L,1L,5L,4L,5L,8L,9L,3L,7L,1L,9L,8L,0L,6L,7L,6L,3L,2L,8L,5L,0L,2L,4L,1L,5L,4L,5L,8L,9L,3L,7L,1L,9L,8L,0L,6L,7L,6L,3L,2L,8L,5L,0L,2L,4L,1L,5L,4L,5L,8L,9L,3L,7L,1L,9L,8L,0L,6L,7L,6L,3L,2L,8L,5L,0L,2L,4L,1L,5L,4L,5L,8L,9L,3L,7L,1L,9L,8L,0L,6L,7L,6L,3L,2L,8L,5L,0L,2L,4L,1L,5L,4L,5L,8L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021418Inst : IEnumerable<long>
{
public static readonly long[] Value=A021418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021418.Bytes);
public long this[int i]=>Value[i];

public static A021418Inst Instance=new A021418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021419
{
public static readonly long[] Value={ 0L,0L,2L,4L,0L,9L,6L,3L,8L,5L,5L,4L,2L,1L,6L,8L,6L,7L,4L,6L,9L,8L,7L,9L,5L,1L,8L,0L,7L,2L,2L,8L,9L,1L,5L,6L,6L,2L,6L,5L,0L,6L,0L,2L,4L,0L,9L,6L,3L,8L,5L,5L,4L,2L,1L,6L,8L,6L,7L,4L,6L,9L,8L,7L,9L,5L,1L,8L,0L,7L,2L,2L,8L,9L,1L,5L,6L,6L,2L,6L,5L,0L,6L,0L,2L,4L,0L,9L,6L,3L,8L,5L,5L,4L,2L,1L,6L,8L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021419Inst : IEnumerable<long>
{
public static readonly long[] Value=A021419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021419.Bytes);
public long this[int i]=>Value[i];

public static A021419Inst Instance=new A021419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021420
{
public static readonly long[] Value={ 0L,0L,2L,4L,0L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L,1L,5L,3L,8L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021420Inst : IEnumerable<long>
{
public static readonly long[] Value=A021420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021420.Bytes);
public long this[int i]=>Value[i];

public static A021420Inst Instance=new A021420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021421
{
public static readonly long[] Value={ 0L,0L,2L,3L,9L,8L,0L,8L,1L,5L,3L,4L,7L,7L,2L,1L,8L,2L,2L,5L,4L,1L,9L,6L,6L,4L,2L,6L,8L,5L,8L,5L,1L,3L,1L,8L,9L,4L,4L,8L,4L,4L,1L,2L,4L,7L,0L,0L,2L,3L,9L,8L,0L,8L,1L,5L,3L,4L,7L,7L,2L,1L,8L,2L,2L,5L,4L,1L,9L,6L,6L,4L,2L,6L,8L,5L,8L,5L,1L,3L,1L,8L,9L,4L,4L,8L,4L,4L,1L,2L,4L,7L,0L,0L,2L,3L,9L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021421Inst : IEnumerable<long>
{
public static readonly long[] Value=A021421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021421.Bytes);
public long this[int i]=>Value[i];

public static A021421Inst Instance=new A021421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021438
{
public static readonly long[] Value={ 0L,0L,2L,3L,0L,4L,1L,4L,7L,4L,6L,5L,4L,3L,7L,7L,8L,8L,0L,1L,8L,4L,3L,3L,1L,7L,9L,7L,2L,3L,5L,0L,2L,3L,0L,4L,1L,4L,7L,4L,6L,5L,4L,3L,7L,7L,8L,8L,0L,1L,8L,4L,3L,3L,1L,7L,9L,7L,2L,3L,5L,0L,2L,3L,0L,4L,1L,4L,7L,4L,6L,5L,4L,3L,7L,7L,8L,8L,0L,1L,8L,4L,3L,3L,1L,7L,9L,7L,2L,3L,5L,0L,2L,3L,0L,4L,1L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021438Inst : IEnumerable<long>
{
public static readonly long[] Value=A021438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021438.Bytes);
public long this[int i]=>Value[i];

public static A021438Inst Instance=new A021438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021439
{
public static readonly long[] Value={ 0L,0L,2L,2L,9L,8L,8L,5L,0L,5L,7L,4L,7L,1L,2L,6L,4L,3L,6L,7L,8L,1L,6L,0L,9L,1L,9L,5L,4L,0L,2L,2L,9L,8L,8L,5L,0L,5L,7L,4L,7L,1L,2L,6L,4L,3L,6L,7L,8L,1L,6L,0L,9L,1L,9L,5L,4L,0L,2L,2L,9L,8L,8L,5L,0L,5L,7L,4L,7L,1L,2L,6L,4L,3L,6L,7L,8L,1L,6L,0L,9L,1L,9L,5L,4L,0L,2L,2L,9L,8L,8L,5L,0L,5L,7L,4L,7L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021439Inst : IEnumerable<long>
{
public static readonly long[] Value=A021439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021439.Bytes);
public long this[int i]=>Value[i];

public static A021439Inst Instance=new A021439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021440
{
public static readonly long[] Value={ 0L,0L,2L,2L,9L,3L,5L,7L,7L,9L,8L,1L,6L,5L,1L,3L,7L,6L,1L,4L,6L,7L,8L,8L,9L,9L,0L,8L,2L,5L,6L,8L,8L,0L,7L,3L,3L,9L,4L,4L,9L,5L,4L,1L,2L,8L,4L,4L,0L,3L,6L,6L,9L,7L,2L,4L,7L,7L,0L,6L,4L,2L,2L,0L,1L,8L,3L,4L,8L,6L,2L,3L,8L,5L,3L,2L,1L,1L,0L,0L,9L,1L,7L,4L,3L,1L,1L,9L,2L,6L,6L,0L,5L,5L,0L,4L,5L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021440Inst : IEnumerable<long>
{
public static readonly long[] Value=A021440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021440.Bytes);
public long this[int i]=>Value[i];

public static A021440Inst Instance=new A021440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021441
{
public static readonly long[] Value={ 0L,0L,2L,2L,8L,8L,3L,2L,9L,5L,1L,9L,4L,5L,0L,8L,0L,0L,9L,1L,5L,3L,3L,1L,8L,0L,7L,7L,8L,0L,3L,2L,0L,3L,6L,6L,1L,3L,2L,7L,2L,3L,1L,1L,2L,1L,2L,8L,1L,4L,6L,4L,5L,3L,0L,8L,9L,2L,4L,4L,8L,5L,1L,2L,5L,8L,5L,8L,1L,2L,3L,5L,6L,9L,7L,9L,4L,0L,5L,0L,3L,4L,3L,2L,4L,9L,4L,2L,7L,9L,1L,7L,6L,2L,0L,1L,3L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021441Inst : IEnumerable<long>
{
public static readonly long[] Value=A021441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021441.Bytes);
public long this[int i]=>Value[i];

public static A021441Inst Instance=new A021441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021442
{
public static readonly long[] Value={ 0L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L,2L,8L,3L,1L,0L,5L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021442Inst : IEnumerable<long>
{
public static readonly long[] Value=A021442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021442.Bytes);
public long this[int i]=>Value[i];

public static A021442Inst Instance=new A021442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021443
{
public static readonly long[] Value={ 0L,0L,2L,2L,7L,7L,9L,0L,4L,3L,2L,8L,0L,1L,8L,2L,2L,3L,2L,3L,4L,6L,2L,4L,1L,4L,5L,7L,8L,5L,8L,7L,6L,9L,9L,3L,1L,6L,6L,2L,8L,7L,0L,1L,5L,9L,4L,5L,3L,3L,0L,2L,9L,6L,1L,2L,7L,5L,6L,2L,6L,4L,2L,3L,6L,9L,0L,2L,0L,5L,0L,1L,1L,3L,8L,9L,5L,2L,1L,6L,4L,0L,0L,9L,1L,1L,1L,6L,1L,7L,3L,1L,2L,0L,7L,2L,8L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021443Inst : IEnumerable<long>
{
public static readonly long[] Value=A021443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021443.Bytes);
public long this[int i]=>Value[i];

public static A021443Inst Instance=new A021443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021444
{
public static readonly long[] Value={ 0L,0L,2L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021444Inst : IEnumerable<long>
{
public static readonly long[] Value=A021444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021444.Bytes);
public long this[int i]=>Value[i];

public static A021444Inst Instance=new A021444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021445
{
public static readonly long[] Value={ 0L,0L,2L,2L,6L,7L,5L,7L,3L,6L,9L,6L,1L,4L,5L,1L,2L,4L,7L,1L,6L,5L,5L,3L,2L,8L,7L,9L,8L,1L,8L,5L,9L,4L,1L,0L,4L,3L,0L,8L,3L,9L,0L,0L,2L,2L,6L,7L,5L,7L,3L,6L,9L,6L,1L,4L,5L,1L,2L,4L,7L,1L,6L,5L,5L,3L,2L,8L,7L,9L,8L,1L,8L,5L,9L,4L,1L,0L,4L,3L,0L,8L,3L,9L,0L,0L,2L,2L,6L,7L,5L,7L,3L,6L,9L,6L,1L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021445Inst : IEnumerable<long>
{
public static readonly long[] Value=A021445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021445.Bytes);
public long this[int i]=>Value[i];

public static A021445Inst Instance=new A021445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021446
{
public static readonly long[] Value={ 0L,0L,2L,2L,6L,2L,4L,4L,3L,4L,3L,8L,9L,1L,4L,0L,2L,7L,1L,4L,9L,3L,2L,1L,2L,6L,6L,9L,6L,8L,3L,2L,5L,7L,9L,1L,8L,5L,5L,2L,0L,3L,6L,1L,9L,9L,0L,9L,5L,0L,2L,2L,6L,2L,4L,4L,3L,4L,3L,8L,9L,1L,4L,0L,2L,7L,1L,4L,9L,3L,2L,1L,2L,6L,6L,9L,6L,8L,3L,2L,5L,7L,9L,1L,8L,5L,5L,2L,0L,3L,6L,1L,9L,9L,0L,9L,5L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021446Inst : IEnumerable<long>
{
public static readonly long[] Value=A021446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021446.Bytes);
public long this[int i]=>Value[i];

public static A021446Inst Instance=new A021446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021447
{
public static readonly long[] Value={ 0L,0L,2L,2L,5L,7L,3L,3L,6L,3L,4L,3L,1L,1L,5L,1L,2L,4L,1L,5L,3L,4L,9L,8L,8L,7L,1L,3L,3L,1L,8L,2L,8L,4L,4L,2L,4L,3L,7L,9L,2L,3L,2L,5L,0L,5L,6L,4L,3L,3L,4L,0L,8L,5L,7L,7L,8L,7L,8L,1L,0L,3L,8L,3L,7L,4L,7L,1L,7L,8L,3L,2L,9L,5L,7L,1L,1L,0L,6L,0L,9L,4L,8L,0L,8L,1L,2L,6L,4L,1L,0L,8L,3L,5L,2L,1L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021447Inst : IEnumerable<long>
{
public static readonly long[] Value=A021447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021447.Bytes);
public long this[int i]=>Value[i];

public static A021447Inst Instance=new A021447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021448
{
public static readonly long[] Value={ 0L,0L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021448Inst : IEnumerable<long>
{
public static readonly long[] Value=A021448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021448.Bytes);
public long this[int i]=>Value[i];

public static A021448Inst Instance=new A021448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021449
{
public static readonly long[] Value={ 0L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L,1L,2L,3L,5L,9L,5L,5L,0L,5L,6L,1L,7L,9L,7L,7L,5L,2L,8L,0L,8L,9L,8L,8L,7L,6L,4L,0L,4L,4L,9L,4L,3L,8L,2L,0L,2L,2L,4L,7L,1L,9L,1L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021449Inst : IEnumerable<long>
{
public static readonly long[] Value=A021449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021449.Bytes);
public long this[int i]=>Value[i];

public static A021449Inst Instance=new A021449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021450
{
public static readonly long[] Value={ 0L,0L,2L,2L,4L,2L,1L,5L,2L,4L,6L,6L,3L,6L,7L,7L,1L,3L,0L,0L,4L,4L,8L,4L,3L,0L,4L,9L,3L,2L,7L,3L,5L,4L,2L,6L,0L,0L,8L,9L,6L,8L,6L,0L,9L,8L,6L,5L,4L,7L,0L,8L,5L,2L,0L,1L,7L,9L,3L,7L,2L,1L,9L,7L,3L,0L,9L,4L,1L,7L,0L,4L,0L,3L,5L,8L,7L,4L,4L,3L,9L,4L,6L,1L,8L,8L,3L,4L,0L,8L,0L,7L,1L,7L,4L,8L,8L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021450Inst : IEnumerable<long>
{
public static readonly long[] Value=A021450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021450.Bytes);
public long this[int i]=>Value[i];

public static A021450Inst Instance=new A021450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021451
{
public static readonly long[] Value={ 0L,0L,2L,2L,3L,7L,1L,3L,6L,4L,6L,5L,3L,2L,4L,3L,8L,4L,7L,8L,7L,4L,7L,2L,0L,3L,5L,7L,9L,4L,1L,8L,3L,4L,4L,5L,1L,9L,0L,1L,5L,6L,5L,9L,9L,5L,5L,2L,5L,7L,2L,7L,0L,6L,9L,3L,5L,1L,2L,3L,0L,4L,2L,5L,0L,5L,5L,9L,2L,8L,4L,1L,1L,6L,3L,3L,1L,0L,9L,6L,1L,9L,6L,8L,6L,8L,0L,0L,8L,9L,4L,8L,5L,4L,5L,8L,6L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021451Inst : IEnumerable<long>
{
public static readonly long[] Value=A021451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021451.Bytes);
public long this[int i]=>Value[i];

public static A021451Inst Instance=new A021451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021452
{
public static readonly long[] Value={ 0L,0L,2L,2L,3L,2L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L,8L,5L,7L,1L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021452Inst : IEnumerable<long>
{
public static readonly long[] Value=A021452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021452.Bytes);
public long this[int i]=>Value[i];

public static A021452Inst Instance=new A021452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021453
{
public static readonly long[] Value={ 0L,0L,2L,2L,2L,7L,1L,7L,1L,4L,9L,2L,2L,0L,4L,8L,9L,9L,7L,7L,7L,2L,8L,2L,8L,5L,0L,7L,7L,9L,5L,1L,0L,0L,2L,2L,2L,7L,1L,7L,1L,4L,9L,2L,2L,0L,4L,8L,9L,9L,7L,7L,7L,2L,8L,2L,8L,5L,0L,7L,7L,9L,5L,1L,0L,0L,2L,2L,2L,7L,1L,7L,1L,4L,9L,2L,2L,0L,4L,8L,9L,9L,7L,7L,7L,2L,8L,2L,8L,5L,0L,7L,7L,9L,5L,1L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021453Inst : IEnumerable<long>
{
public static readonly long[] Value=A021453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021453.Bytes);
public long this[int i]=>Value[i];

public static A021453Inst Instance=new A021453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021470
{
public static readonly long[] Value={ 0L,0L,2L,1L,4L,5L,9L,2L,2L,7L,4L,6L,7L,8L,1L,1L,1L,5L,8L,7L,9L,8L,2L,8L,3L,2L,6L,1L,8L,0L,2L,5L,7L,5L,1L,0L,7L,2L,9L,6L,1L,3L,7L,3L,3L,9L,0L,5L,5L,7L,9L,3L,9L,9L,1L,4L,1L,6L,3L,0L,9L,0L,1L,2L,8L,7L,5L,5L,3L,6L,4L,8L,0L,6L,8L,6L,6L,9L,5L,2L,7L,8L,9L,6L,9L,9L,5L,7L,0L,8L,1L,5L,4L,5L,0L,6L,4L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021470Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021470.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021470Inst : IEnumerable<long>
{
public static readonly long[] Value=A021470.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021470.Bytes);
public long this[int i]=>Value[i];

public static A021470Inst Instance=new A021470Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021471
{
public static readonly long[] Value={ 0L,0L,2L,1L,4L,1L,3L,2L,7L,6L,2L,3L,1L,2L,6L,3L,3L,8L,3L,2L,9L,7L,6L,4L,4L,5L,3L,9L,6L,1L,4L,5L,6L,1L,0L,2L,7L,8L,3L,7L,2L,5L,9L,1L,0L,0L,6L,4L,2L,3L,9L,8L,2L,8L,6L,9L,3L,7L,9L,0L,1L,4L,9L,8L,9L,2L,9L,3L,3L,6L,1L,8L,8L,4L,3L,6L,8L,3L,0L,8L,3L,5L,1L,1L,7L,7L,7L,3L,0L,1L,9L,2L,7L,1L,9L,4L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021471Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021471.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021471Inst : IEnumerable<long>
{
public static readonly long[] Value=A021471.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021471.Bytes);
public long this[int i]=>Value[i];

public static A021471Inst Instance=new A021471Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021472
{
public static readonly long[] Value={ 0L,0L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L,1L,3L,6L,7L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021472Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021472.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021472Inst : IEnumerable<long>
{
public static readonly long[] Value=A021472.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021472.Bytes);
public long this[int i]=>Value[i];

public static A021472Inst Instance=new A021472Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021473
{
public static readonly long[] Value={ 0L,0L,2L,1L,3L,2L,1L,9L,6L,1L,6L,2L,0L,4L,6L,9L,0L,8L,3L,1L,5L,5L,6L,5L,0L,3L,1L,9L,8L,2L,9L,4L,2L,4L,3L,0L,7L,0L,3L,6L,2L,4L,7L,3L,3L,4L,7L,5L,4L,7L,9L,7L,4L,4L,1L,3L,6L,4L,6L,0L,5L,5L,4L,3L,7L,1L,0L,0L,2L,1L,3L,2L,1L,9L,6L,1L,6L,2L,0L,4L,6L,9L,0L,8L,3L,1L,5L,5L,6L,5L,0L,3L,1L,9L,8L,2L,9L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021473Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021473.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021473Inst : IEnumerable<long>
{
public static readonly long[] Value=A021473.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021473.Bytes);
public long this[int i]=>Value[i];

public static A021473Inst Instance=new A021473Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021474
{
public static readonly long[] Value={ 1L,20L,278L,3388L,39039L,438648L,4872316L,53834696L,593387597L,6533322796L,71896935474L,791018479524L,8701965018475L,95725426313264L,1052998752170552L,11583081609022672L,127414374439552473L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021474Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021474.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021474Inst : IEnumerable<long>
{
public static readonly long[] Value=A021474.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021474.Bytes);
public long this[int i]=>Value[i];

public static A021474Inst Instance=new A021474Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021475
{
public static readonly long[] Value={ 0L,0L,2L,1L,2L,3L,1L,4L,2L,2L,5L,0L,5L,3L,0L,7L,8L,5L,5L,6L,2L,6L,3L,2L,6L,9L,6L,3L,9L,0L,6L,5L,8L,1L,7L,4L,0L,9L,7L,6L,6L,4L,5L,4L,3L,5L,2L,4L,4L,1L,6L,1L,3L,5L,8L,8L,1L,1L,0L,4L,0L,3L,3L,9L,7L,0L,2L,7L,6L,0L,0L,8L,4L,9L,2L,5L,6L,9L,0L,0L,2L,1L,2L,3L,1L,4L,2L,2L,5L,0L,5L,3L,0L,7L,8L,5L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021475Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021475.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021475Inst : IEnumerable<long>
{
public static readonly long[] Value=A021475.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021475.Bytes);
public long this[int i]=>Value[i];

public static A021475Inst Instance=new A021475Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021476
{
public static readonly long[] Value={ 0L,0L,2L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L,1L,0L,1L,6L,9L,4L,9L,1L,5L,2L,5L,4L,2L,3L,7L,2L,8L,8L,1L,3L,5L,5L,9L,3L,2L,2L,0L,3L,3L,8L,9L,8L,3L,0L,5L,0L,8L,4L,7L,4L,5L,7L,6L,2L,7L,1L,1L,8L,6L,4L,4L,0L,6L,7L,7L,9L,6L,6L,1L,0L,1L,6L,9L,4L,9L,1L,5L,2L,5L,4L,2L,3L,7L,2L,8L,8L,1L,3L,5L,5L,9L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021476Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021476.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021476Inst : IEnumerable<long>
{
public static readonly long[] Value=A021476.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021476.Bytes);
public long this[int i]=>Value[i];

public static A021476Inst Instance=new A021476Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021477
{
public static readonly long[] Value={ 0L,0L,2L,1L,1L,4L,1L,6L,4L,9L,0L,4L,8L,6L,2L,5L,7L,9L,2L,8L,1L,1L,8L,3L,9L,3L,2L,3L,4L,6L,7L,2L,3L,0L,4L,4L,3L,9L,7L,4L,6L,3L,0L,0L,2L,1L,1L,4L,1L,6L,4L,9L,0L,4L,8L,6L,2L,5L,7L,9L,2L,8L,1L,1L,8L,3L,9L,3L,2L,3L,4L,6L,7L,2L,3L,0L,4L,4L,3L,9L,7L,4L,6L,3L,0L,0L,2L,1L,1L,4L,1L,6L,4L,9L,0L,4L,8L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021477Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021477.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021477Inst : IEnumerable<long>
{
public static readonly long[] Value=A021477.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021477.Bytes);
public long this[int i]=>Value[i];

public static A021477Inst Instance=new A021477Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021478
{
public static readonly long[] Value={ 0L,0L,2L,1L,0L,9L,7L,0L,4L,6L,4L,1L,3L,5L,0L,2L,1L,0L,9L,7L,0L,4L,6L,4L,1L,3L,5L,0L,2L,1L,0L,9L,7L,0L,4L,6L,4L,1L,3L,5L,0L,2L,1L,0L,9L,7L,0L,4L,6L,4L,1L,3L,5L,0L,2L,1L,0L,9L,7L,0L,4L,6L,4L,1L,3L,5L,0L,2L,1L,0L,9L,7L,0L,4L,6L,4L,1L,3L,5L,0L,2L,1L,0L,9L,7L,0L,4L,6L,4L,1L,3L,5L,0L,2L,1L,0L,9L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021478Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021478.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021478Inst : IEnumerable<long>
{
public static readonly long[] Value=A021478.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021478.Bytes);
public long this[int i]=>Value[i];

public static A021478Inst Instance=new A021478Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021479
{
public static readonly long[] Value={ 0L,0L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L,1L,5L,7L,8L,9L,4L,7L,3L,6L,8L,4L,2L,1L,0L,5L,2L,6L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021479Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021479.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021479Inst : IEnumerable<long>
{
public static readonly long[] Value=A021479.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021479.Bytes);
public long this[int i]=>Value[i];

public static A021479Inst Instance=new A021479Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021480
{
public static readonly long[] Value={ 0L,0L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L,1L,0L,0L,8L,4L,0L,3L,3L,6L,1L,3L,4L,4L,5L,3L,7L,8L,1L,5L,1L,2L,6L,0L,5L,0L,4L,2L,0L,1L,6L,8L,0L,6L,7L,2L,2L,6L,8L,9L,0L,7L,5L,6L,3L,0L,2L,5L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021480Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021480.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021480Inst : IEnumerable<long>
{
public static readonly long[] Value=A021480.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021480.Bytes);
public long this[int i]=>Value[i];

public static A021480Inst Instance=new A021480Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021481
{
public static readonly long[] Value={ 0L,0L,2L,0L,9L,6L,4L,3L,6L,0L,5L,8L,7L,0L,0L,2L,0L,9L,6L,4L,3L,6L,0L,5L,8L,7L,0L,0L,2L,0L,9L,6L,4L,3L,6L,0L,5L,8L,7L,0L,0L,2L,0L,9L,6L,4L,3L,6L,0L,5L,8L,7L,0L,0L,2L,0L,9L,6L,4L,3L,6L,0L,5L,8L,7L,0L,0L,2L,0L,9L,6L,4L,3L,6L,0L,5L,8L,7L,0L,0L,2L,0L,9L,6L,4L,3L,6L,0L,5L,8L,7L,0L,0L,2L,0L,9L,6L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021481Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021481.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021481Inst : IEnumerable<long>
{
public static readonly long[] Value=A021481.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021481.Bytes);
public long this[int i]=>Value[i];

public static A021481Inst Instance=new A021481Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021482
{
public static readonly long[] Value={ 0L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L,0L,2L,0L,9L,2L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021482Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021482.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021482Inst : IEnumerable<long>
{
public static readonly long[] Value=A021482.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021482.Bytes);
public long this[int i]=>Value[i];

public static A021482Inst Instance=new A021482Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021483
{
public static readonly long[] Value={ 0L,0L,2L,0L,8L,7L,6L,8L,2L,6L,7L,2L,2L,3L,3L,8L,2L,0L,4L,5L,9L,2L,9L,0L,1L,8L,7L,8L,9L,1L,4L,4L,0L,5L,0L,1L,0L,4L,3L,8L,4L,1L,3L,3L,6L,1L,1L,6L,9L,1L,0L,2L,2L,9L,6L,4L,5L,0L,9L,3L,9L,4L,5L,7L,2L,0L,2L,5L,0L,5L,2L,1L,9L,2L,0L,6L,6L,8L,0L,5L,8L,4L,5L,5L,1L,1L,4L,8L,2L,2L,5L,4L,6L,9L,7L,2L,8L,6L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021483Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021483.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021483Inst : IEnumerable<long>
{
public static readonly long[] Value=A021483.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021483.Bytes);
public long this[int i]=>Value[i];

public static A021483Inst Instance=new A021483Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021484
{
public static readonly long[] Value={ 1L,21L,310L,4050L,50371L,613671L,7411240L,89174100L,1071295141L,12861600921L,154369595770L,1852587338550L,22231809806311L,266785528785771L,3201445408153900L,38417440232993400L,461009759536223881L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021484Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021484.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021484Inst : IEnumerable<long>
{
public static readonly long[] Value=A021484.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021484.Bytes);
public long this[int i]=>Value[i];

public static A021484Inst Instance=new A021484Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021485
{
public static readonly long[] Value={ 0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L,0L,7L,9L,0L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021485Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021485.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021485Inst : IEnumerable<long>
{
public static readonly long[] Value=A021485.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021485.Bytes);
public long this[int i]=>Value[i];

public static A021485Inst Instance=new A021485Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021502
{
public static readonly long[] Value={ 0L,0L,2L,0L,0L,8L,0L,3L,2L,1L,2L,8L,5L,1L,4L,0L,5L,6L,2L,2L,4L,8L,9L,9L,5L,9L,8L,3L,9L,3L,5L,7L,4L,2L,9L,7L,1L,8L,8L,7L,5L,5L,0L,2L,0L,0L,8L,0L,3L,2L,1L,2L,8L,5L,1L,4L,0L,5L,6L,2L,2L,4L,8L,9L,9L,5L,9L,8L,3L,9L,3L,5L,7L,4L,2L,9L,7L,1L,8L,8L,7L,5L,5L,0L,2L,0L,0L,8L,0L,3L,2L,1L,2L,8L,5L,1L,4L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021502Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021502.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021502Inst : IEnumerable<long>
{
public static readonly long[] Value=A021502.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021502.Bytes);
public long this[int i]=>Value[i];

public static A021502Inst Instance=new A021502Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021503
{
public static readonly long[] Value={ 1L,18L,217L,2214L,20701L,183906L,1582129L,13325598L,110626021L,909165114L,7418351161L,60217256502L,486961532461L,3927035533842L,31604351090113L,253963231160526L,2038476448492021L,16348435376893290L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021503Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021503.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021503Inst : IEnumerable<long>
{
public static readonly long[] Value=A021503.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021503.Bytes);
public long this[int i]=>Value[i];

public static A021503Inst Instance=new A021503Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021504
{
public static readonly long[] Value={ 1L,19L,244L,2674L,27055L,261793L,2467018L,22871728L,209866789L,1912958047L,17361652672L,157125321262L,1419351371803L,12805505620381L,115437617402806L,1040066979064876L,9367373410791697L,84346984486082395L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021504Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021504.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021504Inst : IEnumerable<long>
{
public static readonly long[] Value=A021504.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021504.Bytes);
public long this[int i]=>Value[i];

public static A021504Inst Instance=new A021504Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021505
{
public static readonly long[] Value={ 0L,0L,1L,9L,9L,6L,0L,0L,7L,9L,8L,4L,0L,3L,1L,9L,3L,6L,1L,2L,7L,7L,4L,4L,5L,1L,0L,9L,7L,8L,0L,4L,3L,9L,1L,2L,1L,7L,5L,6L,4L,8L,7L,0L,2L,5L,9L,4L,8L,1L,0L,3L,7L,9L,2L,4L,1L,5L,1L,6L,9L,6L,6L,0L,6L,7L,8L,6L,4L,2L,7L,1L,4L,5L,7L,0L,8L,5L,8L,2L,8L,3L,4L,3L,3L,1L,3L,3L,7L,3L,2L,5L,3L,4L,9L,3L,0L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021505Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021505.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021505Inst : IEnumerable<long>
{
public static readonly long[] Value=A021505.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021505.Bytes);
public long this[int i]=>Value[i];

public static A021505Inst Instance=new A021505Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021506
{
public static readonly long[] Value={ 0L,0L,1L,9L,9L,2L,0L,3L,1L,8L,7L,2L,5L,0L,9L,9L,6L,0L,1L,5L,9L,3L,6L,2L,5L,4L,9L,8L,0L,0L,7L,9L,6L,8L,1L,2L,7L,4L,9L,0L,0L,3L,9L,8L,4L,0L,6L,3L,7L,4L,5L,0L,1L,9L,9L,2L,0L,3L,1L,8L,7L,2L,5L,0L,9L,9L,6L,0L,1L,5L,9L,3L,6L,2L,5L,4L,9L,8L,0L,0L,7L,9L,6L,8L,1L,2L,7L,4L,9L,0L,0L,3L,9L,8L,4L,0L,6L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021506Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021506.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021506Inst : IEnumerable<long>
{
public static readonly long[] Value=A021506.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021506.Bytes);
public long this[int i]=>Value[i];

public static A021506Inst Instance=new A021506Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021507
{
public static readonly long[] Value={ 0L,0L,1L,9L,8L,8L,0L,7L,1L,5L,7L,0L,5L,7L,6L,5L,4L,0L,7L,5L,5L,4L,6L,7L,1L,9L,6L,8L,1L,9L,0L,8L,5L,4L,8L,7L,0L,7L,7L,5L,3L,4L,7L,9L,1L,2L,5L,2L,4L,8L,5L,0L,8L,9L,4L,6L,3L,2L,2L,0L,6L,7L,5L,9L,4L,4L,3L,3L,3L,9L,9L,6L,0L,2L,3L,8L,5L,6L,8L,5L,8L,8L,4L,6L,9L,1L,8L,4L,8L,9L,0L,6L,5L,6L,0L,6L,3L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021507Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021507.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021507Inst : IEnumerable<long>
{
public static readonly long[] Value=A021507.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021507.Bytes);
public long this[int i]=>Value[i];

public static A021507Inst Instance=new A021507Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021508
{
public static readonly long[] Value={ 0L,0L,1L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L,9L,8L,4L,1L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021508Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021508.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021508Inst : IEnumerable<long>
{
public static readonly long[] Value=A021508.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021508.Bytes);
public long this[int i]=>Value[i];

public static A021508Inst Instance=new A021508Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021509
{
public static readonly long[] Value={ 0L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L,9L,8L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021509Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021509.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021509Inst : IEnumerable<long>
{
public static readonly long[] Value=A021509.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021509.Bytes);
public long this[int i]=>Value[i];

public static A021509Inst Instance=new A021509Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021510
{
public static readonly long[] Value={ 0L,0L,1L,9L,7L,6L,2L,8L,4L,5L,8L,4L,9L,8L,0L,2L,3L,7L,1L,5L,4L,1L,5L,0L,1L,9L,7L,6L,2L,8L,4L,5L,8L,4L,9L,8L,0L,2L,3L,7L,1L,5L,4L,1L,5L,0L,1L,9L,7L,6L,2L,8L,4L,5L,8L,4L,9L,8L,0L,2L,3L,7L,1L,5L,4L,1L,5L,0L,1L,9L,7L,6L,2L,8L,4L,5L,8L,4L,9L,8L,0L,2L,3L,7L,1L,5L,4L,1L,5L,0L,1L,9L,7L,6L,2L,8L,4L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021510Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021510.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021510Inst : IEnumerable<long>
{
public static readonly long[] Value=A021510.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021510.Bytes);
public long this[int i]=>Value[i];

public static A021510Inst Instance=new A021510Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021511
{
public static readonly long[] Value={ 0L,0L,1L,9L,7L,2L,3L,8L,6L,5L,8L,7L,7L,7L,1L,2L,0L,3L,1L,5L,5L,8L,1L,8L,5L,4L,0L,4L,3L,3L,9L,2L,5L,0L,4L,9L,3L,0L,9L,6L,6L,4L,6L,9L,4L,2L,8L,0L,0L,7L,8L,8L,9L,5L,4L,6L,3L,5L,1L,0L,8L,4L,8L,1L,2L,6L,2L,3L,2L,7L,4L,1L,6L,1L,7L,3L,5L,7L,0L,0L,1L,9L,7L,2L,3L,8L,6L,5L,8L,7L,7L,7L,1L,2L,0L,3L,1L,5L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021511Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021511.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021511Inst : IEnumerable<long>
{
public static readonly long[] Value=A021511.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021511.Bytes);
public long this[int i]=>Value[i];

public static A021511Inst Instance=new A021511Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021512
{
public static readonly long[] Value={ 0L,0L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L,2L,9L,9L,2L,1L,2L,5L,9L,8L,4L,2L,5L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L,8L,7L,4L,0L,1L,5L,7L,4L,8L,0L,3L,1L,4L,9L,6L,0L,6L,2L,9L,9L,2L,1L,2L,5L,9L,8L,4L,2L,5L,1L,9L,6L,8L,5L,0L,3L,9L,3L,7L,0L,0L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021512Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021512.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021512Inst : IEnumerable<long>
{
public static readonly long[] Value=A021512.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021512.Bytes);
public long this[int i]=>Value[i];

public static A021512Inst Instance=new A021512Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021513
{
public static readonly long[] Value={ 0L,0L,1L,9L,6L,4L,6L,3L,6L,5L,4L,2L,2L,3L,9L,6L,8L,5L,6L,5L,8L,1L,5L,3L,2L,4L,1L,6L,5L,0L,2L,9L,4L,6L,9L,5L,4L,8L,1L,3L,3L,5L,9L,5L,2L,8L,4L,8L,7L,2L,2L,9L,8L,6L,2L,4L,7L,5L,4L,4L,2L,0L,4L,3L,2L,2L,2L,0L,0L,3L,9L,2L,9L,2L,7L,3L,0L,8L,4L,4L,7L,9L,3L,7L,1L,3L,1L,6L,3L,0L,6L,4L,8L,3L,3L,0L,0L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021513Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021513.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021513Inst : IEnumerable<long>
{
public static readonly long[] Value=A021513.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021513.Bytes);
public long this[int i]=>Value[i];

public static A021513Inst Instance=new A021513Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021514
{
public static readonly long[] Value={ 1L,20L,273L,3208L,35069L,368988L,3800761L,38676176L,390782997L,3931986916L,39464899409L,395519441304L,3960417893485L,39635522209004L,396543288909417L,3966561311533792L,39672383714545733L,396764460934414452L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021514Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021514.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021514Inst : IEnumerable<long>
{
public static readonly long[] Value=A021514.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021514.Bytes);
public long this[int i]=>Value[i];

public static A021514Inst Instance=new A021514Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021515
{
public static readonly long[] Value={ 0L,0L,1L,9L,5L,6L,9L,4L,7L,1L,6L,2L,4L,2L,6L,6L,1L,4L,4L,8L,1L,4L,0L,9L,0L,0L,1L,9L,5L,6L,9L,4L,7L,1L,6L,2L,4L,2L,6L,6L,1L,4L,4L,8L,1L,4L,0L,9L,0L,0L,1L,9L,5L,6L,9L,4L,7L,1L,6L,2L,4L,2L,6L,6L,1L,4L,4L,8L,1L,4L,0L,9L,0L,0L,1L,9L,5L,6L,9L,4L,7L,1L,6L,2L,4L,2L,6L,6L,1L,4L,4L,8L,1L,4L,0L,9L,0L,0L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021515Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021515.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021515Inst : IEnumerable<long>
{
public static readonly long[] Value=A021515.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021515.Bytes);
public long this[int i]=>Value[i];

public static A021515Inst Instance=new A021515Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021516
{
public static readonly long[] Value={ 0L,0L,1L,9L,5L,3L,1L,2L,5L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021516Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021516.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021516Inst : IEnumerable<long>
{
public static readonly long[] Value=A021516.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021516.Bytes);
public long this[int i]=>Value[i];

public static A021516Inst Instance=new A021516Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021517
{
public static readonly long[] Value={ 0L,0L,1L,9L,4L,9L,3L,1L,7L,7L,3L,8L,7L,9L,1L,4L,2L,3L,0L,0L,1L,9L,4L,9L,3L,1L,7L,7L,3L,8L,7L,9L,1L,4L,2L,3L,0L,0L,1L,9L,4L,9L,3L,1L,7L,7L,3L,8L,7L,9L,1L,4L,2L,3L,0L,0L,1L,9L,4L,9L,3L,1L,7L,7L,3L,8L,7L,9L,1L,4L,2L,3L,0L,0L,1L,9L,4L,9L,3L,1L,7L,7L,3L,8L,7L,9L,1L,4L,2L,3L,0L,0L,1L,9L,4L,9L,3L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021517Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021517.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021517Inst : IEnumerable<long>
{
public static readonly long[] Value=A021517.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021517.Bytes);
public long this[int i]=>Value[i];

public static A021517Inst Instance=new A021517Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021534
{
public static readonly long[] Value={ 1L,22L,337L,4522L,57253L,705334L,8574889L,103567234L,1246828045L,14986093486L,179978152081L,2160608272186L,25932522746677L,311221616234278L,3734847461630713L,44819297962008178L,537838346143305949L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021534Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021534.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021534Inst : IEnumerable<long>
{
public static readonly long[] Value=A021534.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021534.Bytes);
public long this[int i]=>Value[i];

public static A021534Inst Instance=new A021534Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021535
{
public static readonly long[] Value={ 0L,0L,1L,8L,8L,3L,2L,3L,9L,1L,7L,1L,3L,7L,4L,7L,6L,4L,5L,9L,5L,1L,0L,3L,5L,7L,8L,1L,5L,4L,4L,2L,5L,6L,1L,2L,0L,5L,2L,7L,3L,0L,6L,9L,6L,7L,9L,8L,4L,9L,3L,4L,0L,8L,6L,6L,2L,9L,0L,0L,1L,8L,8L,3L,2L,3L,9L,1L,7L,1L,3L,7L,4L,7L,6L,4L,5L,9L,5L,1L,0L,3L,5L,7L,8L,1L,5L,4L,4L,2L,5L,6L,1L,2L,0L,5L,2L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021535Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021535.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021535Inst : IEnumerable<long>
{
public static readonly long[] Value=A021535.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021535.Bytes);
public long this[int i]=>Value[i];

public static A021535Inst Instance=new A021535Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021536
{
public static readonly long[] Value={ 0L,0L,1L,8L,7L,9L,6L,9L,9L,2L,4L,8L,1L,2L,0L,3L,0L,0L,7L,5L,1L,8L,7L,9L,6L,9L,9L,2L,4L,8L,1L,2L,0L,3L,0L,0L,7L,5L,1L,8L,7L,9L,6L,9L,9L,2L,4L,8L,1L,2L,0L,3L,0L,0L,7L,5L,1L,8L,7L,9L,6L,9L,9L,2L,4L,8L,1L,2L,0L,3L,0L,0L,7L,5L,1L,8L,7L,9L,6L,9L,9L,2L,4L,8L,1L,2L,0L,3L,0L,0L,7L,5L,1L,8L,7L,9L,6L,9L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021536Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021536.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021536Inst : IEnumerable<long>
{
public static readonly long[] Value=A021536.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021536.Bytes);
public long this[int i]=>Value[i];

public static A021536Inst Instance=new A021536Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021537
{
public static readonly long[] Value={ 0L,0L,1L,8L,7L,6L,1L,7L,2L,6L,0L,7L,8L,7L,9L,9L,2L,4L,9L,5L,3L,0L,9L,5L,6L,8L,4L,8L,0L,3L,0L,0L,1L,8L,7L,6L,1L,7L,2L,6L,0L,7L,8L,7L,9L,9L,2L,4L,9L,5L,3L,0L,9L,5L,6L,8L,4L,8L,0L,3L,0L,0L,1L,8L,7L,6L,1L,7L,2L,6L,0L,7L,8L,7L,9L,9L,2L,4L,9L,5L,3L,0L,9L,5L,6L,8L,4L,8L,0L,3L,0L,0L,1L,8L,7L,6L,1L,7L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021537Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021537.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021537Inst : IEnumerable<long>
{
public static readonly long[] Value=A021537.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021537.Bytes);
public long this[int i]=>Value[i];

public static A021537Inst Instance=new A021537Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021538
{
public static readonly long[] Value={ 0L,0L,1L,8L,7L,2L,6L,5L,9L,1L,7L,6L,0L,2L,9L,9L,6L,2L,5L,4L,6L,8L,1L,6L,4L,7L,9L,4L,0L,0L,7L,4L,9L,0L,6L,3L,6L,7L,0L,4L,1L,1L,9L,8L,5L,0L,1L,8L,7L,2L,6L,5L,9L,1L,7L,6L,0L,2L,9L,9L,6L,2L,5L,4L,6L,8L,1L,6L,4L,7L,9L,4L,0L,0L,7L,4L,9L,0L,6L,3L,6L,7L,0L,4L,1L,1L,9L,8L,5L,0L,1L,8L,7L,2L,6L,5L,9L,1L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021538Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021538.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021538Inst : IEnumerable<long>
{
public static readonly long[] Value=A021538.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021538.Bytes);
public long this[int i]=>Value[i];

public static A021538Inst Instance=new A021538Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021539
{
public static readonly long[] Value={ 0L,0L,1L,8L,6L,9L,1L,5L,8L,8L,7L,8L,5L,0L,4L,6L,7L,2L,8L,9L,7L,1L,9L,6L,2L,6L,1L,6L,8L,2L,2L,4L,2L,9L,9L,0L,6L,5L,4L,2L,0L,5L,6L,0L,7L,4L,7L,6L,6L,3L,5L,5L,1L,4L,0L,1L,8L,6L,9L,1L,5L,8L,8L,7L,8L,5L,0L,4L,6L,7L,2L,8L,9L,7L,1L,9L,6L,2L,6L,1L,6L,8L,2L,2L,4L,2L,9L,9L,0L,6L,5L,4L,2L,0L,5L,6L,0L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021539Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021539.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021539Inst : IEnumerable<long>
{
public static readonly long[] Value=A021539.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021539.Bytes);
public long this[int i]=>Value[i];

public static A021539Inst Instance=new A021539Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021540
{
public static readonly long[] Value={ 0L,0L,1L,8L,6L,5L,6L,7L,1L,6L,4L,1L,7L,9L,1L,0L,4L,4L,7L,7L,6L,1L,1L,9L,4L,0L,2L,9L,8L,5L,0L,7L,4L,6L,2L,6L,8L,6L,5L,6L,7L,1L,6L,4L,1L,7L,9L,1L,0L,4L,4L,7L,7L,6L,1L,1L,9L,4L,0L,2L,9L,8L,5L,0L,7L,4L,6L,2L,6L,8L,6L,5L,6L,7L,1L,6L,4L,1L,7L,9L,1L,0L,4L,4L,7L,7L,6L,1L,1L,9L,4L,0L,2L,9L,8L,5L,0L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021540Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021540.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021540Inst : IEnumerable<long>
{
public static readonly long[] Value=A021540.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021540.Bytes);
public long this[int i]=>Value[i];

public static A021540Inst Instance=new A021540Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021541
{
public static readonly long[] Value={ 0L,0L,1L,8L,6L,2L,1L,9L,7L,3L,9L,2L,9L,2L,3L,6L,4L,9L,9L,0L,6L,8L,9L,0L,1L,3L,0L,3L,5L,3L,8L,1L,7L,5L,0L,4L,6L,5L,5L,4L,9L,3L,4L,8L,2L,3L,0L,9L,1L,2L,4L,7L,6L,7L,2L,2L,5L,3L,2L,5L,8L,8L,4L,5L,4L,3L,7L,6L,1L,6L,3L,8L,7L,3L,3L,7L,0L,5L,7L,7L,2L,8L,1L,1L,9L,1L,8L,0L,6L,3L,3L,1L,4L,7L,1L,1L,3L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021541Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021541.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021541Inst : IEnumerable<long>
{
public static readonly long[] Value=A021541.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021541.Bytes);
public long this[int i]=>Value[i];

public static A021541Inst Instance=new A021541Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021542
{
public static readonly long[] Value={ 0L,0L,1L,8L,5L,8L,7L,3L,6L,0L,5L,9L,4L,7L,9L,5L,5L,3L,9L,0L,3L,3L,4L,5L,7L,2L,4L,9L,0L,7L,0L,6L,3L,1L,9L,7L,0L,2L,6L,0L,2L,2L,3L,0L,4L,8L,3L,2L,7L,1L,3L,7L,5L,4L,6L,4L,6L,8L,4L,0L,1L,4L,8L,6L,9L,8L,8L,8L,4L,7L,5L,8L,3L,6L,4L,3L,1L,2L,2L,6L,7L,6L,5L,7L,9L,9L,2L,5L,6L,5L,0L,5L,5L,7L,6L,2L,0L,8L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021542Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021542.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021542Inst : IEnumerable<long>
{
public static readonly long[] Value=A021542.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021542.Bytes);
public long this[int i]=>Value[i];

public static A021542Inst Instance=new A021542Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021543
{
public static readonly long[] Value={ 0L,0L,1L,8L,5L,5L,2L,8L,7L,5L,6L,9L,5L,7L,3L,2L,8L,3L,8L,5L,8L,9L,9L,8L,1L,4L,4L,7L,1L,2L,4L,3L,0L,4L,2L,6L,7L,1L,6L,1L,4L,1L,0L,0L,1L,8L,5L,5L,2L,8L,7L,5L,6L,9L,5L,7L,3L,2L,8L,3L,8L,5L,8L,9L,9L,8L,1L,4L,4L,7L,1L,2L,4L,3L,0L,4L,2L,6L,7L,1L,6L,1L,4L,1L,0L,0L,1L,8L,5L,5L,2L,8L,7L,5L,6L,9L,5L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021543Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021543.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021543Inst : IEnumerable<long>
{
public static readonly long[] Value=A021543.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021543.Bytes);
public long this[int i]=>Value[i];

public static A021543Inst Instance=new A021543Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021544
{
public static readonly long[] Value={ 1L,19L,242L,2606L,25659L,239313L,2153884L,18910012L,163042517L,1386706607L,11670306726L,97399296618L,807453069775L,6657437827501L,54644202679568L,446846543376824L,3642622865166633L,29615936742107595L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021544Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021544.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021544Inst : IEnumerable<long>
{
public static readonly long[] Value=A021544.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021544.Bytes);
public long this[int i]=>Value[i];

public static A021544Inst Instance=new A021544Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021545
{
public static readonly long[] Value={ 0L,0L,1L,8L,4L,8L,4L,2L,8L,8L,3L,5L,4L,8L,9L,8L,3L,3L,6L,4L,1L,4L,0L,4L,8L,0L,5L,9L,1L,4L,9L,7L,2L,2L,7L,3L,5L,6L,7L,4L,6L,7L,6L,5L,2L,4L,9L,5L,3L,7L,8L,9L,2L,7L,9L,1L,1L,2L,7L,5L,4L,1L,5L,8L,9L,6L,4L,8L,7L,9L,8L,5L,2L,1L,2L,5L,6L,9L,3L,1L,6L,0L,8L,1L,3L,3L,0L,8L,6L,8L,7L,6L,1L,5L,5L,2L,6L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021545Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021545.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021545Inst : IEnumerable<long>
{
public static readonly long[] Value=A021545.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021545.Bytes);
public long this[int i]=>Value[i];

public static A021545Inst Instance=new A021545Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021546
{
public static readonly long[] Value={ 0L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L,4L,5L,0L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021546Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021546.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021546Inst : IEnumerable<long>
{
public static readonly long[] Value=A021546.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021546.Bytes);
public long this[int i]=>Value[i];

public static A021546Inst Instance=new A021546Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021547
{
public static readonly long[] Value={ 0L,0L,1L,8L,4L,1L,6L,2L,0L,6L,2L,6L,1L,5L,1L,0L,1L,2L,8L,9L,1L,3L,4L,4L,3L,8L,3L,0L,5L,7L,0L,9L,0L,2L,3L,9L,4L,1L,0L,6L,8L,1L,3L,9L,9L,6L,3L,1L,6L,7L,5L,8L,7L,4L,7L,6L,9L,7L,9L,7L,4L,2L,1L,7L,3L,1L,1L,2L,3L,3L,8L,8L,5L,8L,1L,9L,5L,2L,1L,1L,7L,8L,6L,3L,7L,2L,0L,0L,7L,3L,6L,6L,4L,8L,2L,5L,0L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021547Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021547.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021547Inst : IEnumerable<long>
{
public static readonly long[] Value=A021547.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021547.Bytes);
public long this[int i]=>Value[i];

public static A021547Inst Instance=new A021547Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021548
{
public static readonly long[] Value={ 0L,0L,1L,8L,3L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L,5L,8L,8L,2L,3L,5L,2L,9L,4L,1L,1L,7L,6L,4L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021548Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021548.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021548Inst : IEnumerable<long>
{
public static readonly long[] Value=A021548.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021548.Bytes);
public long this[int i]=>Value[i];

public static A021548Inst Instance=new A021548Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021549
{
public static readonly long[] Value={ 0L,0L,1L,8L,3L,4L,8L,6L,2L,3L,8L,5L,3L,2L,1L,1L,0L,0L,9L,1L,7L,4L,3L,1L,1L,9L,2L,6L,6L,0L,5L,5L,0L,4L,5L,8L,7L,1L,5L,5L,9L,6L,3L,3L,0L,2L,7L,5L,2L,2L,9L,3L,5L,7L,7L,9L,8L,1L,6L,5L,1L,3L,7L,6L,1L,4L,6L,7L,8L,8L,9L,9L,0L,8L,2L,5L,6L,8L,8L,0L,7L,3L,3L,9L,4L,4L,9L,5L,4L,1L,2L,8L,4L,4L,0L,3L,6L,6L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021549Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021549.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021549Inst : IEnumerable<long>
{
public static readonly long[] Value=A021549.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021549.Bytes);
public long this[int i]=>Value[i];

public static A021549Inst Instance=new A021549Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021566
{
public static readonly long[] Value={ 0L,0L,1L,7L,7L,9L,3L,5L,9L,4L,3L,0L,6L,0L,4L,9L,8L,2L,2L,0L,6L,4L,0L,5L,6L,9L,3L,9L,5L,0L,1L,7L,7L,9L,3L,5L,9L,4L,3L,0L,6L,0L,4L,9L,8L,2L,2L,0L,6L,4L,0L,5L,6L,9L,3L,9L,5L,0L,1L,7L,7L,9L,3L,5L,9L,4L,3L,0L,6L,0L,4L,9L,8L,2L,2L,0L,6L,4L,0L,5L,6L,9L,3L,9L,5L,0L,1L,7L,7L,9L,3L,5L,9L,4L,3L,0L,6L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021566Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021566.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021566Inst : IEnumerable<long>
{
public static readonly long[] Value=A021566.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021566.Bytes);
public long this[int i]=>Value[i];

public static A021566Inst Instance=new A021566Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021567
{
public static readonly long[] Value={ 0L,0L,1L,7L,7L,6L,1L,9L,8L,9L,3L,4L,2L,8L,0L,6L,3L,9L,4L,3L,1L,6L,1L,6L,3L,4L,1L,0L,3L,0L,1L,9L,5L,3L,8L,1L,8L,8L,2L,7L,7L,0L,8L,7L,0L,3L,3L,7L,4L,7L,7L,7L,9L,7L,5L,1L,3L,3L,2L,1L,4L,9L,2L,0L,0L,7L,1L,0L,4L,7L,9L,5L,7L,3L,7L,1L,2L,2L,5L,5L,7L,7L,2L,6L,4L,6L,5L,3L,6L,4L,1L,2L,0L,7L,8L,1L,5L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021567Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021567.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021567Inst : IEnumerable<long>
{
public static readonly long[] Value=A021567.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021567.Bytes);
public long this[int i]=>Value[i];

public static A021567Inst Instance=new A021567Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021568
{
public static readonly long[] Value={ 0L,0L,1L,7L,7L,3L,0L,4L,9L,6L,4L,5L,3L,9L,0L,0L,7L,0L,9L,2L,1L,9L,8L,5L,8L,1L,5L,6L,0L,2L,8L,3L,6L,8L,7L,9L,4L,3L,2L,6L,2L,4L,1L,1L,3L,4L,7L,5L,1L,7L,7L,3L,0L,4L,9L,6L,4L,5L,3L,9L,0L,0L,7L,0L,9L,2L,1L,9L,8L,5L,8L,1L,5L,6L,0L,2L,8L,3L,6L,8L,7L,9L,4L,3L,2L,6L,2L,4L,1L,1L,3L,4L,7L,5L,1L,7L,7L,3L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021568Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021568.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021568Inst : IEnumerable<long>
{
public static readonly long[] Value=A021568.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021568.Bytes);
public long this[int i]=>Value[i];

public static A021568Inst Instance=new A021568Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021569
{
public static readonly long[] Value={ 0L,0L,1L,7L,6L,9L,9L,1L,1L,5L,0L,4L,4L,2L,4L,7L,7L,8L,7L,6L,1L,0L,6L,1L,9L,4L,6L,9L,0L,2L,6L,5L,4L,8L,6L,7L,2L,5L,6L,6L,3L,7L,1L,6L,8L,1L,4L,1L,5L,9L,2L,9L,2L,0L,3L,5L,3L,9L,8L,2L,3L,0L,0L,8L,8L,4L,9L,5L,5L,7L,5L,2L,2L,1L,2L,3L,8L,9L,3L,8L,0L,5L,3L,0L,9L,7L,3L,4L,5L,1L,3L,2L,7L,4L,3L,3L,6L,2L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021569Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021569.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021569Inst : IEnumerable<long>
{
public static readonly long[] Value=A021569.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021569.Bytes);
public long this[int i]=>Value[i];

public static A021569Inst Instance=new A021569Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021570
{
public static readonly long[] Value={ 0L,0L,1L,7L,6L,6L,7L,8L,4L,4L,5L,2L,2L,9L,6L,8L,1L,9L,7L,8L,7L,9L,8L,5L,8L,6L,5L,7L,2L,4L,3L,8L,1L,6L,2L,5L,4L,4L,1L,6L,9L,6L,1L,1L,3L,0L,7L,4L,2L,0L,4L,9L,4L,6L,9L,9L,6L,4L,6L,6L,4L,3L,1L,0L,9L,5L,4L,0L,6L,3L,6L,0L,4L,2L,4L,0L,2L,8L,2L,6L,8L,5L,5L,1L,2L,3L,6L,7L,4L,9L,1L,1L,6L,6L,0L,7L,7L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021570Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021570.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021570Inst : IEnumerable<long>
{
public static readonly long[] Value=A021570.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021570.Bytes);
public long this[int i]=>Value[i];

public static A021570Inst Instance=new A021570Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021571
{
public static readonly long[] Value={ 0L,0L,1L,7L,6L,3L,6L,6L,8L,4L,3L,0L,3L,3L,5L,0L,9L,7L,0L,0L,1L,7L,6L,3L,6L,6L,8L,4L,3L,0L,3L,3L,5L,0L,9L,7L,0L,0L,1L,7L,6L,3L,6L,6L,8L,4L,3L,0L,3L,3L,5L,0L,9L,7L,0L,0L,1L,7L,6L,3L,6L,6L,8L,4L,3L,0L,3L,3L,5L,0L,9L,7L,0L,0L,1L,7L,6L,3L,6L,6L,8L,4L,3L,0L,3L,3L,5L,0L,9L,7L,0L,0L,1L,7L,6L,3L,6L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021571Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021571.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021571Inst : IEnumerable<long>
{
public static readonly long[] Value=A021571.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021571.Bytes);
public long this[int i]=>Value[i];

public static A021571Inst Instance=new A021571Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021572
{
public static readonly long[] Value={ 0L,0L,1L,7L,6L,0L,5L,6L,3L,3L,8L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L,2L,5L,3L,5L,2L,1L,1L,2L,6L,7L,6L,0L,5L,6L,3L,3L,8L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L,2L,5L,3L,5L,2L,1L,1L,2L,6L,7L,6L,0L,5L,6L,3L,3L,8L,0L,2L,8L,1L,6L,9L,0L,1L,4L,0L,8L,4L,5L,0L,7L,0L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021572Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021572.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021572Inst : IEnumerable<long>
{
public static readonly long[] Value=A021572.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021572.Bytes);
public long this[int i]=>Value[i];

public static A021572Inst Instance=new A021572Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021573
{
public static readonly long[] Value={ 0L,0L,1L,7L,5L,7L,4L,6L,9L,2L,4L,4L,2L,8L,8L,2L,2L,4L,9L,5L,6L,0L,6L,3L,2L,6L,8L,8L,9L,2L,7L,9L,4L,3L,7L,6L,0L,9L,8L,4L,1L,8L,2L,7L,7L,6L,8L,0L,1L,4L,0L,5L,9L,7L,5L,3L,9L,5L,4L,3L,0L,5L,7L,9L,9L,6L,4L,8L,5L,0L,6L,1L,5L,1L,1L,4L,2L,3L,5L,5L,0L,0L,8L,7L,8L,7L,3L,4L,6L,2L,2L,1L,4L,4L,1L,1L,2L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021573Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021573.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021573Inst : IEnumerable<long>
{
public static readonly long[] Value=A021573.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021573.Bytes);
public long this[int i]=>Value[i];

public static A021573Inst Instance=new A021573Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021574
{
public static readonly long[] Value={ 0L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L,9L,6L,4L,9L,1L,2L,2L,8L,0L,7L,0L,1L,7L,5L,4L,3L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021574Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021574.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021574Inst : IEnumerable<long>
{
public static readonly long[] Value=A021574.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021574.Bytes);
public long this[int i]=>Value[i];

public static A021574Inst Instance=new A021574Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021575
{
public static readonly long[] Value={ 0L,0L,1L,7L,5L,1L,3L,1L,3L,4L,8L,5L,1L,1L,3L,8L,3L,5L,3L,7L,6L,5L,3L,2L,3L,9L,9L,2L,9L,9L,4L,7L,4L,6L,0L,5L,9L,5L,4L,4L,6L,5L,8L,4L,9L,3L,8L,7L,0L,4L,0L,2L,8L,0L,2L,1L,0L,1L,5L,7L,6L,1L,8L,2L,1L,3L,6L,6L,0L,2L,4L,5L,1L,8L,3L,8L,8L,7L,9L,1L,5L,9L,3L,6L,9L,5L,2L,7L,1L,4L,5L,3L,5L,9L,0L,1L,9L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021575Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021575.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021575Inst : IEnumerable<long>
{
public static readonly long[] Value=A021575.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021575.Bytes);
public long this[int i]=>Value[i];

public static A021575Inst Instance=new A021575Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A021576
{
public static readonly long[] Value={ 0L,0L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L,7L,4L,8L,2L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A021576Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A021576.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A021576Inst : IEnumerable<long>
{
public static readonly long[] Value=A021576.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A021576.Bytes);
public long this[int i]=>Value[i];

public static A021576Inst Instance=new A021576Inst();

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