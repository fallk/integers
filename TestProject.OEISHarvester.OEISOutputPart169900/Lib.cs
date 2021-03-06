using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A200357
{
public static readonly long[] Value={ 1L,4L,8L,8L,8L,2L,3L,9L,3L,2L,0L,0L,4L,9L,5L,7L,6L,8L,9L,0L,1L,1L,0L,2L,5L,6L,8L,5L,3L,8L,5L,4L,4L,3L,7L,5L,7L,9L,3L,0L,7L,0L,5L,3L,2L,8L,0L,6L,8L,3L,5L,6L,9L,4L,3L,3L,1L,2L,5L,1L,0L,6L,7L,6L,4L,3L,4L,7L,5L,1L,8L,9L,6L,9L,5L,9L,6L,9L,1L,2L,0L,1L,4L,1L,8L,5L,6L,7L,1L,2L,7L,9L,4L,3L,3L,2L,9L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200357Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200357.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200357Inst : IEnumerable<long>
{
public static readonly long[] Value=A200357.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200357.Bytes);
public long this[int i]=>Value[i];

public static A200357Inst Instance=new A200357Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200358
{
public static readonly long[] Value={ 1L,3L,6L,1L,4L,6L,7L,2L,4L,9L,5L,0L,1L,4L,4L,4L,1L,9L,9L,9L,3L,0L,0L,0L,6L,1L,9L,6L,1L,1L,0L,2L,7L,3L,6L,2L,6L,7L,7L,8L,0L,5L,2L,7L,5L,9L,7L,8L,6L,3L,1L,1L,0L,8L,0L,5L,8L,1L,0L,9L,7L,6L,1L,3L,2L,7L,2L,1L,7L,8L,4L,3L,2L,8L,7L,4L,1L,6L,7L,8L,4L,8L,7L,2L,9L,0L,4L,9L,9L,4L,1L,3L,5L,5L,7L,9L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200358Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200358.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200358Inst : IEnumerable<long>
{
public static readonly long[] Value=A200358.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200358.Bytes);
public long this[int i]=>Value[i];

public static A200358Inst Instance=new A200358Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200359
{
public static readonly long[] Value={ 1L,4L,3L,0L,7L,5L,7L,4L,5L,7L,5L,9L,3L,5L,3L,5L,4L,4L,3L,5L,1L,5L,4L,9L,3L,9L,2L,8L,4L,7L,3L,2L,3L,8L,6L,5L,9L,6L,4L,0L,0L,4L,5L,0L,5L,7L,9L,1L,8L,9L,4L,7L,0L,8L,8L,2L,0L,0L,6L,2L,1L,2L,1L,0L,5L,6L,7L,2L,3L,6L,7L,5L,6L,1L,2L,1L,2L,3L,8L,9L,2L,7L,4L,3L,3L,6L,7L,2L,9L,7L,3L,2L,5L,8L,9L,1L,4L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200359Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200359.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200359Inst : IEnumerable<long>
{
public static readonly long[] Value=A200359.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200359.Bytes);
public long this[int i]=>Value[i];

public static A200359Inst Instance=new A200359Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200360
{
public static readonly long[] Value={ 1L,4L,1L,6L,4L,9L,7L,8L,3L,4L,1L,7L,8L,0L,0L,1L,3L,0L,2L,3L,8L,7L,9L,2L,6L,6L,8L,6L,2L,7L,1L,0L,0L,2L,9L,1L,7L,7L,9L,8L,4L,0L,3L,9L,5L,7L,6L,9L,1L,4L,6L,0L,4L,0L,7L,0L,7L,5L,6L,3L,9L,8L,0L,6L,1L,4L,9L,1L,8L,4L,9L,2L,3L,4L,8L,3L,5L,0L,6L,8L,1L,8L,1L,1L,8L,6L,3L,0L,6L,2L,7L,1L,5L,4L,5L,0L,0L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200360Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200360.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200360Inst : IEnumerable<long>
{
public static readonly long[] Value=A200360.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200360.Bytes);
public long this[int i]=>Value[i];

public static A200360Inst Instance=new A200360Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200361
{
public static readonly long[] Value={ 1L,4L,3L,9L,7L,1L,8L,2L,0L,2L,0L,7L,1L,9L,7L,6L,6L,7L,0L,3L,4L,9L,2L,6L,1L,3L,2L,4L,1L,4L,8L,3L,7L,8L,3L,0L,3L,1L,3L,0L,6L,8L,9L,2L,4L,3L,4L,3L,9L,0L,6L,3L,8L,8L,5L,0L,1L,4L,9L,4L,8L,3L,8L,0L,2L,3L,3L,0L,8L,5L,6L,3L,8L,1L,3L,0L,7L,3L,2L,6L,5L,2L,7L,4L,9L,4L,5L,2L,3L,1L,3L,5L,5L,7L,2L,8L,1L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200361Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200361.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200361Inst : IEnumerable<long>
{
public static readonly long[] Value=A200361.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200361.Bytes);
public long this[int i]=>Value[i];

public static A200361Inst Instance=new A200361Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200362
{
public static readonly long[] Value={ 1L,4L,5L,6L,3L,3L,1L,7L,0L,8L,0L,7L,6L,4L,7L,2L,5L,7L,5L,3L,6L,8L,8L,1L,7L,2L,2L,2L,8L,7L,3L,1L,2L,7L,2L,6L,8L,5L,3L,0L,9L,6L,3L,8L,8L,0L,7L,4L,3L,2L,6L,4L,9L,5L,7L,4L,5L,2L,9L,8L,4L,1L,6L,2L,9L,3L,6L,6L,9L,3L,2L,1L,4L,6L,6L,9L,9L,1L,9L,4L,5L,4L,9L,2L,6L,4L,7L,7L,7L,9L,0L,1L,5L,0L,6L,6L,4L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200362Inst : IEnumerable<long>
{
public static readonly long[] Value=A200362.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200362.Bytes);
public long this[int i]=>Value[i];

public static A200362Inst Instance=new A200362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200363
{
public static readonly long[] Value={ 1L,4L,6L,8L,9L,4L,8L,1L,7L,5L,4L,0L,7L,9L,2L,8L,0L,9L,3L,8L,9L,8L,5L,1L,0L,4L,3L,0L,6L,7L,8L,4L,6L,8L,8L,2L,0L,6L,6L,9L,8L,8L,6L,2L,2L,9L,7L,8L,0L,3L,1L,9L,7L,5L,8L,5L,4L,1L,9L,3L,2L,9L,9L,7L,7L,0L,5L,9L,4L,5L,5L,1L,2L,9L,0L,6L,9L,4L,8L,9L,5L,3L,6L,1L,3L,1L,7L,8L,9L,9L,8L,2L,0L,9L,9L,0L,8L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200363Inst : IEnumerable<long>
{
public static readonly long[] Value=A200363.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200363.Bytes);
public long this[int i]=>Value[i];

public static A200363Inst Instance=new A200363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200364
{
public static readonly long[] Value={ 1L,4L,4L,7L,7L,7L,5L,5L,3L,8L,4L,2L,8L,4L,9L,3L,9L,8L,1L,4L,0L,8L,3L,9L,9L,1L,7L,2L,4L,7L,4L,7L,7L,9L,8L,3L,2L,8L,0L,6L,1L,6L,2L,9L,0L,9L,0L,3L,8L,3L,7L,3L,6L,7L,1L,7L,4L,0L,7L,6L,9L,3L,6L,8L,0L,8L,3L,4L,4L,3L,4L,3L,4L,5L,3L,2L,5L,0L,1L,7L,0L,3L,6L,0L,6L,6L,4L,0L,9L,6L,9L,6L,7L,1L,1L,7L,9L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200364Inst : IEnumerable<long>
{
public static readonly long[] Value=A200364.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200364.Bytes);
public long this[int i]=>Value[i];

public static A200364Inst Instance=new A200364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200365
{
public static readonly long[] Value={ 1L,4L,6L,3L,3L,5L,1L,5L,2L,6L,2L,3L,9L,0L,5L,7L,3L,0L,0L,7L,6L,6L,6L,7L,3L,2L,2L,4L,3L,4L,8L,1L,5L,4L,1L,3L,0L,6L,7L,5L,6L,6L,7L,3L,6L,6L,7L,6L,4L,1L,9L,4L,3L,8L,9L,7L,3L,4L,3L,8L,2L,4L,9L,0L,0L,5L,8L,3L,3L,5L,2L,0L,6L,6L,6L,8L,5L,2L,2L,6L,9L,8L,9L,0L,5L,7L,0L,4L,9L,3L,6L,0L,8L,4L,2L,4L,5L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200365Inst : IEnumerable<long>
{
public static readonly long[] Value=A200365.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200365.Bytes);
public long this[int i]=>Value[i];

public static A200365Inst Instance=new A200365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200366
{
public static readonly long[] Value={ 1L,4L,6L,8L,2L,3L,5L,9L,2L,7L,5L,2L,7L,7L,5L,3L,2L,5L,6L,6L,3L,4L,3L,7L,2L,4L,8L,9L,0L,7L,8L,3L,8L,4L,1L,0L,0L,4L,4L,2L,4L,2L,8L,7L,4L,9L,5L,6L,4L,3L,8L,6L,1L,5L,1L,9L,9L,5L,1L,1L,1L,2L,9L,6L,9L,6L,3L,8L,8L,5L,7L,9L,5L,6L,2L,2L,0L,1L,6L,9L,2L,1L,1L,6L,6L,3L,7L,5L,2L,3L,1L,6L,7L,9L,5L,4L,7L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200366Inst : IEnumerable<long>
{
public static readonly long[] Value=A200366.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200366.Bytes);
public long this[int i]=>Value[i];

public static A200366Inst Instance=new A200366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200367
{
public static readonly long[] Value={ 1L,4L,7L,8L,5L,3L,2L,5L,2L,2L,0L,1L,6L,5L,0L,1L,4L,9L,2L,4L,3L,4L,4L,0L,8L,0L,5L,0L,4L,0L,9L,0L,8L,4L,3L,5L,0L,7L,4L,8L,3L,3L,2L,7L,5L,6L,3L,8L,8L,4L,2L,8L,4L,6L,0L,5L,1L,2L,8L,2L,8L,0L,6L,6L,7L,4L,7L,5L,7L,9L,2L,2L,6L,8L,0L,2L,7L,3L,5L,9L,4L,9L,9L,9L,7L,8L,2L,2L,9L,2L,3L,3L,5L,5L,3L,5L,5L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200367Inst : IEnumerable<long>
{
public static readonly long[] Value=A200367.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200367.Bytes);
public long this[int i]=>Value[i];

public static A200367Inst Instance=new A200367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200368
{
public static readonly long[] Value={ 1L,4L,8L,6L,8L,3L,2L,1L,2L,2L,2L,3L,5L,9L,2L,9L,0L,1L,4L,2L,9L,7L,6L,8L,9L,5L,0L,9L,4L,5L,2L,1L,3L,4L,2L,4L,0L,1L,2L,6L,8L,2L,7L,6L,8L,9L,9L,9L,3L,8L,5L,6L,3L,5L,3L,4L,3L,9L,7L,2L,3L,4L,6L,8L,7L,4L,5L,0L,9L,6L,7L,7L,4L,0L,4L,0L,4L,4L,1L,6L,8L,0L,1L,6L,1L,4L,0L,3L,0L,1L,9L,1L,5L,7L,6L,0L,9L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200368Inst : IEnumerable<long>
{
public static readonly long[] Value=A200368.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200368.Bytes);
public long this[int i]=>Value[i];

public static A200368Inst Instance=new A200368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200369
{
public static readonly long[] Value={ 1L,4L,9L,3L,6L,8L,9L,3L,5L,7L,9L,7L,4L,3L,7L,2L,9L,4L,2L,9L,7L,8L,1L,6L,9L,6L,9L,5L,4L,7L,3L,7L,3L,3L,0L,2L,8L,3L,3L,2L,1L,0L,1L,0L,6L,2L,8L,0L,2L,3L,8L,1L,5L,0L,7L,2L,6L,6L,9L,8L,5L,6L,1L,1L,3L,6L,3L,0L,5L,5L,7L,0L,0L,7L,5L,9L,0L,0L,0L,0L,3L,2L,7L,3L,3L,4L,5L,8L,7L,5L,1L,7L,4L,5L,6L,4L,6L,1L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200369Inst : IEnumerable<long>
{
public static readonly long[] Value=A200369.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200369.Bytes);
public long this[int i]=>Value[i];

public static A200369Inst Instance=new A200369Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200370
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,7L,6L,5L,4L,3L,2L,1L,8L,7L,6L,5L,4L,3L,2L,1L,9L,10L,7L,6L,5L,4L,3L,2L,1L,10L,13L,8L,7L,6L,5L,4L,3L,2L,1L,11L,16L,11L,8L,7L,6L,5L,4L,3L,2L,1L,12L,19L,14L,9L,8L,7L,6L,5L,4L,3L,2L,1L,13L,22L,21L,12L,9L,8L,7L,6L,5L,4L,3L,2L,1L,14L,25L,28L,21L,10L,13L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200370Inst : IEnumerable<long>
{
public static readonly long[] Value=A200370.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200370.Bytes);
public long this[int i]=>Value[i];

public static A200370Inst Instance=new A200370Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200371
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,11L,14L,21L,28L,35L,42L,49L,60L,75L,90L,105L,120L,139L,162L,185L,208L,233L,262L,295L,328L,365L,402L,447L,492L,541L,590L,639L,692L,757L,822L,887L,952L,1027L,1102L,1185L,1268L,1355L,1450L,1549L,1648L,1751L,1858L,1973L,2092L,2219L,2346L,2473L,2608L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200371Inst : IEnumerable<long>
{
public static readonly long[] Value=A200371.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200371.Bytes);
public long this[int i]=>Value[i];

public static A200371Inst Instance=new A200371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200372
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,12L,21L,30L,39L,52L,65L,84L,107L,130L,155L,184L,221L,266L,323L,384L,447L,520L,605L,696L,803L,914L,1055L,1200L,1357L,1524L,1691L,1886L,2111L,2344L,2597L,2868L,3179L,3494L,3849L,4212L,4591L,5028L,5481L,5946L,6445L,6970L,7557L,8182L,8839L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200372Inst : IEnumerable<long>
{
public static readonly long[] Value=A200372.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200372.Bytes);
public long this[int i]=>Value[i];

public static A200372Inst Instance=new A200372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200373
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,9L,10L,15L,24L,39L,54L,69L,92L,117L,142L,171L,208L,267L,338L,447L,560L,687L,844L,1011L,1198L,1415L,1648L,1957L,2294L,2685L,3104L,3551L,4098L,4731L,5396L,6107L,6870L,7791L,8764L,9871L,11038L,12281L,13784L,15397L,17098L,18923L,20844L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200373Inst : IEnumerable<long>
{
public static readonly long[] Value=A200373.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200373.Bytes);
public long this[int i]=>Value[i];

public static A200373Inst Instance=new A200373Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200374
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,13L,18L,23L,30L,39L,48L,63L,82L,109L,142L,187L,236L,295L,380L,527L,682L,859L,1086L,1353L,1662L,2055L,2488L,3017L,3616L,4299L,5180L,6147L,7290L,8677L,10178L,11831L,13712L,15807L,18058L,20807L,23788L,27387L,31390L,35773L,40496L,45739L,51654L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200374Inst : IEnumerable<long>
{
public static readonly long[] Value=A200374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200374.Bytes);
public long this[int i]=>Value[i];

public static A200374Inst Instance=new A200374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200375
{
public static readonly ulong[] Value={ 1L,1L,6L,25L,154L,882L,5676L,36465L,244530L,1657942L,11471668L,80242890L,568080772L,4056976900L,29212908120L,211783889025L,1544811959970L,11328491394990L,83473572128100L,617702666484750L,4588654943721420L,34206312386929020L,255803818897858920L,1918528298674328250L,14427334095935095764UL };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200375Inst : IEnumerable<ulong>
{
public static readonly ulong[] Value=A200375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200375.Bytes);
public ulong this[int i]=>Value[i];

public static A200375Inst Instance=new A200375Inst();

public IEnumerator<ulong> GetEnumerator()
{
return (Value as IEnumerable<ulong>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200376
{
public static readonly long[] Value={ 1L,1L,5L,9L,37L,81L,301L,729L,2549L,6561L,22045L,59049L,193029L,531441L,1703469L,4782969L,15111573L,43046721L,134539837L,387420489L,1200901157L,3486784401L,10739313997L,31381059609L,96172251061L,282429536481L,862142190941L,2541865828329L,7734936371269L,22876792454961L,69439155241581L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200376Inst : IEnumerable<long>
{
public static readonly long[] Value=A200376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200376.Bytes);
public long this[int i]=>Value[i];

public static A200376Inst Instance=new A200376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200377
{
public static readonly long[] Value={ 1L,1L,2L,4L,7L,11L,19L,34L,61L,106L,181L,311L,543L,955L,1668L,2885L,4980L,8650L,15114L,26391L,45845L,79385L,137718L,239866L,418338L,727926L,1263097L,2191463L,3810775L,6638258L,11556361L,20078960L,34855400L,60567092L,105405431L,183483906L,319039355L,554158992L,962743619L,1674359119L,2913758685L,5068194691L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200377Inst : IEnumerable<long>
{
public static readonly long[] Value=A200377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200377.Bytes);
public long this[int i]=>Value[i];

public static A200377Inst Instance=new A200377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200378
{
public static readonly BigInteger[] Value={ 1L,6L,36L,222L,1446L,10116L,75924L,602256L,4958352L,41783046L,357442416L,3091766904L,26991194550L,237605649780L,2107693469880L,18826297197444L,169203629332230L,1529098507275372L,13885733651626548L,126641707880226888L,1159483975207373952L,10652962589325269040UL,BigInteger.Parse("98187525261135608400") };
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
public class A200378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200378Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200378.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200378Inst Instance=new A200378Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200379
{
public static readonly long[] Value={ 2L,6L,17L,47L,121L,291L,665L,1467L,3162L,6718L,14156L,29702L,62190L,130060L,271760L,567488L,1184917L,2475907L,5181798L,10869647L,22858188L,48178441L,101712259L,214900119L,454006064L,958316150L,2019797853L,4248758319L,8917387482L,18670242203L,38989676130L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200379Inst : IEnumerable<long>
{
public static readonly long[] Value=A200379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200379.Bytes);
public long this[int i]=>Value[i];

public static A200379Inst Instance=new A200379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200380
{
public static readonly long[] Value={ 1L,1L,3L,6L,21L,51L,201L,498L,2241L,4581L,26991L,17766L,359613L,-995409L,6968781L,-53627454L,259953921L,-2292378327L,13839388731L,-108459180954L,809434284741L,-6158416812309L,50614251147153L,-407335408369614L,3478999597913601L,-30042633320442099L,266107969086122151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200380Inst : IEnumerable<long>
{
public static readonly long[] Value=A200380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200380.Bytes);
public long this[int i]=>Value[i];

public static A200380Inst Instance=new A200380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200381
{
public static readonly long[] Value={ 1L,2L,3L,4L,6L,7L,8L,9L,11L,12L,14L,16L,18L,21L,22L,24L,27L,28L,29L,32L,33L,36L,42L,44L,47L,48L,49L,54L,56L,58L,63L,64L,66L,72L,76L,77L,81L,84L,87L,88L,94L,96L,98L,99L,108L,112L,116L,121L,123L,126L,128L,132L,141L,144L,147L,152L,154L,162L,168L,174L,176L,188L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200381Inst : IEnumerable<long>
{
public static readonly long[] Value=A200381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200381.Bytes);
public long this[int i]=>Value[i];

public static A200381Inst Instance=new A200381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200382
{
public static readonly long[] Value={ 1L,4L,8L,2L,7L,4L,8L,3L,4L,0L,4L,1L,3L,3L,0L,7L,1L,4L,3L,2L,2L,9L,5L,6L,8L,8L,1L,2L,8L,3L,3L,3L,9L,6L,7L,9L,2L,0L,7L,9L,3L,2L,5L,6L,8L,4L,4L,8L,1L,8L,3L,8L,9L,8L,2L,1L,7L,7L,2L,5L,0L,5L,2L,7L,9L,4L,9L,5L,8L,9L,2L,2L,9L,6L,4L,6L,9L,1L,8L,0L,6L,3L,0L,9L,1L,1L,5L,0L,0L,1L,4L,0L,8L,9L,7L,7L,6L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200382Inst : IEnumerable<long>
{
public static readonly long[] Value=A200382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200382.Bytes);
public long this[int i]=>Value[i];

public static A200382Inst Instance=new A200382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200383
{
public static readonly long[] Value={ 1L,4L,9L,6L,6L,7L,5L,5L,4L,8L,7L,8L,8L,8L,1L,6L,0L,6L,9L,0L,1L,6L,4L,1L,8L,4L,4L,9L,3L,8L,9L,0L,0L,6L,7L,1L,4L,5L,8L,7L,6L,7L,0L,2L,3L,6L,1L,7L,3L,6L,8L,9L,3L,4L,6L,9L,9L,5L,0L,2L,2L,3L,1L,8L,8L,4L,1L,2L,6L,4L,6L,0L,3L,6L,4L,6L,9L,5L,9L,0L,1L,5L,3L,4L,9L,3L,9L,5L,8L,2L,3L,8L,1L,2L,6L,8L,2L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200383Inst : IEnumerable<long>
{
public static readonly long[] Value=A200383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200383.Bytes);
public long this[int i]=>Value[i];

public static A200383Inst Instance=new A200383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200384
{
public static readonly long[] Value={ 1L,4L,3L,1L,8L,4L,8L,5L,0L,2L,0L,9L,5L,6L,7L,6L,3L,8L,7L,7L,0L,5L,6L,4L,7L,3L,7L,0L,3L,7L,4L,7L,3L,6L,2L,7L,9L,0L,3L,3L,1L,5L,0L,9L,1L,9L,3L,2L,0L,4L,2L,2L,9L,0L,3L,1L,1L,1L,1L,0L,9L,3L,2L,1L,9L,4L,7L,3L,9L,8L,3L,7L,0L,8L,2L,7L,1L,7L,5L,2L,8L,4L,1L,0L,7L,3L,9L,5L,1L,9L,7L,0L,3L,3L,8L,2L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200384Inst : IEnumerable<long>
{
public static readonly long[] Value=A200384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200384.Bytes);
public long this[int i]=>Value[i];

public static A200384Inst Instance=new A200384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200385
{
public static readonly long[] Value={ 1L,4L,5L,1L,1L,4L,1L,2L,5L,8L,9L,1L,5L,4L,6L,0L,1L,9L,8L,2L,1L,9L,8L,7L,5L,6L,5L,7L,5L,7L,1L,4L,4L,5L,2L,9L,8L,6L,6L,6L,4L,9L,2L,7L,9L,4L,9L,2L,3L,8L,7L,5L,0L,5L,0L,9L,5L,8L,9L,5L,1L,4L,8L,9L,7L,2L,0L,1L,4L,2L,1L,1L,5L,1L,1L,1L,9L,9L,6L,0L,0L,9L,1L,6L,7L,2L,0L,6L,1L,1L,7L,0L,3L,4L,3L,6L,7L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200385Inst : IEnumerable<long>
{
public static readonly long[] Value=A200385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200385.Bytes);
public long this[int i]=>Value[i];

public static A200385Inst Instance=new A200385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200386
{
public static readonly long[] Value={ 1L,4L,7L,6L,1L,7L,8L,8L,3L,0L,6L,4L,3L,9L,0L,2L,3L,9L,9L,8L,9L,9L,2L,5L,6L,9L,1L,7L,2L,9L,9L,8L,3L,3L,2L,0L,3L,3L,6L,9L,0L,0L,6L,1L,2L,6L,5L,0L,3L,4L,3L,1L,4L,4L,0L,1L,2L,5L,6L,9L,9L,6L,4L,2L,4L,6L,4L,6L,9L,4L,3L,2L,8L,2L,6L,8L,8L,8L,3L,1L,2L,5L,3L,3L,4L,4L,8L,5L,8L,7L,0L,6L,5L,4L,7L,1L,1L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200386Inst : IEnumerable<long>
{
public static readonly long[] Value=A200386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200386.Bytes);
public long this[int i]=>Value[i];

public static A200386Inst Instance=new A200386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200387
{
public static readonly long[] Value={ 1L,4L,5L,8L,1L,0L,6L,6L,4L,1L,5L,9L,8L,3L,3L,2L,8L,4L,5L,9L,7L,3L,6L,8L,0L,6L,2L,6L,6L,1L,4L,5L,1L,9L,4L,7L,2L,5L,8L,4L,0L,6L,7L,6L,4L,9L,5L,0L,5L,2L,9L,3L,7L,8L,5L,0L,8L,4L,3L,9L,5L,3L,5L,2L,0L,7L,2L,9L,8L,1L,4L,4L,4L,4L,2L,6L,8L,2L,2L,0L,5L,8L,1L,2L,3L,3L,9L,5L,1L,1L,5L,4L,5L,9L,1L,7L,5L,4L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200387Inst : IEnumerable<long>
{
public static readonly long[] Value=A200387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200387.Bytes);
public long this[int i]=>Value[i];

public static A200387Inst Instance=new A200387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200388
{
public static readonly long[] Value={ 1L,4L,7L,0L,7L,2L,8L,6L,3L,0L,2L,9L,4L,4L,6L,0L,1L,5L,8L,2L,9L,8L,9L,3L,6L,8L,6L,5L,6L,5L,6L,5L,0L,8L,6L,5L,6L,3L,8L,0L,9L,0L,6L,8L,2L,1L,6L,1L,9L,1L,1L,7L,3L,9L,7L,6L,4L,9L,7L,3L,2L,2L,2L,0L,6L,3L,5L,6L,6L,0L,6L,0L,1L,6L,1L,4L,1L,7L,7L,2L,7L,1L,9L,1L,2L,2L,0L,7L,9L,3L,8L,5L,4L,7L,6L,8L,9L,0L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200388Inst : IEnumerable<long>
{
public static readonly long[] Value=A200388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200388.Bytes);
public long this[int i]=>Value[i];

public static A200388Inst Instance=new A200388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200389
{
public static readonly long[] Value={ 1L,4L,8L,0L,6L,0L,2L,5L,1L,2L,4L,7L,4L,4L,7L,4L,3L,9L,5L,5L,9L,4L,6L,4L,6L,8L,9L,4L,4L,0L,7L,1L,0L,1L,3L,1L,2L,4L,5L,6L,9L,9L,2L,0L,1L,2L,2L,3L,9L,5L,5L,9L,6L,4L,5L,9L,2L,6L,9L,8L,4L,5L,0L,6L,0L,6L,5L,4L,7L,9L,4L,2L,3L,7L,8L,7L,8L,9L,9L,9L,1L,5L,4L,4L,4L,0L,2L,1L,3L,9L,8L,8L,0L,9L,7L,0L,7L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200389Inst : IEnumerable<long>
{
public static readonly long[] Value=A200389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200389.Bytes);
public long this[int i]=>Value[i];

public static A200389Inst Instance=new A200389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200390
{
public static readonly long[] Value={ 1L,4L,8L,8L,5L,8L,4L,1L,5L,4L,5L,8L,6L,8L,7L,1L,3L,8L,9L,6L,6L,6L,1L,6L,4L,5L,2L,9L,2L,8L,9L,8L,6L,4L,0L,5L,2L,2L,8L,8L,2L,8L,9L,7L,0L,2L,0L,0L,9L,2L,0L,5L,3L,6L,2L,6L,6L,5L,7L,5L,7L,1L,7L,5L,6L,0L,5L,4L,2L,8L,6L,0L,1L,0L,2L,2L,3L,9L,3L,0L,6L,2L,6L,1L,9L,1L,7L,0L,8L,8L,2L,2L,4L,5L,6L,2L,8L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200390Inst : IEnumerable<long>
{
public static readonly long[] Value=A200390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200390.Bytes);
public long this[int i]=>Value[i];

public static A200390Inst Instance=new A200390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200391
{
public static readonly long[] Value={ 1L,4L,7L,5L,7L,0L,5L,3L,5L,7L,5L,3L,2L,5L,0L,0L,0L,9L,6L,5L,0L,5L,4L,0L,5L,4L,8L,7L,2L,4L,5L,5L,3L,3L,3L,9L,5L,9L,5L,3L,2L,0L,1L,8L,2L,9L,2L,4L,3L,0L,6L,4L,3L,0L,3L,6L,4L,3L,6L,2L,5L,1L,1L,3L,0L,2L,8L,4L,2L,3L,4L,0L,4L,6L,3L,9L,0L,5L,9L,4L,8L,6L,1L,8L,2L,6L,6L,7L,2L,4L,3L,0L,1L,7L,5L,8L,0L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200391Inst : IEnumerable<long>
{
public static readonly long[] Value=A200391.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200391.Bytes);
public long this[int i]=>Value[i];

public static A200391Inst Instance=new A200391Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200392
{
public static readonly long[] Value={ 1L,4L,8L,4L,6L,6L,9L,5L,6L,8L,5L,7L,3L,0L,0L,5L,9L,7L,2L,5L,2L,7L,4L,3L,7L,0L,8L,4L,4L,7L,2L,8L,4L,8L,9L,6L,5L,7L,5L,4L,6L,9L,2L,6L,6L,3L,3L,9L,4L,6L,4L,6L,6L,1L,5L,8L,1L,3L,5L,2L,9L,6L,1L,0L,8L,1L,2L,3L,7L,3L,7L,9L,7L,1L,4L,9L,2L,7L,8L,2L,5L,7L,3L,5L,4L,5L,2L,2L,9L,9L,6L,1L,5L,8L,6L,6L,2L,9L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200392Inst : IEnumerable<long>
{
public static readonly long[] Value=A200392.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200392.Bytes);
public long this[int i]=>Value[i];

public static A200392Inst Instance=new A200392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200393
{
public static readonly long[] Value={ 1L,4L,9L,1L,9L,8L,3L,5L,2L,0L,9L,2L,6L,4L,9L,5L,2L,3L,9L,3L,0L,6L,6L,1L,7L,2L,0L,7L,4L,1L,3L,3L,6L,7L,5L,3L,7L,2L,1L,9L,0L,8L,9L,6L,9L,5L,5L,4L,8L,4L,2L,2L,9L,8L,5L,9L,6L,5L,8L,7L,4L,2L,9L,1L,5L,2L,9L,0L,5L,6L,2L,3L,2L,1L,7L,1L,2L,2L,6L,9L,2L,2L,9L,7L,8L,0L,3L,4L,6L,3L,9L,7L,5L,1L,4L,5L,8L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200393Inst : IEnumerable<long>
{
public static readonly long[] Value=A200393.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200393.Bytes);
public long this[int i]=>Value[i];

public static A200393Inst Instance=new A200393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200394
{
public static readonly long[] Value={ 1L,4L,9L,8L,0L,8L,5L,9L,8L,7L,2L,5L,6L,7L,2L,2L,2L,7L,8L,4L,6L,0L,3L,0L,0L,8L,9L,0L,4L,3L,0L,0L,9L,5L,0L,9L,7L,9L,5L,6L,4L,9L,2L,5L,3L,1L,8L,2L,1L,5L,6L,1L,4L,0L,5L,9L,1L,9L,3L,0L,2L,8L,2L,1L,0L,8L,6L,1L,8L,0L,5L,6L,8L,8L,3L,2L,5L,0L,0L,1L,8L,4L,5L,7L,5L,0L,9L,0L,5L,7L,9L,4L,1L,3L,7L,0L,9L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200394Inst : IEnumerable<long>
{
public static readonly long[] Value=A200394.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200394.Bytes);
public long this[int i]=>Value[i];

public static A200394Inst Instance=new A200394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200395
{
public static readonly long[] Value={ 1L,4L,8L,8L,4L,1L,6L,3L,4L,3L,2L,9L,7L,6L,7L,3L,1L,8L,7L,0L,2L,3L,8L,9L,2L,2L,2L,9L,5L,2L,0L,9L,0L,8L,2L,7L,8L,6L,2L,9L,4L,3L,4L,5L,2L,1L,0L,3L,5L,7L,7L,4L,2L,9L,6L,9L,5L,6L,2L,2L,9L,5L,0L,4L,0L,7L,8L,1L,1L,0L,6L,7L,3L,8L,2L,4L,8L,6L,6L,6L,4L,0L,5L,2L,7L,4L,5L,4L,3L,2L,0L,0L,7L,3L,6L,6L,4L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200395Inst : IEnumerable<long>
{
public static readonly long[] Value=A200395.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200395.Bytes);
public long this[int i]=>Value[i];

public static A200395Inst Instance=new A200395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200396
{
public static readonly long[] Value={ 1L,4L,9L,5L,1L,3L,5L,7L,9L,3L,1L,6L,6L,3L,0L,3L,3L,1L,0L,4L,2L,4L,5L,2L,2L,6L,6L,8L,8L,2L,5L,8L,1L,4L,8L,6L,2L,9L,2L,4L,0L,7L,2L,0L,5L,7L,6L,0L,8L,8L,2L,0L,8L,0L,0L,5L,1L,3L,6L,2L,6L,7L,0L,5L,2L,2L,5L,8L,5L,9L,2L,3L,9L,9L,0L,7L,4L,8L,8L,8L,6L,5L,5L,1L,9L,1L,3L,6L,7L,2L,7L,9L,5L,9L,3L,2L,3L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200396Inst : IEnumerable<long>
{
public static readonly long[] Value=A200396.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200396.Bytes);
public long this[int i]=>Value[i];

public static A200396Inst Instance=new A200396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200397
{
public static readonly long[] Value={ 1L,5L,0L,5L,6L,0L,3L,3L,3L,1L,8L,3L,8L,0L,2L,7L,2L,2L,5L,3L,2L,2L,1L,6L,6L,4L,4L,4L,5L,7L,7L,7L,4L,5L,8L,4L,6L,1L,2L,3L,8L,9L,4L,5L,8L,3L,9L,6L,1L,2L,7L,5L,5L,5L,5L,0L,8L,8L,8L,9L,1L,9L,9L,0L,1L,7L,9L,2L,7L,8L,1L,0L,2L,0L,9L,1L,0L,9L,4L,8L,7L,7L,0L,9L,3L,7L,3L,7L,4L,0L,4L,6L,6L,1L,8L,8L,5L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200397Inst : IEnumerable<long>
{
public static readonly long[] Value=A200397.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200397.Bytes);
public long this[int i]=>Value[i];

public static A200397Inst Instance=new A200397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200398
{
public static readonly long[] Value={ 1L,4L,9L,8L,0L,6L,4L,2L,9L,1L,2L,7L,5L,6L,5L,9L,0L,0L,4L,5L,8L,8L,3L,6L,1L,0L,9L,6L,0L,1L,5L,6L,5L,4L,8L,9L,8L,2L,8L,1L,4L,3L,3L,5L,2L,7L,9L,6L,3L,2L,3L,8L,1L,3L,3L,1L,4L,6L,9L,0L,7L,4L,4L,1L,4L,4L,1L,1L,5L,2L,5L,9L,7L,0L,3L,0L,3L,7L,2L,6L,4L,1L,3L,6L,0L,3L,6L,9L,7L,2L,2L,9L,3L,3L,3L,8L,5L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200398Inst : IEnumerable<long>
{
public static readonly long[] Value=A200398.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200398.Bytes);
public long this[int i]=>Value[i];

public static A200398Inst Instance=new A200398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200399
{
public static readonly long[] Value={ 1L,5L,0L,3L,2L,9L,9L,1L,1L,6L,2L,7L,0L,4L,4L,2L,7L,4L,8L,1L,2L,6L,7L,0L,9L,5L,7L,4L,6L,0L,0L,6L,9L,4L,2L,0L,8L,9L,5L,4L,4L,8L,8L,7L,4L,2L,0L,6L,4L,7L,0L,3L,8L,1L,7L,0L,9L,4L,4L,4L,3L,3L,4L,4L,3L,0L,9L,4L,8L,5L,1L,2L,3L,6L,1L,5L,3L,4L,8L,9L,0L,1L,8L,2L,2L,3L,4L,3L,5L,2L,0L,0L,4L,8L,0L,6L,4L,8L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200399Inst : IEnumerable<long>
{
public static readonly long[] Value=A200399.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200399.Bytes);
public long this[int i]=>Value[i];

public static A200399Inst Instance=new A200399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200400
{
public static readonly long[] Value={ 1L,5L,0L,7L,7L,9L,4L,3L,3L,8L,2L,6L,9L,8L,3L,5L,0L,8L,7L,3L,1L,4L,7L,5L,4L,2L,3L,6L,1L,0L,4L,3L,6L,2L,5L,9L,6L,0L,9L,0L,3L,3L,9L,9L,9L,1L,2L,1L,4L,9L,9L,9L,3L,2L,3L,9L,4L,9L,5L,8L,7L,7L,6L,1L,5L,7L,4L,0L,0L,8L,1L,3L,7L,6L,7L,9L,5L,1L,9L,1L,4L,3L,1L,4L,2L,7L,4L,5L,6L,4L,8L,1L,1L,6L,6L,5L,5L,3L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200400Inst : IEnumerable<long>
{
public static readonly long[] Value=A200400.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200400.Bytes);
public long this[int i]=>Value[i];

public static A200400Inst Instance=new A200400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200401
{
public static readonly long[] Value={ 1L,5L,1L,1L,7L,0L,2L,5L,1L,6L,4L,9L,5L,3L,8L,3L,6L,1L,8L,2L,4L,6L,3L,0L,3L,7L,3L,0L,2L,2L,1L,7L,7L,2L,8L,8L,4L,3L,0L,0L,9L,8L,4L,4L,0L,8L,3L,7L,2L,1L,3L,2L,9L,5L,3L,4L,1L,1L,3L,5L,6L,8L,5L,3L,7L,3L,3L,7L,4L,2L,1L,1L,9L,4L,6L,3L,6L,0L,4L,6L,5L,8L,1L,3L,6L,2L,2L,6L,8L,1L,9L,8L,9L,6L,8L,5L,4L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200401Inst : IEnumerable<long>
{
public static readonly long[] Value=A200401.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200401.Bytes);
public long this[int i]=>Value[i];

public static A200401Inst Instance=new A200401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200402
{
public static readonly long[] Value={ 1L,1L,-2L,-5L,24L,81L,-439L,-1590L,9144L,34451L,-206641L,-799196L,4936378L,19442800L,-122613798L,-489411508L,3134773097L,12640278932L,-81948641010L,-333099985517L,2180523864984L,8920922434686L,-58861487584914L,-242105281357185L,1608002839956522L,6643707274089977L,-44372373955131024L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200402Inst : IEnumerable<long>
{
public static readonly long[] Value=A200402.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200402.Bytes);
public long this[int i]=>Value[i];

public static A200402Inst Instance=new A200402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200403
{
public static readonly long[] Value={ 1L,2L,6L,23L,107L,584L,3660L,25910L,204564L,1782520L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200403Inst : IEnumerable<long>
{
public static readonly long[] Value=A200403.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200403.Bytes);
public long this[int i]=>Value[i];

public static A200403Inst Instance=new A200403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200404
{
public static readonly long[] Value={ 1L,2L,6L,23L,107L,582L,3622L,25369L,197523L,1692535L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200404Inst : IEnumerable<long>
{
public static readonly long[] Value=A200404.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200404.Bytes);
public long this[int i]=>Value[i];

public static A200404Inst Instance=new A200404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200405
{
public static readonly long[] Value={ 1L,2L,6L,23L,107L,583L,3637L,25548L,199506L,1714383L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200405Inst : IEnumerable<long>
{
public static readonly long[] Value=A200405.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200405.Bytes);
public long this[int i]=>Value[i];

public static A200405Inst Instance=new A200405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200406
{
public static readonly long[] Value={ 1L,2L,6L,23L,105L,550L,3228L,20878L,146994L,1116000L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200406Inst : IEnumerable<long>
{
public static readonly long[] Value=A200406.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200406.Bytes);
public long this[int i]=>Value[i];

public static A200406Inst Instance=new A200406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200407
{
public static readonly long[] Value={ 1L,9L,131L,209L,3051L,44539L,71059L,1037331L,15143129L,24159851L,352689489L,5148619321L,8214278281L,119913388929L,1750515426011L,2792830455689L,40770199546371L,595170096224419L,949554140655979L,13861747932377211L,202356082200876449L,322845614992577171L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200407Inst : IEnumerable<long>
{
public static readonly long[] Value=A200407.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200407.Bytes);
public long this[int i]=>Value[i];

public static A200407Inst Instance=new A200407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200408
{
public static readonly long[] Value={ 1L,16L,41L,121L,316L,841L,2201L,5776L,15121L,39601L,103676L,271441L,710641L,1860496L,4870841L,12752041L,33385276L,87403801L,228826121L,599074576L,1568397601L,4106118241L,10749957116L,28143753121L,73681302241L,192900153616L,505019158601L,1322157322201L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200408Inst : IEnumerable<long>
{
public static readonly long[] Value=A200408.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200408.Bytes);
public long this[int i]=>Value[i];

public static A200408Inst Instance=new A200408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200409
{
public static readonly long[] Value={ 1L,39L,571L,911L,13299L,194141L,309739L,4521621L,66007369L,105310349L,1537337841L,22442311319L,35805208921L,522690344319L,7630319841091L,12173665722791L,177713179730619L,2594286303659621L,4139010540540019L,60421958418066141L,882049712924430049L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200409Inst : IEnumerable<long>
{
public static readonly long[] Value=A200409.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200409.Bytes);
public long this[int i]=>Value[i];

public static A200409Inst Instance=new A200409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200410
{
public static readonly long[] Value={ 1L,4L,6L,7L,1L,0L,7L,0L,6L,7L,9L,4L,7L,8L,9L,4L,0L,0L,2L,3L,4L,3L,2L,4L,8L,3L,6L,3L,2L,3L,9L,3L,6L,5L,8L,0L,8L,2L,6L,6L,0L,9L,4L,3L,7L,9L,9L,7L,6L,0L,2L,3L,2L,3L,4L,2L,5L,2L,4L,8L,0L,9L,9L,2L,0L,7L,4L,3L,8L,3L,7L,5L,3L,0L,8L,5L,7L,7L,5L,7L,1L,5L,9L,5L,6L,5L,4L,2L,7L,7L,4L,9L,6L,7L,6L,5L,7L,5L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200410Inst : IEnumerable<long>
{
public static readonly long[] Value=A200410.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200410.Bytes);
public long this[int i]=>Value[i];

public static A200410Inst Instance=new A200410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200411
{
public static readonly long[] Value={ 1L,4L,8L,6L,5L,3L,0L,3L,9L,7L,4L,1L,1L,8L,9L,4L,6L,0L,3L,1L,2L,9L,2L,5L,5L,4L,9L,9L,4L,6L,4L,8L,6L,4L,9L,6L,0L,2L,7L,4L,1L,2L,7L,5L,3L,4L,5L,4L,6L,9L,2L,8L,9L,5L,5L,4L,4L,1L,3L,4L,6L,4L,6L,0L,5L,7L,6L,8L,8L,5L,2L,7L,6L,7L,6L,5L,6L,8L,0L,2L,5L,1L,1L,7L,6L,5L,9L,6L,0L,2L,2L,7L,2L,6L,9L,7L,9L,1L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200411Inst : IEnumerable<long>
{
public static readonly long[] Value=A200411.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200411.Bytes);
public long this[int i]=>Value[i];

public static A200411Inst Instance=new A200411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200412
{
public static readonly long[] Value={ 1L,4L,8L,2L,3L,0L,6L,6L,2L,7L,5L,7L,2L,3L,7L,6L,1L,1L,3L,9L,0L,7L,0L,5L,8L,9L,9L,3L,0L,2L,9L,1L,1L,5L,1L,1L,6L,9L,0L,1L,2L,4L,0L,8L,6L,0L,5L,5L,4L,6L,4L,8L,8L,3L,0L,4L,4L,9L,5L,5L,6L,8L,3L,0L,5L,7L,8L,1L,5L,9L,4L,9L,4L,9L,0L,3L,1L,1L,4L,9L,8L,7L,8L,4L,0L,7L,4L,4L,1L,6L,5L,6L,4L,2L,8L,4L,0L,9L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200412Inst : IEnumerable<long>
{
public static readonly long[] Value=A200412.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200412.Bytes);
public long this[int i]=>Value[i];

public static A200412Inst Instance=new A200412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200413
{
public static readonly long[] Value={ 1L,4L,9L,0L,1L,4L,5L,8L,2L,7L,9L,1L,2L,3L,2L,0L,4L,6L,1L,4L,3L,7L,5L,7L,0L,2L,7L,8L,4L,7L,3L,0L,8L,6L,6L,9L,0L,7L,2L,1L,1L,5L,5L,3L,5L,8L,2L,0L,1L,8L,5L,1L,2L,2L,9L,6L,1L,8L,7L,3L,7L,8L,1L,5L,9L,3L,8L,9L,7L,4L,1L,9L,6L,3L,4L,0L,7L,9L,3L,3L,4L,9L,9L,4L,5L,0L,7L,3L,7L,4L,2L,2L,8L,0L,7L,3L,7L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200413Inst : IEnumerable<long>
{
public static readonly long[] Value=A200413.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200413.Bytes);
public long this[int i]=>Value[i];

public static A200413Inst Instance=new A200413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200414
{
public static readonly long[] Value={ 1L,4L,9L,6L,6L,1L,6L,7L,4L,7L,9L,9L,1L,5L,7L,4L,2L,6L,8L,6L,6L,0L,2L,8L,1L,5L,2L,6L,8L,6L,1L,3L,9L,0L,7L,0L,3L,2L,0L,0L,3L,2L,3L,5L,1L,8L,6L,6L,2L,3L,6L,8L,9L,0L,0L,0L,8L,0L,9L,1L,4L,4L,1L,1L,6L,3L,8L,0L,4L,3L,8L,2L,0L,1L,4L,0L,1L,1L,3L,3L,5L,9L,2L,7L,2L,8L,0L,0L,2L,2L,2L,3L,3L,5L,2L,4L,6L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200414Inst : IEnumerable<long>
{
public static readonly long[] Value=A200414.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200414.Bytes);
public long this[int i]=>Value[i];

public static A200414Inst Instance=new A200414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200415
{
public static readonly long[] Value={ 1L,5L,0L,2L,0L,6L,6L,8L,7L,6L,3L,2L,6L,6L,0L,9L,2L,5L,5L,1L,5L,1L,6L,4L,8L,8L,1L,7L,3L,5L,4L,6L,9L,7L,6L,3L,0L,8L,7L,5L,0L,0L,3L,9L,7L,4L,6L,0L,8L,4L,4L,8L,8L,3L,4L,9L,5L,4L,1L,4L,7L,7L,4L,1L,5L,1L,3L,3L,0L,3L,5L,5L,7L,8L,6L,1L,3L,0L,7L,8L,7L,4L,5L,8L,9L,4L,1L,4L,0L,7L,7L,8L,1L,8L,7L,7L,0L,8L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200415Inst : IEnumerable<long>
{
public static readonly long[] Value=A200415.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200415.Bytes);
public long this[int i]=>Value[i];

public static A200415Inst Instance=new A200415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200416
{
public static readonly long[] Value={ 1L,4L,9L,3L,4L,8L,5L,1L,6L,4L,0L,7L,9L,5L,5L,2L,7L,7L,4L,1L,5L,5L,5L,7L,8L,7L,6L,8L,9L,1L,5L,0L,5L,7L,0L,6L,5L,3L,6L,0L,1L,6L,4L,3L,2L,6L,6L,1L,4L,3L,9L,6L,3L,9L,3L,8L,2L,4L,8L,3L,1L,2L,5L,5L,6L,6L,5L,2L,8L,1L,0L,5L,4L,0L,1L,5L,2L,9L,6L,8L,6L,7L,5L,4L,2L,7L,2L,6L,7L,8L,3L,6L,1L,6L,1L,2L,5L,6L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200416Inst : IEnumerable<long>
{
public static readonly long[] Value=A200416.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200416.Bytes);
public long this[int i]=>Value[i];

public static A200416Inst Instance=new A200416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200417
{
public static readonly long[] Value={ 1L,5L,0L,4L,5L,0L,6L,5L,2L,0L,3L,1L,8L,8L,7L,6L,0L,0L,5L,8L,6L,5L,8L,4L,8L,1L,1L,9L,7L,6L,6L,0L,4L,3L,8L,0L,5L,4L,8L,7L,2L,2L,6L,6L,3L,0L,9L,7L,9L,0L,8L,7L,9L,5L,2L,9L,7L,5L,5L,3L,9L,1L,1L,3L,3L,5L,2L,0L,5L,5L,1L,9L,3L,2L,5L,3L,3L,8L,7L,9L,2L,9L,6L,1L,8L,4L,0L,7L,5L,5L,5L,5L,6L,4L,1L,4L,6L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200417Inst : IEnumerable<long>
{
public static readonly long[] Value=A200417.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200417.Bytes);
public long this[int i]=>Value[i];

public static A200417Inst Instance=new A200417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200418
{
public static readonly long[] Value={ 1L,5L,0L,2L,0L,8L,7L,8L,5L,1L,4L,9L,1L,0L,8L,1L,7L,6L,6L,0L,8L,7L,7L,4L,9L,9L,1L,4L,8L,0L,8L,2L,0L,3L,0L,6L,4L,3L,7L,5L,6L,8L,0L,6L,4L,2L,3L,6L,3L,0L,6L,5L,9L,3L,2L,7L,7L,3L,5L,3L,0L,1L,0L,2L,4L,9L,4L,6L,1L,5L,0L,5L,3L,1L,2L,4L,6L,9L,1L,3L,2L,7L,8L,4L,4L,8L,3L,6L,6L,4L,7L,4L,9L,5L,3L,3L,5L,3L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200418Inst : IEnumerable<long>
{
public static readonly long[] Value=A200418.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200418.Bytes);
public long this[int i]=>Value[i];

public static A200418Inst Instance=new A200418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200419
{
public static readonly long[] Value={ 1L,5L,0L,6L,7L,8L,9L,6L,5L,1L,9L,2L,9L,9L,8L,8L,3L,9L,2L,9L,9L,5L,4L,6L,8L,4L,5L,4L,0L,2L,1L,3L,0L,4L,2L,0L,6L,7L,7L,1L,7L,4L,6L,9L,6L,8L,8L,3L,0L,9L,3L,7L,2L,7L,0L,9L,8L,4L,6L,0L,3L,1L,5L,9L,7L,4L,1L,0L,3L,2L,2L,2L,8L,5L,4L,0L,0L,3L,6L,3L,4L,9L,8L,5L,7L,7L,6L,7L,2L,7L,4L,0L,0L,0L,5L,0L,3L,7L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200419Inst : IEnumerable<long>
{
public static readonly long[] Value=A200419.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200419.Bytes);
public long this[int i]=>Value[i];

public static A200419Inst Instance=new A200419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200420
{
public static readonly long[] Value={ 1L,5L,1L,0L,8L,5L,6L,1L,4L,1L,3L,1L,7L,3L,3L,3L,7L,9L,4L,3L,3L,1L,8L,5L,1L,1L,5L,9L,1L,8L,3L,3L,1L,7L,6L,6L,2L,6L,8L,7L,1L,5L,5L,9L,0L,2L,1L,8L,7L,0L,0L,4L,2L,3L,1L,7L,6L,7L,0L,8L,9L,4L,2L,9L,7L,1L,0L,0L,0L,7L,1L,5L,2L,5L,7L,5L,4L,0L,5L,4L,5L,2L,0L,9L,5L,3L,1L,8L,3L,3L,6L,8L,6L,4L,3L,5L,5L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200420Inst : IEnumerable<long>
{
public static readonly long[] Value=A200420.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200420.Bytes);
public long this[int i]=>Value[i];

public static A200420Inst Instance=new A200420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200421
{
public static readonly long[] Value={ 1L,5L,1L,4L,4L,1L,3L,2L,8L,2L,8L,6L,8L,3L,6L,0L,2L,2L,3L,3L,1L,4L,0L,1L,9L,4L,3L,1L,7L,9L,0L,6L,5L,4L,5L,5L,7L,8L,4L,5L,1L,0L,6L,3L,8L,2L,9L,9L,0L,8L,7L,2L,7L,3L,5L,5L,0L,4L,8L,9L,5L,9L,9L,4L,2L,9L,5L,6L,0L,6L,1L,6L,7L,3L,4L,1L,7L,8L,9L,2L,0L,1L,5L,9L,9L,2L,3L,5L,1L,8L,0L,2L,8L,2L,1L,2L,7L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200421Inst : IEnumerable<long>
{
public static readonly long[] Value=A200421.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200421.Bytes);
public long this[int i]=>Value[i];

public static A200421Inst Instance=new A200421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200422
{
public static readonly long[] Value={ 1L,5L,0L,8L,9L,2L,9L,7L,7L,3L,7L,6L,0L,1L,7L,5L,5L,0L,2L,2L,5L,5L,5L,7L,2L,5L,4L,4L,9L,7L,6L,1L,8L,4L,1L,8L,4L,3L,7L,0L,8L,6L,1L,5L,6L,4L,3L,7L,3L,1L,3L,8L,1L,8L,1L,3L,1L,5L,8L,5L,5L,1L,2L,0L,4L,3L,2L,2L,7L,5L,8L,8L,8L,0L,3L,3L,0L,7L,1L,6L,5L,6L,1L,3L,5L,2L,5L,5L,5L,1L,2L,9L,9L,8L,6L,1L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200422Inst : IEnumerable<long>
{
public static readonly long[] Value=A200422.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200422.Bytes);
public long this[int i]=>Value[i];

public static A200422Inst Instance=new A200422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200423
{
public static readonly long[] Value={ 1L,5L,1L,6L,0L,8L,1L,4L,9L,5L,9L,5L,8L,7L,8L,3L,8L,3L,3L,9L,1L,4L,0L,4L,1L,5L,5L,7L,3L,1L,0L,8L,6L,4L,1L,7L,0L,7L,6L,3L,2L,8L,4L,3L,9L,3L,7L,1L,5L,5L,8L,7L,3L,5L,7L,9L,3L,4L,3L,4L,1L,9L,6L,7L,7L,6L,1L,2L,8L,3L,8L,7L,8L,0L,9L,8L,1L,4L,7L,5L,5L,3L,0L,3L,7L,8L,0L,0L,7L,7L,1L,5L,0L,0L,9L,8L,1L,3L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200423Inst : IEnumerable<long>
{
public static readonly long[] Value=A200423.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200423.Bytes);
public long this[int i]=>Value[i];

public static A200423Inst Instance=new A200423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200424
{
public static readonly long[] Value={ 20L,80L,212L,594L,1928L,6780L,23674L,80750L,271000L,909282L,3082640L,10545846L,36174576L,123964062L,424595930L,1456168762L,5004245744L,17226485764L,59361633214L,204702938074L,706403203606L,2439664629760L,8432567247356L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200424Inst : IEnumerable<long>
{
public static readonly long[] Value=A200424.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200424.Bytes);
public long this[int i]=>Value[i];

public static A200424Inst Instance=new A200424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200425
{
public static readonly long[] Value={ 92L,520L,2232L,9898L,50592L,270848L,1432402L,7469120L,38883992L,203526914L,1071337158L,5658347658L,29934599276L,158560687098L,841075030030L,4468272429398L,23771639720040L,126620792508358L,675163140324368L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200425Inst : IEnumerable<long>
{
public static readonly long[] Value=A200425.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200425.Bytes);
public long this[int i]=>Value[i];

public static A200425Inst Instance=new A200425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200426
{
public static readonly long[] Value={ 248L,1830L,11008L,67852L,473034L,3397130L,24220966L,171351382L,1214558880L,8651325238L,61876262346L,443696753874L,3187550880360L,22937925283316L,165329774491030L,1193432351805558L,8626352984960916L,62427556201202018L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200426Inst : IEnumerable<long>
{
public static readonly long[] Value=A200426.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200426.Bytes);
public long this[int i]=>Value[i];

public static A200426Inst Instance=new A200426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200427
{
public static readonly long[] Value={ 520L,4750L,36952L,293464L,2591502L,23380862L,210222830L,1882624856L,16911040968L,152565274262L,1381204433968L,12534862082614L,113983746333928L,1038347313892636L,9474508237939826L,86579678278534962L,792234931151418444L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200427Inst : IEnumerable<long>
{
public static readonly long[] Value=A200427.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200427.Bytes);
public long this[int i]=>Value[i];

public static A200427Inst Instance=new A200427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200428
{
public static readonly long[] Value={ 940L,10250L,98052L,955602L,10217182L,111101654L,1206988576L,13090995142L,142480007436L,1556876199472L,17066756670292L,187540784116604L,2065041046363200L,22780124416681858L,251710751862388016L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200428Inst : IEnumerable<long>
{
public static readonly long[] Value=A200428.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200428.Bytes);
public long this[int i]=>Value[i];

public static A200428Inst Instance=new A200428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200429
{
public static readonly long[] Value={ 1540L,19530L,221984L,2567334L,32233938L,410475622L,5230842688L,66651385442L,852399648492L,10942076565344L,140893244263052L,1818559742718468L,23521609925458628L,304795848113641082L,3956133736667718388L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200429Inst : IEnumerable<long>
{
public static readonly long[] Value=A200429.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200429.Bytes);
public long this[int i]=>Value[i];

public static A200429Inst Instance=new A200429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200430
{
public static readonly long[] Value={ 0L,20L,0L,92L,80L,0L,248L,520L,212L,0L,520L,1830L,2232L,594L,0L,940L,4750L,11008L,9898L,1928L,0L,1540L,10250L,36952L,67852L,50592L,6780L,0L,2352L,19530L,98052L,293464L,473034L,270848L,23674L,0L,3408L,34020L,221984L,955602L,2591502L,3397130L,1432402L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200430Inst : IEnumerable<long>
{
public static readonly long[] Value=A200430.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200430.Bytes);
public long this[int i]=>Value[i];

public static A200430Inst Instance=new A200430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200431
{
public static readonly long[] Value={ 0L,20L,92L,248L,520L,940L,1540L,2352L,3408L,4740L,6380L,8360L,10712L,13468L,16660L,20320L,24480L,29172L,34428L,40280L,46760L,53900L,61732L,70288L,79600L,89700L,100620L,112392L,125048L,138620L,153140L,168640L,185152L,202708L,221340L,241080L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200431Inst : IEnumerable<long>
{
public static readonly long[] Value=A200431.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200431.Bytes);
public long this[int i]=>Value[i];

public static A200431Inst Instance=new A200431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200432
{
public static readonly long[] Value={ 0L,80L,520L,1830L,4750L,10250L,19530L,34020L,55380L,85500L,126500L,180730L,250770L,339430L,449750L,585000L,748680L,944520L,1176480L,1448750L,1765750L,2132130L,2552770L,3032780L,3577500L,4192500L,4883580L,5656770L,6518330L,7474750L,8532750L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200432Inst : IEnumerable<long>
{
public static readonly long[] Value=A200432.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200432.Bytes);
public long this[int i]=>Value[i];

public static A200432Inst Instance=new A200432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200433
{
public static readonly long[] Value={ 0L,212L,2232L,11008L,36952L,98052L,221984L,448224L,830160L,1437204L,2356904L,3697056L,5587816L,8183812L,11666256L,16245056L,22160928L,29687508L,39133464L,50844608L,65206008L,82644100L,103628800L,128675616L,158347760L,193258260L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200433Inst : IEnumerable<long>
{
public static readonly long[] Value=A200433.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200433.Bytes);
public long this[int i]=>Value[i];

public static A200433Inst Instance=new A200433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200434
{
public static readonly long[] Value={ 0L,594L,9898L,67852L,293464L,955602L,2567334L,6003816L,12643728L,24534258L,44579634L,76753204L,126333064L,200161234L,306926382L,457470096L,665116704L,946026642L,1319573370L,1808743836L,2440562488L,3246538834L,4263138550L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200434Inst : IEnumerable<long>
{
public static readonly long[] Value=A200434.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200434.Bytes);
public long this[int i]=>Value[i];

public static A200434Inst Instance=new A200434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200435
{
public static readonly long[] Value={ 0L,1928L,50592L,473034L,2591502L,10217182L,32233938L,86581308L,205946004L,445471164L,892792604L,1680711318L,3002811474L,5132333154L,8444609086L,13443374616L,20791260168L,31344775440L,46194094584L,66707951618L,94583955318L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200435Inst : IEnumerable<long>
{
public static readonly long[] Value=A200435.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200435.Bytes);
public long this[int i]=>Value[i];

public static A200435Inst Instance=new A200435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200436
{
public static readonly long[] Value={ 0L,6780L,270848L,3397130L,23380862L,111101654L,410475622L,1264140498L,3392223642L,8172417894L,18054265218L,37145223104L,72010763708L,132735430724L,234296453996L,398306196892L,655184386476L,1046825751528L,1629833368476L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200436Inst : IEnumerable<long>
{
public static readonly long[] Value=A200436.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200436.Bytes);
public long this[int i]=>Value[i];

public static A200436Inst Instance=new A200436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200437
{
public static readonly long[] Value={ 0L,23674L,1432402L,24220966L,210222830L,1206988576L,5230842688L,18491305412L,56022717236L,150412523630L,366439267062L,824236891962L,1734285496242L,3448292160196L,6530868950100L,11857838629608L,20748002017096L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200437Inst : IEnumerable<long>
{
public static readonly long[] Value=A200437.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200437.Bytes);
public long this[int i]=>Value[i];

public static A200437Inst Instance=new A200437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200438
{
public static readonly long[] Value={ 1L,1L,-1L,-2L,5L,14L,-40L,-119L,351L,1083L,-3291L,-10424L,32562L,105066L,-334666L,-1094595L,3536043L,11686231L,-38172425L,-127199414L,419230644L,1406346735L,-4669311299L,-15750517780L,52616257231L,178312867791L,-598779740235L,-2037290707630L,6871904761413L,23461177498832L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200438Inst : IEnumerable<long>
{
public static readonly long[] Value=A200438.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200438.Bytes);
public long this[int i]=>Value[i];

public static A200438Inst Instance=new A200438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200439
{
public static readonly long[] Value={ 2L,7L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L,1L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200439Inst : IEnumerable<long>
{
public static readonly long[] Value=A200439.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200439.Bytes);
public long this[int i]=>Value[i];

public static A200439Inst Instance=new A200439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200440
{
public static readonly long[] Value={ 0L,5L,9L,63L,192L,259L,1421L,3007L,9653L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200440Inst : IEnumerable<long>
{
public static readonly long[] Value=A200440.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200440.Bytes);
public long this[int i]=>Value[i];

public static A200440Inst Instance=new A200440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200441
{
public static readonly BigInteger[] Value={ 1L,33L,1088L,35871L,1182655L,38991744L,1285544897L,42383989857L,1397386120384L,46071357982815L,1518957427312511L,50079523743330048L,1651105326102579073L,BigInteger.Parse("54436396237641779361"),BigInteger.Parse("1794749970516076139840"),BigInteger.Parse("59172312630792870835359"),BigInteger.Parse("1950891566845648661427007") };
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
public class A200441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200441Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200441.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200441.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200441Inst Instance=new A200441Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200442
{
public static readonly BigInteger[] Value={ 1L,31L,960L,29729L,920639L,28510080L,882891841L,27341136991L,846692354880L,26220121864289L,811977085438079L,25145069526716160L,778685178242762881L,BigInteger.Parse("24114095455998933151"),BigInteger.Parse("746758273957724164800"),BigInteger.Parse("23125392397233450175649"),BigInteger.Parse("716140406040279231280319") };
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
public class A200442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200442Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A200442.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200442.Bytes);
public BigInteger this[int i]=>Value[i];

public static A200442Inst Instance=new A200442Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200443
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,1L,4L,3L,2L,1L,5L,4L,3L,2L,1L,6L,5L,4L,3L,2L,1L,7L,6L,5L,4L,3L,2L,1L,8L,9L,6L,5L,4L,3L,2L,1L,9L,12L,9L,6L,5L,4L,3L,2L,1L,10L,15L,14L,9L,6L,5L,4L,3L,2L,1L,11L,18L,19L,12L,7L,6L,5L,4L,3L,2L,1L,12L,21L,24L,17L,12L,7L,6L,5L,4L,3L,2L,1L,13L,24L,33L,22L,19L,8L,7L,6L,7L,4L,3L,2L,1L,14L,29L,42L,37L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200443Inst : IEnumerable<long>
{
public static readonly long[] Value=A200443.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200443.Bytes);
public long this[int i]=>Value[i];

public static A200443Inst Instance=new A200443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200444
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,9L,14L,19L,24L,33L,42L,53L,64L,77L,94L,115L,136L,159L,182L,209L,242L,279L,316L,355L,398L,445L,492L,549L,606L,673L,740L,811L,882L,957L,1042L,1137L,1232L,1331L,1430L,1541L,1652L,1779L,1906L,2037L,2176L,2323L,2470L,2623L,2786L,2961L,3140L,3327L,3514L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200444Inst : IEnumerable<long>
{
public static readonly long[] Value=A200444.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200444.Bytes);
public long this[int i]=>Value[i];

public static A200444Inst Instance=new A200444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200445
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,9L,12L,17L,22L,37L,52L,71L,94L,117L,148L,197L,250L,305L,364L,453L,546L,655L,768L,897L,1050L,1227L,1412L,1623L,1846L,2121L,2400L,2729L,3066L,3417L,3824L,4289L,4774L,5285L,5812L,6447L,7094L,7799L,8516L,9309L,10190L,11117L,12072L,13101L,14170L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200445Inst : IEnumerable<long>
{
public static readonly long[] Value=A200445.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200445.Bytes);
public long this[int i]=>Value[i];

public static A200445Inst Instance=new A200445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200446
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,12L,19L,28L,43L,66L,97L,132L,177L,242L,321L,420L,529L,662L,829L,1044L,1327L,1624L,1977L,2400L,2883L,3434L,4103L,4818L,5711L,6698L,7791L,8982L,10279L,11860L,13693L,15648L,17783L,20078L,22725L,25538L,28845L,32338L,36091L,40360L,44961L,49814L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200446Inst : IEnumerable<long>
{
public static readonly long[] Value=A200446.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200446.Bytes);
public long this[int i]=>Value[i];

public static A200446Inst Instance=new A200446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200447
{
public static readonly long[] Value={ 2L,3L,4L,5L,6L,7L,8L,17L,26L,41L,60L,93L,130L,187L,256L,373L,522L,717L,940L,1209L,1586L,2121L,2728L,3513L,4412L,5477L,6734L,8393L,10272L,12585L,15230L,18267L,21728L,25639L,30370L,36047L,42304L,49367L,57338L,66281L,76008L,87997L,101138L,115865L,132268L,150389L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200447Inst : IEnumerable<long>
{
public static readonly long[] Value=A200447.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200447.Bytes);
public long this[int i]=>Value[i];

public static A200447Inst Instance=new A200447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200448
{
public static readonly long[] Value={ 10L,44L,144L,486L,1582L,5478L,18692L,64782L,223272L,776430L,2701660L,9439702L,33021250L,115801892L,406698282L,1430840312L,5040451088L,17779563894L,62784860258L,221948186878L,785340477204L,2781302241584L,9857972484436L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200448Inst : IEnumerable<long>
{
public static readonly long[] Value=A200448.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200448.Bytes);
public long this[int i]=>Value[i];

public static A200448Inst Instance=new A200448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200449
{
public static readonly long[] Value={ 26L,142L,728L,3788L,19802L,103726L,548204L,2916664L,15576706L,83481240L,448758338L,2418733790L,13066215896L,70726653732L,383520053994L,2082953525918L,11328873637896L,61694898371006L,336368349457684L,1835858710497508L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200449Inst : IEnumerable<long>
{
public static readonly long[] Value=A200449.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200449.Bytes);
public long this[int i]=>Value[i];

public static A200449Inst Instance=new A200449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200450
{
public static readonly long[] Value={ 44L,342L,2334L,16380L,115140L,820650L,5876818L,42324384L,306098316L,2222013090L,16179361028L,118122171194L,864377954818L,6338065287424L,46557302873890L,342540516750538L,2523812868946712L,18619248362911724L,137522653687668252L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200450Inst : IEnumerable<long>
{
public static readonly long[] Value=A200450.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200450.Bytes);
public long this[int i]=>Value[i];

public static A200450Inst Instance=new A200450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200451
{
public static readonly long[] Value={ 72L,678L,5720L,50852L,451708L,4062384L,36725772L,334032710L,3050654456L,27965763262L,257160791680L,2371128350480L,21913699015614L,202938626310668L,1882772669652668L,17495621074794634L,162811923678190584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200451Inst : IEnumerable<long>
{
public static readonly long[] Value=A200451.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200451.Bytes);
public long this[int i]=>Value[i];

public static A200451Inst Instance=new A200451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200452
{
public static readonly long[] Value={ 102L,1148L,12002L,127988L,1375006L,14923636L,163058296L,1791564880L,19771609900L,219008350922L,2433568582846L,27114470656254L,302815705130546L,3388823734521446L,37993433832232370L,426648365048068166L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200452Inst : IEnumerable<long>
{
public static readonly long[] Value=A200452.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200452.Bytes);
public long this[int i]=>Value[i];

public static A200452Inst Instance=new A200452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200453
{
public static readonly long[] Value={ 142L,1832L,22276L,278906L,3513884L,44716536L,572857272L,7380022092L,95496980144L,1240352594210L,16161267003100L,211148128583658L,2765181621011902L,36287540439791446L,477071904597059874L,6282247056373911518L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200453Inst : IEnumerable<long>
{
public static readonly long[] Value=A200453.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200453.Bytes);
public long this[int i]=>Value[i];

public static A200453Inst Instance=new A200453Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200454
{
public static readonly long[] Value={ 4L,10L,4L,26L,44L,6L,44L,142L,144L,10L,72L,342L,728L,486L,14L,102L,678L,2334L,3788L,1582L,22L,142L,1148L,5720L,16380L,19802L,5478L,34L,184L,1832L,12002L,50852L,115140L,103726L,18692L,52L,236L,2744L,22276L,127988L,451708L,820650L,548204L,64782L,80L,290L,3874L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200454Inst : IEnumerable<long>
{
public static readonly long[] Value=A200454.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200454.Bytes);
public long this[int i]=>Value[i];

public static A200454Inst Instance=new A200454Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200455
{
public static readonly long[] Value={ 4L,10L,26L,44L,72L,102L,142L,184L,236L,290L,354L,420L,496L,574L,662L,752L,852L,954L,1066L,1180L,1304L,1430L,1566L,1704L,1852L,2002L,2162L,2324L,2496L,2670L,2854L,3040L,3236L,3434L,3642L,3852L,4072L,4294L,4526L,4760L,5004L,5250L,5506L,5764L,6032L,6302L,6582L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200455Inst : IEnumerable<long>
{
public static readonly long[] Value=A200455.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200455.Bytes);
public long this[int i]=>Value[i];

public static A200455Inst Instance=new A200455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A200456
{
public static readonly long[] Value={ 4L,44L,142L,342L,678L,1148L,1832L,2744L,3874L,5334L,7114L,9192L,11708L,14644L,17962L,21826L,26206L,31044L,36544L,42660L,49310L,56734L,64866L,73616L,83256L,93696L,104834L,116970L,130006L,143824L,158748L,174668L,191446L,209446L,228542L,248572L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A200456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A200456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A200456Inst : IEnumerable<long>
{
public static readonly long[] Value=A200456.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A200456.Bytes);
public long this[int i]=>Value[i];

public static A200456Inst Instance=new A200456Inst();

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