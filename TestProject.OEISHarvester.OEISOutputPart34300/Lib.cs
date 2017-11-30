using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A011390
{
public static readonly long[] Value={ 1L,1L,9L,3L,7L,2L,1L,6L,1L,4L,3L,8L,3L,9L,0L,0L,1L,3L,7L,0L,7L,3L,3L,0L,2L,5L,9L,3L,0L,2L,1L,7L,4L,6L,8L,3L,9L,6L,1L,7L,1L,7L,4L,1L,2L,2L,0L,5L,2L,3L,6L,7L,7L,8L,1L,6L,3L,3L,1L,4L,3L,8L,0L,4L,7L,2L,6L,1L,4L,0L,6L,9L,8L,7L,9L,5L,1L,3L,9L,9L,9L,0L,6L,5L,7L,4L,8L,5L,3L,4L,0L,1L,8L,5L,2L,0L,2L,6L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011390Inst : IEnumerable<long>
{
public static readonly long[] Value=A011390.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011390.Bytes);
public long this[int i]=>Value[i];

public static A011390Inst Instance=new A011390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011389
{
public static readonly long[] Value={ 1L,2L,0L,7L,8L,9L,7L,0L,7L,0L,8L,1L,5L,4L,3L,3L,9L,3L,3L,8L,5L,2L,9L,2L,1L,9L,0L,3L,1L,5L,7L,4L,9L,2L,4L,3L,3L,9L,1L,1L,5L,8L,8L,7L,5L,8L,3L,8L,5L,3L,4L,2L,1L,4L,5L,8L,1L,0L,3L,3L,6L,4L,5L,5L,9L,6L,0L,6L,5L,3L,4L,5L,6L,3L,1L,5L,5L,2L,1L,6L,4L,9L,0L,6L,0L,5L,1L,6L,7L,0L,4L,7L,2L,3L,5L,7L,1L,0L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011389Inst : IEnumerable<long>
{
public static readonly long[] Value=A011389.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011389.Bytes);
public long this[int i]=>Value[i];

public static A011389Inst Instance=new A011389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011388
{
public static readonly long[] Value={ 1L,2L,2L,4L,3L,0L,3L,8L,3L,1L,6L,0L,0L,4L,5L,7L,7L,5L,1L,4L,1L,0L,9L,8L,9L,6L,6L,8L,1L,5L,7L,3L,7L,5L,8L,0L,2L,9L,9L,9L,8L,2L,8L,1L,9L,9L,1L,5L,9L,6L,2L,6L,6L,9L,9L,9L,1L,0L,6L,9L,3L,7L,4L,1L,8L,7L,9L,0L,3L,4L,0L,4L,3L,4L,4L,6L,9L,7L,5L,3L,1L,3L,6L,5L,1L,9L,5L,9L,1L,1L,3L,9L,6L,6L,7L,5L,4L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011388Inst : IEnumerable<long>
{
public static readonly long[] Value=A011388.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011388.Bytes);
public long this[int i]=>Value[i];

public static A011388Inst Instance=new A011388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011387
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,1L,1L,8L,1L,7L,9L,6L,0L,5L,8L,0L,3L,3L,9L,7L,5L,9L,8L,0L,1L,3L,2L,0L,6L,0L,2L,0L,5L,0L,9L,3L,7L,2L,2L,7L,9L,6L,0L,9L,7L,1L,9L,4L,0L,3L,6L,6L,5L,5L,5L,0L,5L,1L,2L,6L,1L,6L,7L,3L,0L,6L,8L,6L,9L,9L,2L,0L,7L,0L,6L,9L,7L,1L,4L,8L,1L,6L,8L,7L,4L,9L,5L,2L,3L,1L,1L,6L,1L,9L,2L,2L,3L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011387Inst : IEnumerable<long>
{
public static readonly long[] Value=A011387.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011387.Bytes);
public long this[int i]=>Value[i];

public static A011387Inst Instance=new A011387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011386
{
public static readonly long[] Value={ 1L,2L,6L,6L,3L,0L,2L,3L,4L,2L,0L,6L,2L,3L,3L,2L,7L,9L,1L,2L,0L,8L,5L,5L,4L,6L,0L,5L,1L,3L,8L,0L,7L,8L,5L,9L,8L,0L,8L,2L,2L,7L,4L,2L,1L,1L,1L,0L,9L,7L,6L,6L,8L,3L,7L,7L,6L,2L,4L,9L,7L,6L,7L,1L,3L,8L,5L,2L,6L,7L,7L,0L,7L,9L,8L,8L,3L,9L,3L,3L,5L,2L,2L,1L,7L,3L,9L,4L,2L,8L,9L,2L,0L,7L,7L,5L,1L,7L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011386Inst : IEnumerable<long>
{
public static readonly long[] Value=A011386.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011386.Bytes);
public long this[int i]=>Value[i];

public static A011386Inst Instance=new A011386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011385
{
public static readonly long[] Value={ 1L,2L,9L,3L,7L,7L,5L,7L,0L,8L,9L,1L,5L,5L,5L,7L,8L,8L,8L,1L,2L,0L,2L,1L,3L,1L,3L,7L,2L,7L,3L,3L,8L,7L,0L,9L,3L,0L,7L,3L,1L,3L,6L,8L,6L,2L,0L,4L,0L,2L,2L,4L,0L,0L,6L,9L,9L,1L,9L,7L,0L,9L,9L,3L,7L,5L,3L,0L,6L,1L,3L,6L,0L,3L,5L,5L,7L,0L,1L,2L,9L,6L,5L,7L,3L,6L,5L,3L,3L,6L,1L,7L,3L,2L,8L,4L,9L,2L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011385Inst : IEnumerable<long>
{
public static readonly long[] Value=A011385.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011385.Bytes);
public long this[int i]=>Value[i];

public static A011385Inst Instance=new A011385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011384
{
public static readonly long[] Value={ 1L,3L,2L,7L,5L,3L,1L,6L,7L,4L,8L,8L,8L,5L,1L,9L,1L,9L,0L,6L,4L,3L,2L,5L,6L,8L,8L,6L,0L,2L,1L,2L,0L,7L,5L,2L,6L,0L,0L,9L,7L,6L,3L,0L,6L,0L,7L,9L,4L,6L,8L,4L,6L,2L,9L,5L,7L,8L,4L,6L,7L,2L,9L,4L,2L,3L,2L,4L,2L,5L,3L,6L,0L,6L,5L,4L,6L,5L,6L,3L,3L,1L,3L,2L,3L,7L,6L,8L,9L,4L,3L,5L,9L,3L,7L,2L,3L,4L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011384Inst : IEnumerable<long>
{
public static readonly long[] Value=A011384.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011384.Bytes);
public long this[int i]=>Value[i];

public static A011384Inst Instance=new A011384Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011383
{
public static readonly long[] Value={ 1L,3L,6L,9L,9L,8L,7L,3L,1L,7L,7L,3L,9L,7L,4L,5L,7L,0L,2L,1L,0L,9L,1L,7L,1L,6L,9L,0L,6L,5L,1L,9L,8L,2L,1L,8L,3L,1L,9L,8L,6L,3L,0L,3L,7L,4L,6L,9L,3L,9L,5L,9L,9L,0L,4L,8L,4L,2L,2L,2L,9L,0L,4L,0L,7L,2L,3L,6L,2L,5L,4L,8L,7L,1L,1L,5L,4L,3L,2L,8L,7L,7L,6L,5L,7L,8L,0L,9L,4L,0L,2L,1L,2L,3L,3L,5L,1L,8L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011383Inst : IEnumerable<long>
{
public static readonly long[] Value=A011383.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011383.Bytes);
public long this[int i]=>Value[i];

public static A011383Inst Instance=new A011383Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011382
{
public static readonly long[] Value={ 1L,4L,2L,4L,9L,7L,1L,2L,9L,2L,6L,4L,7L,3L,0L,4L,7L,7L,8L,6L,3L,1L,3L,0L,7L,3L,3L,0L,5L,4L,9L,5L,1L,0L,0L,6L,8L,9L,8L,6L,8L,0L,5L,4L,5L,1L,7L,5L,1L,1L,8L,3L,1L,1L,6L,1L,1L,0L,4L,1L,0L,2L,8L,8L,0L,2L,1L,4L,8L,8L,1L,6L,0L,9L,4L,5L,8L,9L,4L,7L,6L,5L,1L,2L,4L,3L,1L,7L,3L,6L,7L,9L,1L,2L,8L,8L,7L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011382Inst : IEnumerable<long>
{
public static readonly long[] Value=A011382.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011382.Bytes);
public long this[int i]=>Value[i];

public static A011382Inst Instance=new A011382Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011381
{
public static readonly long[] Value={ 1L,4L,9L,8L,9L,1L,9L,8L,7L,2L,0L,7L,1L,5L,6L,2L,0L,1L,2L,1L,7L,2L,7L,9L,0L,1L,2L,3L,6L,8L,2L,5L,2L,9L,6L,7L,7L,8L,5L,9L,7L,2L,2L,7L,9L,7L,9L,4L,0L,2L,2L,5L,5L,6L,8L,2L,4L,5L,6L,7L,1L,2L,2L,3L,1L,8L,5L,4L,5L,3L,6L,1L,3L,3L,5L,0L,0L,6L,6L,9L,2L,0L,2L,1L,6L,2L,3L,7L,9L,1L,7L,1L,0L,2L,3L,2L,9L,5L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011381Inst : IEnumerable<long>
{
public static readonly long[] Value=A011381.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011381.Bytes);
public long this[int i]=>Value[i];

public static A011381Inst Instance=new A011381Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011380
{
public static readonly long[] Value={ 1L,6L,0L,3L,5L,2L,1L,6L,2L,1L,5L,1L,2L,5L,4L,9L,2L,8L,2L,9L,8L,5L,4L,6L,4L,7L,9L,0L,7L,0L,2L,3L,1L,7L,5L,8L,6L,5L,3L,5L,1L,3L,4L,8L,6L,6L,5L,4L,4L,9L,7L,1L,0L,0L,9L,8L,5L,9L,8L,3L,0L,2L,4L,1L,2L,5L,1L,1L,1L,7L,4L,0L,4L,2L,5L,5L,5L,0L,6L,2L,4L,1L,7L,8L,4L,7L,7L,5L,0L,4L,0L,7L,7L,9L,1L,4L,7L,2L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011380Inst : IEnumerable<long>
{
public static readonly long[] Value=A011380.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011380.Bytes);
public long this[int i]=>Value[i];

public static A011380Inst Instance=new A011380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011379
{
public static readonly long[] Value={ 0L,2L,12L,36L,80L,150L,252L,392L,576L,810L,1100L,1452L,1872L,2366L,2940L,3600L,4352L,5202L,6156L,7220L,8400L,9702L,11132L,12696L,14400L,16250L,18252L,20412L,22736L,25230L,27900L,30752L,33792L,37026L,40460L,44100L,47952L,52022L,56316L,60840L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011379Inst : IEnumerable<long>
{
public static readonly long[] Value=A011379.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011379.Bytes);
public long this[int i]=>Value[i];

public static A011379Inst Instance=new A011379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011378
{
public static readonly long[] Value={ 1L,1L,5L,7L,1L,1L,0L,2L,3L,7L,2L,8L,2L,7L,1L,9L,8L,2L,5L,5L,1L,4L,2L,9L,1L,1L,2L,3L,6L,2L,9L,6L,9L,0L,0L,2L,0L,5L,4L,8L,3L,6L,6L,6L,3L,3L,9L,5L,1L,4L,3L,5L,8L,3L,4L,5L,5L,1L,3L,7L,1L,3L,3L,1L,4L,7L,1L,2L,3L,6L,7L,3L,1L,2L,8L,6L,7L,9L,1L,6L,6L,3L,0L,1L,9L,1L,4L,0L,4L,3L,8L,6L,4L,7L,4L,5L,8L,7L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011378Inst : IEnumerable<long>
{
public static readonly long[] Value=A011378.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011378.Bytes);
public long this[int i]=>Value[i];

public static A011378Inst Instance=new A011378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011377
{
public static readonly long[] Value={ 1L,3L,8L,18L,39L,81L,166L,336L,677L,1359L,2724L,5454L,10915L,21837L,43682L,87372L,174753L,349515L,699040L,1398090L,2796191L,5592393L,11184798L,22369608L,44739229L,89478471L,178956956L,357913926L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011377Inst : IEnumerable<long>
{
public static readonly long[] Value=A011377.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011377.Bytes);
public long this[int i]=>Value[i];

public static A011377Inst Instance=new A011377Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011376
{
public static readonly long[] Value={ 1L,1L,7L,7L,1L,4L,6L,6L,9L,3L,9L,0L,8L,9L,1L,7L,6L,8L,6L,9L,2L,5L,6L,3L,0L,3L,8L,9L,8L,4L,2L,6L,0L,3L,1L,9L,8L,2L,5L,9L,4L,3L,3L,7L,4L,2L,1L,4L,6L,1L,1L,6L,1L,7L,7L,9L,5L,0L,3L,2L,8L,6L,2L,9L,2L,9L,9L,6L,1L,0L,7L,7L,3L,7L,4L,0L,2L,1L,0L,6L,2L,4L,8L,4L,1L,1L,3L,1L,4L,6L,1L,7L,6L,0L,3L,6L,1L,3L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011376Inst : IEnumerable<long>
{
public static readonly long[] Value=A011376.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011376.Bytes);
public long this[int i]=>Value[i];

public static A011376Inst Instance=new A011376Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011375
{
public static readonly long[] Value={ 3L,3L,4L,4L,5L,5L,5L,6L,7L,8L,8L,8L,8L,9L,9L,9L,9L,10L,10L,11L,11L,12L,12L,12L,13L,13L,14L,14L,15L,15L,16L,16L,16L,17L,17L,18L,18L,19L,19L,19L,20L,20L,20L,21L,21L,22L,22L,23L,23L,24L,24L,25L,25L,26L,26L,27L,27L,28L,28L,29L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011375Inst : IEnumerable<long>
{
public static readonly long[] Value=A011375.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011375.Bytes);
public long this[int i]=>Value[i];

public static A011375Inst Instance=new A011375Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011374
{
public static readonly long[] Value={ 1L,2L,0L,3L,0L,2L,5L,0L,3L,6L,0L,8L,2L,1L,1L,6L,6L,5L,0L,9L,5L,7L,1L,2L,5L,4L,4L,2L,5L,0L,3L,7L,2L,7L,4L,5L,1L,0L,1L,5L,5L,4L,7L,6L,9L,4L,1L,9L,0L,5L,0L,8L,5L,0L,8L,7L,5L,9L,9L,1L,5L,7L,4L,9L,7L,9L,7L,3L,2L,9L,2L,4L,1L,2L,9L,0L,5L,6L,0L,8L,8L,9L,6L,7L,1L,9L,0L,6L,1L,4L,0L,6L,5L,8L,6L,6L,8L,2L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011374Inst : IEnumerable<long>
{
public static readonly long[] Value=A011374.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011374.Bytes);
public long this[int i]=>Value[i];

public static A011374Inst Instance=new A011374Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011325
{
public static readonly long[] Value={ 1L,2L,6L,2L,6L,0L,5L,2L,1L,1L,2L,1L,9L,6L,5L,3L,0L,3L,3L,3L,6L,6L,0L,3L,2L,0L,3L,1L,2L,0L,8L,0L,9L,8L,7L,1L,8L,7L,6L,3L,3L,2L,1L,3L,4L,0L,1L,2L,4L,9L,4L,3L,1L,4L,3L,6L,3L,6L,4L,4L,3L,6L,6L,1L,2L,7L,1L,9L,2L,1L,1L,3L,4L,1L,0L,3L,0L,0L,5L,9L,3L,3L,9L,6L,7L,3L,1L,4L,1L,0L,2L,0L,8L,3L,9L,5L,5L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011325Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011325.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011325Inst : IEnumerable<long>
{
public static readonly long[] Value=A011325.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011325.Bytes);
public long this[int i]=>Value[i];

public static A011325Inst Instance=new A011325Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011324
{
public static readonly long[] Value={ 1L,2L,9L,2L,3L,9L,2L,2L,2L,0L,7L,8L,0L,8L,3L,1L,8L,4L,1L,5L,1L,0L,9L,1L,3L,1L,9L,8L,8L,5L,6L,6L,8L,7L,1L,6L,0L,6L,2L,1L,0L,6L,2L,9L,6L,4L,6L,7L,2L,7L,7L,5L,1L,4L,8L,3L,4L,7L,4L,5L,3L,0L,6L,5L,5L,6L,0L,7L,4L,5L,6L,2L,4L,3L,3L,7L,7L,2L,1L,9L,8L,1L,1L,4L,0L,6L,9L,9L,0L,0L,6L,8L,0L,1L,2L,4L,3L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011324Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011324.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011324Inst : IEnumerable<long>
{
public static readonly long[] Value=A011324.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011324.Bytes);
public long this[int i]=>Value[i];

public static A011324Inst Instance=new A011324Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011323
{
public static readonly long[] Value={ 1L,3L,2L,9L,7L,5L,4L,5L,4L,5L,6L,3L,9L,7L,8L,5L,9L,7L,2L,9L,0L,5L,2L,7L,3L,8L,7L,5L,1L,4L,8L,8L,1L,3L,1L,7L,9L,4L,2L,7L,0L,8L,7L,5L,0L,0L,4L,6L,4L,7L,8L,2L,0L,2L,0L,8L,3L,1L,0L,1L,5L,9L,2L,9L,8L,7L,3L,8L,6L,4L,5L,4L,2L,5L,5L,2L,4L,3L,9L,5L,3L,0L,2L,7L,3L,6L,8L,5L,5L,4L,0L,6L,9L,6L,1L,1L,6L,4L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011323Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011323.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011323Inst : IEnumerable<long>
{
public static readonly long[] Value=A011323.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011323.Bytes);
public long this[int i]=>Value[i];

public static A011323Inst Instance=new A011323Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011322
{
public static readonly long[] Value={ 1L,3L,7L,7L,9L,8L,0L,0L,1L,5L,1L,3L,6L,6L,2L,8L,0L,8L,9L,8L,7L,7L,0L,0L,1L,9L,0L,0L,1L,6L,7L,7L,4L,9L,4L,8L,4L,7L,2L,6L,0L,2L,2L,1L,1L,4L,4L,0L,7L,0L,9L,7L,2L,5L,0L,9L,3L,9L,4L,8L,3L,5L,3L,0L,5L,4L,4L,2L,8L,1L,5L,8L,3L,2L,6L,1L,6L,1L,7L,0L,6L,6L,6L,6L,6L,5L,4L,9L,3L,7L,8L,5L,5L,7L,9L,8L,6L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011322Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011322.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011322Inst : IEnumerable<long>
{
public static readonly long[] Value=A011322.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011322.Bytes);
public long this[int i]=>Value[i];

public static A011322Inst Instance=new A011322Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011321
{
public static readonly long[] Value={ 1L,4L,4L,2L,5L,6L,2L,9L,1L,9L,4L,4L,2L,9L,7L,7L,7L,3L,0L,8L,7L,9L,4L,4L,0L,7L,6L,5L,7L,4L,1L,9L,4L,9L,7L,4L,0L,9L,4L,2L,3L,0L,0L,3L,3L,6L,7L,5L,1L,4L,9L,1L,2L,7L,7L,8L,7L,2L,0L,8L,1L,7L,6L,2L,0L,7L,6L,0L,4L,4L,0L,1L,3L,6L,0L,0L,6L,5L,6L,0L,3L,4L,3L,5L,8L,5L,3L,6L,2L,5L,0L,9L,9L,9L,1L,6L,4L,6L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011321Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011321.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011321Inst : IEnumerable<long>
{
public static readonly long[] Value=A011321.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011321.Bytes);
public long this[int i]=>Value[i];

public static A011321Inst Instance=new A011321Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011320
{
public static readonly long[] Value={ 1L,5L,3L,3L,4L,0L,6L,2L,3L,7L,0L,1L,6L,3L,8L,7L,4L,7L,7L,5L,2L,7L,8L,3L,1L,3L,2L,5L,2L,8L,0L,1L,7L,4L,0L,5L,9L,3L,9L,0L,9L,6L,2L,0L,7L,4L,7L,1L,8L,1L,7L,4L,6L,7L,8L,9L,6L,1L,2L,1L,6L,3L,4L,8L,6L,0L,6L,5L,5L,8L,9L,2L,1L,5L,0L,9L,4L,8L,8L,4L,5L,8L,4L,2L,1L,0L,5L,2L,2L,3L,3L,7L,0L,8L,4L,0L,5L,0L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011320Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011320.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011320Inst : IEnumerable<long>
{
public static readonly long[] Value=A011320.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011320.Bytes);
public long this[int i]=>Value[i];

public static A011320Inst Instance=new A011320Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011319
{
public static readonly long[] Value={ 1L,1L,3L,2L,2L,9L,3L,6L,2L,5L,3L,4L,0L,5L,3L,6L,5L,8L,7L,9L,9L,5L,2L,5L,8L,5L,5L,9L,8L,7L,7L,5L,8L,7L,8L,5L,0L,1L,7L,6L,6L,9L,3L,8L,4L,9L,7L,7L,4L,9L,2L,6L,9L,6L,0L,1L,4L,8L,8L,4L,3L,4L,1L,6L,9L,7L,4L,5L,0L,1L,7L,7L,8L,6L,8L,7L,1L,2L,1L,9L,1L,9L,2L,9L,9L,5L,1L,9L,4L,6L,9L,4L,1L,8L,2L,6L,8L,5L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011319Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011319.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011319Inst : IEnumerable<long>
{
public static readonly long[] Value=A011319.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011319.Bytes);
public long this[int i]=>Value[i];

public static A011319Inst Instance=new A011319Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011318
{
public static readonly long[] Value={ 1L,1L,3L,9L,7L,2L,2L,2L,1L,3L,6L,9L,3L,8L,7L,8L,2L,5L,9L,8L,0L,5L,4L,7L,8L,7L,7L,9L,6L,7L,2L,9L,4L,9L,2L,8L,7L,4L,8L,9L,3L,7L,7L,9L,3L,3L,4L,4L,3L,6L,4L,2L,7L,1L,1L,0L,8L,2L,0L,9L,5L,7L,1L,1L,1L,9L,0L,2L,1L,5L,2L,7L,7L,9L,1L,7L,5L,4L,1L,5L,3L,1L,7L,8L,5L,3L,4L,6L,7L,3L,3L,1L,4L,5L,5L,9L,7L,9L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011318Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011318.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011318Inst : IEnumerable<long>
{
public static readonly long[] Value=A011318.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011318.Bytes);
public long this[int i]=>Value[i];

public static A011318Inst Instance=new A011318Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011317
{
public static readonly long[] Value={ 1L,1L,4L,8L,0L,3L,3L,3L,7L,4L,6L,0L,7L,6L,3L,8L,4L,1L,6L,7L,0L,6L,2L,9L,5L,7L,2L,5L,0L,4L,5L,2L,5L,5L,6L,9L,1L,9L,2L,9L,0L,3L,1L,7L,1L,4L,2L,0L,6L,3L,7L,1L,8L,3L,6L,9L,9L,1L,2L,9L,3L,5L,5L,0L,0L,0L,6L,8L,5L,0L,4L,3L,3L,2L,9L,7L,2L,8L,3L,6L,7L,3L,0L,7L,1L,1L,7L,1L,3L,3L,9L,8L,2L,0L,8L,1L,8L,6L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011317Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011317.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011317Inst : IEnumerable<long>
{
public static readonly long[] Value=A011317.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011317.Bytes);
public long this[int i]=>Value[i];

public static A011317Inst Instance=new A011317Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011316
{
public static readonly long[] Value={ 1L,1L,5L,7L,3L,9L,4L,0L,6L,1L,6L,7L,5L,5L,6L,9L,3L,0L,4L,7L,6L,3L,2L,2L,0L,6L,7L,0L,9L,9L,7L,5L,3L,2L,5L,9L,4L,0L,4L,2L,1L,5L,3L,0L,3L,9L,2L,3L,8L,7L,3L,1L,3L,3L,0L,5L,4L,3L,1L,8L,8L,3L,7L,9L,5L,4L,4L,5L,5L,1L,8L,4L,6L,4L,7L,1L,1L,2L,8L,2L,1L,4L,6L,6L,5L,8L,7L,8L,3L,2L,8L,0L,5L,8L,8L,4L,3L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011316Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011316.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011316Inst : IEnumerable<long>
{
public static readonly long[] Value=A011316.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011316.Bytes);
public long this[int i]=>Value[i];

public static A011316Inst Instance=new A011316Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011315
{
public static readonly long[] Value={ 1L,1L,6L,8L,0L,1L,6L,0L,9L,6L,5L,5L,9L,1L,8L,9L,5L,1L,7L,0L,5L,6L,6L,8L,2L,0L,5L,0L,7L,4L,6L,9L,8L,1L,4L,3L,4L,6L,9L,6L,2L,1L,5L,0L,6L,2L,8L,6L,4L,4L,6L,9L,7L,9L,3L,9L,0L,5L,7L,5L,3L,2L,8L,7L,4L,9L,8L,9L,6L,5L,7L,2L,5L,0L,1L,7L,8L,4L,1L,6L,8L,2L,0L,3L,5L,3L,0L,3L,5L,4L,8L,4L,8L,3L,6L,3L,2L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011315Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011315.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011315Inst : IEnumerable<long>
{
public static readonly long[] Value=A011315.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011315.Bytes);
public long this[int i]=>Value[i];

public static A011315Inst Instance=new A011315Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011314
{
public static readonly long[] Value={ 1L,1L,8L,0L,1L,7L,2L,2L,9L,8L,2L,9L,1L,0L,0L,5L,6L,8L,7L,7L,6L,3L,2L,5L,3L,9L,0L,4L,3L,9L,3L,6L,7L,3L,5L,4L,4L,2L,6L,6L,2L,9L,4L,3L,5L,4L,3L,0L,0L,4L,9L,2L,8L,3L,0L,2L,3L,1L,5L,2L,5L,7L,6L,4L,7L,8L,9L,6L,5L,9L,2L,8L,3L,7L,6L,0L,9L,4L,9L,5L,0L,2L,7L,5L,3L,0L,9L,4L,2L,5L,5L,9L,3L,2L,1L,2L,0L,5L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011314Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011314.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011314Inst : IEnumerable<long>
{
public static readonly long[] Value=A011314.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011314.Bytes);
public long this[int i]=>Value[i];

public static A011314Inst Instance=new A011314Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011313
{
public static readonly long[] Value={ 1L,1L,9L,4L,2L,2L,0L,0L,9L,4L,9L,6L,8L,8L,3L,7L,3L,2L,5L,3L,6L,8L,8L,8L,4L,1L,8L,9L,2L,9L,2L,2L,9L,1L,9L,6L,1L,3L,9L,1L,2L,2L,7L,8L,0L,0L,1L,5L,3L,2L,1L,6L,5L,0L,0L,0L,7L,1L,2L,7L,7L,3L,8L,0L,6L,3L,1L,9L,6L,5L,2L,4L,0L,7L,5L,1L,9L,7L,1L,3L,4L,1L,0L,6L,9L,9L,0L,4L,1L,6L,1L,8L,0L,9L,3L,4L,6L,5L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011313Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011313.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011313Inst : IEnumerable<long>
{
public static readonly long[] Value=A011313.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011313.Bytes);
public long this[int i]=>Value[i];

public static A011313Inst Instance=new A011313Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011312
{
public static readonly long[] Value={ 1L,2L,1L,0L,6L,3L,6L,9L,9L,7L,5L,8L,2L,2L,3L,0L,4L,7L,5L,1L,6L,0L,8L,4L,7L,6L,8L,1L,1L,6L,0L,9L,7L,7L,1L,1L,0L,3L,2L,6L,9L,0L,6L,4L,3L,5L,3L,4L,0L,5L,0L,2L,1L,5L,0L,8L,3L,5L,0L,0L,7L,0L,9L,4L,5L,2L,2L,1L,2L,3L,8L,7L,5L,3L,8L,3L,0L,4L,2L,7L,1L,4L,2L,4L,0L,3L,2L,0L,4L,0L,7L,2L,5L,5L,2L,4L,9L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011312Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011312.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011312Inst : IEnumerable<long>
{
public static readonly long[] Value=A011312.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011312.Bytes);
public long this[int i]=>Value[i];

public static A011312Inst Instance=new A011312Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011311
{
public static readonly long[] Value={ 1L,2L,3L,0L,0L,7L,5L,5L,0L,5L,5L,7L,7L,9L,7L,1L,2L,5L,3L,6L,6L,3L,0L,0L,5L,4L,9L,6L,1L,1L,7L,0L,8L,1L,6L,7L,9L,7L,7L,8L,5L,0L,8L,9L,6L,8L,7L,5L,9L,4L,4L,1L,8L,7L,8L,5L,4L,0L,5L,4L,9L,6L,7L,1L,3L,9L,3L,4L,6L,2L,9L,7L,7L,0L,7L,6L,8L,3L,2L,7L,4L,9L,5L,5L,5L,0L,2L,2L,3L,1L,7L,3L,1L,9L,6L,6L,4L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011311Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011311.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011311Inst : IEnumerable<long>
{
public static readonly long[] Value=A011311.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011311.Bytes);
public long this[int i]=>Value[i];

public static A011311Inst Instance=new A011311Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011310
{
public static readonly long[] Value={ 1L,2L,5L,3L,4L,5L,1L,0L,7L,1L,7L,2L,3L,0L,9L,0L,0L,1L,4L,1L,4L,2L,1L,3L,9L,1L,4L,7L,5L,6L,1L,5L,3L,6L,4L,9L,8L,9L,4L,5L,4L,5L,7L,1L,6L,4L,3L,0L,1L,7L,5L,9L,0L,5L,8L,6L,5L,2L,4L,7L,5L,1L,9L,5L,6L,3L,2L,4L,5L,1L,5L,0L,2L,5L,6L,5L,5L,6L,3L,7L,0L,7L,8L,2L,5L,4L,4L,5L,9L,9L,7L,4L,0L,4L,7L,5L,7L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011310Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011310.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011310Inst : IEnumerable<long>
{
public static readonly long[] Value=A011310.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011310.Bytes);
public long this[int i]=>Value[i];

public static A011310Inst Instance=new A011310Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011309
{
public static readonly long[] Value={ 1L,2L,8L,2L,0L,8L,8L,8L,5L,3L,9L,8L,6L,8L,1L,5L,4L,4L,0L,4L,4L,8L,5L,3L,0L,7L,6L,2L,9L,1L,5L,5L,9L,9L,4L,8L,2L,5L,8L,2L,0L,8L,8L,5L,4L,8L,9L,4L,7L,0L,0L,2L,4L,2L,4L,8L,2L,2L,5L,0L,6L,4L,6L,2L,0L,9L,3L,6L,9L,8L,4L,1L,4L,4L,1L,6L,6L,0L,7L,0L,7L,6L,7L,8L,6L,0L,6L,4L,7L,6L,4L,8L,1L,6L,0L,9L,7L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011309Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011309.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011309Inst : IEnumerable<long>
{
public static readonly long[] Value=A011309.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011309.Bytes);
public long this[int i]=>Value[i];

public static A011309Inst Instance=new A011309Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011308
{
public static readonly long[] Value={ 1L,3L,1L,7L,9L,8L,0L,6L,2L,9L,2L,1L,3L,0L,0L,2L,2L,3L,9L,7L,7L,5L,9L,1L,7L,7L,4L,1L,9L,8L,8L,2L,9L,6L,2L,7L,7L,0L,8L,2L,9L,7L,6L,7L,3L,9L,9L,6L,1L,3L,7L,4L,6L,4L,3L,5L,9L,2L,4L,6L,6L,7L,2L,9L,8L,6L,9L,1L,4L,3L,9L,0L,7L,8L,3L,0L,0L,8L,6L,4L,8L,0L,6L,9L,0L,3L,8L,4L,5L,9L,0L,7L,9L,7L,0L,8L,0L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011308Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011308.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011308Inst : IEnumerable<long>
{
public static readonly long[] Value=A011308.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011308.Bytes);
public long this[int i]=>Value[i];

public static A011308Inst Instance=new A011308Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011307
{
public static readonly long[] Value={ 1L,3L,6L,4L,2L,6L,1L,6L,0L,1L,8L,2L,1L,3L,6L,5L,9L,2L,9L,5L,8L,6L,0L,3L,5L,2L,7L,5L,2L,3L,9L,6L,1L,1L,5L,8L,4L,4L,3L,9L,4L,6L,5L,0L,5L,7L,6L,3L,5L,0L,7L,5L,6L,3L,5L,6L,5L,7L,0L,8L,6L,5L,5L,2L,4L,2L,6L,8L,0L,0L,3L,9L,7L,7L,7L,1L,5L,4L,5L,7L,1L,5L,7L,6L,0L,0L,0L,7L,8L,1L,3L,3L,7L,8L,8L,0L,6L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011307Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011307.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011307Inst : IEnumerable<long>
{
public static readonly long[] Value=A011307.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011307.Bytes);
public long this[int i]=>Value[i];

public static A011307Inst Instance=new A011307Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011306
{
public static readonly long[] Value={ 1L,4L,2L,6L,1L,6L,1L,6L,3L,5L,2L,2L,7L,3L,7L,8L,8L,4L,0L,4L,8L,4L,1L,2L,0L,6L,8L,5L,4L,5L,1L,4L,4L,2L,5L,6L,6L,7L,2L,9L,7L,0L,3L,9L,8L,7L,6L,4L,5L,1L,6L,7L,1L,7L,4L,3L,1L,0L,5L,7L,6L,8L,3L,6L,7L,8L,8L,0L,7L,3L,6L,8L,3L,7L,0L,2L,5L,4L,5L,6L,0L,9L,5L,5L,8L,2L,9L,5L,1L,5L,2L,3L,4L,9L,8L,8L,4L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011306Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011306.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011306Inst : IEnumerable<long>
{
public static readonly long[] Value=A011306.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011306.Bytes);
public long this[int i]=>Value[i];

public static A011306Inst Instance=new A011306Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011305
{
public static readonly long[] Value={ 1L,5L,1L,3L,0L,8L,5L,7L,4L,9L,4L,2L,2L,9L,0L,1L,5L,8L,8L,7L,8L,4L,0L,5L,9L,9L,4L,0L,9L,6L,8L,7L,7L,5L,8L,1L,6L,8L,7L,2L,5L,2L,4L,3L,6L,9L,9L,9L,8L,9L,1L,6L,1L,7L,7L,1L,8L,0L,9L,3L,0L,6L,9L,3L,9L,6L,0L,6L,6L,8L,5L,1L,0L,9L,1L,5L,0L,1L,5L,0L,4L,3L,0L,7L,2L,7L,7L,2L,5L,7L,3L,1L,7L,2L,1L,5L,2L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011305Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011305.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011305Inst : IEnumerable<long>
{
public static readonly long[] Value=A011305.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011305.Bytes);
public long this[int i]=>Value[i];

public static A011305Inst Instance=new A011305Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011304
{
public static readonly long[] Value={ 1L,1L,2L,7L,3L,7L,8L,2L,0L,4L,1L,5L,7L,8L,3L,3L,0L,2L,4L,1L,4L,3L,0L,7L,8L,0L,1L,9L,8L,1L,3L,4L,3L,4L,7L,5L,3L,4L,5L,0L,8L,6L,3L,7L,6L,6L,5L,1L,8L,8L,9L,1L,9L,2L,6L,8L,6L,9L,3L,5L,9L,1L,2L,2L,7L,4L,7L,0L,7L,2L,5L,0L,1L,9L,5L,5L,3L,9L,3L,6L,2L,2L,8L,8L,2L,1L,7L,9L,8L,8L,9L,7L,3L,3L,4L,6L,7L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011304Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011304.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011304Inst : IEnumerable<long>
{
public static readonly long[] Value=A011304.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011304.Bytes);
public long this[int i]=>Value[i];

public static A011304Inst Instance=new A011304Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011303
{
public static readonly long[] Value={ 1L,1L,3L,4L,5L,1L,4L,7L,3L,6L,2L,5L,2L,4L,0L,1L,5L,5L,1L,0L,8L,5L,0L,6L,3L,5L,0L,8L,8L,5L,6L,9L,4L,3L,5L,2L,8L,9L,1L,8L,1L,4L,3L,2L,6L,7L,8L,4L,5L,9L,3L,0L,7L,6L,5L,5L,8L,3L,3L,4L,4L,1L,0L,9L,0L,3L,0L,1L,9L,6L,6L,1L,4L,4L,4L,4L,7L,1L,0L,2L,5L,1L,3L,7L,3L,6L,2L,9L,1L,9L,7L,1L,9L,5L,9L,5L,9L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011303Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011303.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011303Inst : IEnumerable<long>
{
public static readonly long[] Value=A011303.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011303.Bytes);
public long this[int i]=>Value[i];

public static A011303Inst Instance=new A011303Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011302
{
public static readonly long[] Value={ 1L,1L,4L,2L,4L,9L,7L,2L,1L,2L,5L,9L,8L,3L,1L,5L,1L,7L,5L,4L,4L,0L,1L,4L,5L,3L,1L,5L,6L,0L,0L,6L,2L,9L,1L,4L,1L,0L,1L,7L,4L,8L,2L,1L,0L,1L,3L,0L,3L,7L,7L,7L,7L,1L,2L,7L,2L,5L,1L,0L,9L,9L,2L,1L,2L,8L,2L,9L,1L,2L,7L,7L,5L,4L,6L,3L,7L,0L,8L,5L,0L,3L,0L,6L,0L,7L,4L,2L,8L,9L,5L,6L,6L,0L,4L,6L,6L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011302Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011302.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011302Inst : IEnumerable<long>
{
public static readonly long[] Value=A011302.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011302.Bytes);
public long this[int i]=>Value[i];

public static A011302Inst Instance=new A011302Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011301
{
public static readonly long[] Value={ 1L,1L,5L,1L,4L,8L,5L,2L,8L,7L,1L,7L,9L,4L,9L,6L,3L,1L,7L,8L,4L,5L,5L,0L,4L,5L,6L,8L,1L,3L,2L,4L,7L,4L,0L,7L,1L,6L,3L,1L,1L,7L,8L,0L,4L,8L,2L,7L,4L,8L,4L,4L,9L,2L,3L,9L,0L,2L,1L,9L,2L,4L,6L,4L,0L,4L,6L,6L,3L,0L,2L,2L,5L,4L,6L,2L,4L,7L,8L,3L,3L,4L,1L,8L,3L,7L,6L,6L,4L,4L,3L,4L,8L,8L,6L,8L,6L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011301Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011301.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011301Inst : IEnumerable<long>
{
public static readonly long[] Value=A011301.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011301.Bytes);
public long this[int i]=>Value[i];

public static A011301Inst Instance=new A011301Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011300
{
public static readonly long[] Value={ 1L,1L,6L,1L,6L,8L,1L,4L,1L,8L,7L,7L,1L,7L,4L,8L,1L,4L,8L,1L,5L,9L,2L,5L,0L,1L,7L,3L,7L,4L,8L,4L,0L,2L,1L,1L,5L,3L,2L,5L,2L,7L,1L,0L,1L,2L,3L,8L,5L,5L,7L,6L,2L,2L,1L,7L,6L,0L,1L,1L,7L,6L,9L,9L,3L,0L,8L,2L,1L,2L,5L,3L,3L,1L,8L,1L,9L,9L,6L,6L,9L,3L,0L,9L,2L,7L,6L,6L,8L,6L,1L,9L,7L,4L,6L,2L,0L,4L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011300Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011300.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011300Inst : IEnumerable<long>
{
public static readonly long[] Value=A011300.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011300.Bytes);
public long this[int i]=>Value[i];

public static A011300Inst Instance=new A011300Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011299
{
public static readonly long[] Value={ 1L,1L,7L,3L,3L,4L,6L,2L,2L,1L,1L,9L,3L,4L,0L,5L,0L,6L,7L,4L,4L,8L,2L,1L,8L,7L,8L,5L,6L,6L,6L,6L,9L,6L,5L,6L,7L,2L,1L,6L,6L,4L,9L,1L,6L,3L,0L,3L,2L,5L,5L,7L,4L,9L,9L,7L,1L,2L,6L,3L,6L,0L,0L,0L,8L,9L,7L,7L,2L,8L,4L,7L,8L,5L,4L,9L,9L,4L,1L,7L,8L,3L,1L,7L,3L,3L,1L,2L,2L,0L,0L,7L,2L,3L,8L,2L,4L,8L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011299Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011299.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011299Inst : IEnumerable<long>
{
public static readonly long[] Value=A011299.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011299.Bytes);
public long this[int i]=>Value[i];

public static A011299Inst Instance=new A011299Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011298
{
public static readonly long[] Value={ 1L,1L,8L,6L,8L,2L,0L,9L,1L,6L,7L,4L,7L,2L,1L,4L,8L,2L,0L,2L,5L,5L,2L,6L,3L,6L,1L,7L,6L,9L,4L,6L,7L,0L,4L,7L,5L,5L,1L,4L,7L,5L,3L,1L,7L,4L,9L,3L,7L,7L,7L,1L,3L,0L,0L,9L,9L,4L,4L,6L,9L,9L,1L,0L,7L,5L,0L,9L,6L,5L,9L,5L,4L,3L,0L,5L,8L,2L,9L,6L,8L,0L,5L,5L,0L,2L,0L,5L,3L,6L,7L,7L,5L,3L,6L,0L,4L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011298Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011298.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011298Inst : IEnumerable<long>
{
public static readonly long[] Value=A011298.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011298.Bytes);
public long this[int i]=>Value[i];

public static A011298Inst Instance=new A011298Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011297
{
public static readonly long[] Value={ 1L,2L,0L,2L,5L,6L,1L,0L,3L,9L,8L,7L,8L,1L,8L,4L,3L,0L,5L,7L,6L,8L,2L,9L,6L,6L,5L,0L,0L,4L,3L,5L,1L,5L,4L,2L,4L,3L,8L,9L,8L,2L,6L,9L,3L,1L,6L,2L,1L,5L,2L,3L,7L,0L,1L,3L,1L,4L,1L,5L,0L,5L,1L,2L,1L,3L,9L,3L,9L,2L,6L,1L,1L,5L,3L,7L,3L,6L,0L,6L,9L,4L,5L,3L,6L,8L,3L,3L,5L,3L,0L,9L,2L,1L,6L,8L,6L,2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011297Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011297.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011297Inst : IEnumerable<long>
{
public static readonly long[] Value=A011297.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011297.Bytes);
public long this[int i]=>Value[i];

public static A011297Inst Instance=new A011297Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011296
{
public static readonly long[] Value={ 1L,2L,2L,1L,1L,8L,8L,5L,5L,0L,3L,1L,1L,9L,9L,3L,7L,6L,3L,8L,2L,3L,0L,2L,0L,8L,4L,3L,1L,3L,6L,9L,4L,6L,5L,5L,7L,1L,5L,1L,1L,6L,8L,6L,1L,1L,7L,9L,9L,2L,7L,2L,1L,5L,0L,5L,7L,1L,1L,0L,0L,0L,8L,8L,8L,2L,4L,8L,6L,5L,5L,0L,2L,2L,7L,8L,3L,9L,3L,2L,0L,7L,6L,6L,6L,0L,4L,3L,1L,0L,7L,5L,7L,1L,7L,8L,9L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011296Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011296.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011296Inst : IEnumerable<long>
{
public static readonly long[] Value=A011296.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011296.Bytes);
public long this[int i]=>Value[i];

public static A011296Inst Instance=new A011296Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011295
{
public static readonly long[] Value={ 1L,2L,4L,3L,5L,7L,5L,2L,2L,7L,9L,1L,2L,3L,7L,0L,7L,3L,5L,0L,7L,9L,7L,9L,1L,7L,1L,1L,9L,0L,9L,5L,3L,6L,4L,9L,8L,0L,5L,5L,2L,1L,2L,6L,4L,1L,6L,6L,6L,3L,7L,5L,0L,6L,9L,8L,2L,2L,5L,6L,3L,2L,4L,8L,6L,9L,5L,9L,6L,1L,0L,8L,1L,6L,8L,2L,1L,7L,8L,3L,7L,1L,5L,5L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011295Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011295.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011295Inst : IEnumerable<long>
{
public static readonly long[] Value=A011295.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011295.Bytes);
public long this[int i]=>Value[i];

public static A011295Inst Instance=new A011295Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011294
{
public static readonly long[] Value={ 1L,2L,7L,0L,9L,8L,1L,6L,1L,5L,2L,1L,0L,1L,4L,0L,6L,3L,8L,6L,0L,5L,5L,3L,5L,1L,3L,7L,5L,2L,8L,4L,4L,2L,4L,2L,3L,9L,2L,3L,8L,7L,9L,1L,5L,6L,3L,7L,4L,9L,0L,9L,5L,8L,0L,4L,1L,2L,2L,5L,0L,2L,9L,3L,9L,8L,7L,6L,4L,6L,5L,8L,1L,8L,5L,1L,1L,2L,0L,3L,1L,6L,4L,7L,5L,0L,6L,4L,1L,5L,1L,2L,8L,3L,1L,9L,5L,0L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011294Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011294.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011294Inst : IEnumerable<long>
{
public static readonly long[] Value=A011294.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011294.Bytes);
public long this[int i]=>Value[i];

public static A011294Inst Instance=new A011294Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011261
{
public static readonly long[] Value={ 1L,3L,6L,8L,7L,3L,8L,1L,0L,6L,6L,4L,2L,2L,0L,1L,6L,7L,4L,8L,4L,2L,3L,6L,7L,7L,8L,8L,6L,6L,4L,0L,2L,9L,6L,5L,3L,0L,4L,9L,7L,8L,6L,9L,7L,9L,8L,1L,9L,0L,8L,2L,5L,9L,9L,3L,4L,9L,9L,2L,0L,2L,4L,3L,0L,2L,7L,7L,4L,4L,9L,2L,9L,5L,9L,9L,3L,5L,1L,6L,0L,4L,8L,5L,9L,7L,5L,8L,8L,5L,5L,5L,6L,0L,3L,0L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011261Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011261.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011261Inst : IEnumerable<long>
{
public static readonly long[] Value=A011261.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011261.Bytes);
public long this[int i]=>Value[i];

public static A011261Inst Instance=new A011261Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011260
{
public static readonly long[] Value={ 1L,1L,2L,2L,6L,6L,18L,16L,48L,60L,176L,144L,630L,756L,1800L,2048L,7710L,7776L,27594L,24000L,84672L,120032L,356960L,276480L,1296000L,1719900L,4202496L,4741632L,18407808L,17820000L,69273666L,67108864L,211016256L,336849900L,929275200L,725594112L,3697909056L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011260Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011260.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011260Inst : IEnumerable<long>
{
public static readonly long[] Value=A011260.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011260.Bytes);
public long this[int i]=>Value[i];

public static A011260Inst Instance=new A011260Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011259
{
public static readonly long[] Value={ 1L,1L,0L,9L,5L,6L,9L,4L,7L,2L,0L,6L,7L,8L,4L,5L,0L,0L,8L,4L,8L,9L,3L,7L,8L,3L,5L,7L,7L,3L,0L,6L,3L,6L,6L,6L,6L,4L,5L,5L,6L,7L,3L,1L,6L,5L,4L,2L,2L,1L,8L,5L,4L,1L,0L,8L,9L,6L,1L,3L,7L,1L,6L,4L,3L,9L,3L,1L,5L,5L,7L,6L,1L,3L,7L,7L,1L,9L,8L,1L,1L,9L,5L,7L,3L,7L,4L,8L,4L,2L,3L,9L,0L,9L,0L,7L,6L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011259Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011259.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011259Inst : IEnumerable<long>
{
public static readonly long[] Value=A011259.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011259.Bytes);
public long this[int i]=>Value[i];

public static A011259Inst Instance=new A011259Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011258
{
public static readonly long[] Value={ 1L,1L,1L,5L,6L,5L,7L,9L,1L,7L,7L,6L,1L,5L,4L,3L,6L,6L,6L,8L,8L,5L,8L,0L,9L,9L,9L,4L,0L,1L,9L,1L,1L,2L,2L,0L,8L,5L,4L,3L,1L,9L,6L,8L,4L,7L,6L,8L,1L,6L,8L,4L,2L,9L,5L,9L,4L,1L,1L,4L,3L,1L,1L,2L,1L,7L,4L,7L,9L,4L,2L,6L,8L,0L,1L,4L,5L,4L,6L,2L,6L,7L,8L,0L,0L,4L,2L,5L,6L,9L,1L,3L,0L,9L,4L,6L,5L,3L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011258Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011258.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011258Inst : IEnumerable<long>
{
public static readonly long[] Value=A011258.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011258.Bytes);
public long this[int i]=>Value[i];

public static A011258Inst Instance=new A011258Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011257
{
public static readonly long[] Value={ 1L,14L,30L,51L,105L,170L,194L,248L,264L,364L,405L,418L,477L,595L,679L,714L,760L,780L,1023L,1455L,1463L,1485L,1496L,1512L,1524L,1674L,1715L,1731L,1796L,1804L,2058L,2080L,2651L,2754L,2945L,3080L,3135L,3192L,3410L,3534L,3567L,3596L,3828L,3956L,4064L,4381L,4420L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011257Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011257.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011257Inst : IEnumerable<long>
{
public static readonly long[] Value=A011257.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011257.Bytes);
public long this[int i]=>Value[i];

public static A011257Inst Instance=new A011257Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011256
{
public static readonly long[] Value={ 1L,1L,3L,0L,1L,1L,5L,7L,8L,3L,4L,2L,9L,3L,2L,9L,8L,2L,7L,9L,1L,6L,4L,2L,0L,8L,6L,8L,1L,5L,1L,7L,3L,4L,7L,7L,8L,0L,7L,0L,8L,8L,0L,8L,3L,7L,1L,6L,6L,1L,6L,8L,2L,3L,5L,9L,6L,1L,5L,4L,1L,0L,8L,1L,5L,2L,5L,2L,0L,5L,8L,9L,9L,6L,3L,1L,4L,3L,1L,7L,8L,9L,9L,3L,3L,0L,0L,2L,0L,2L,1L,7L,4L,7L,9L,7L,7L,0L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011256Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011256.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011256Inst : IEnumerable<long>
{
public static readonly long[] Value=A011256.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011256.Bytes);
public long this[int i]=>Value[i];

public static A011256Inst Instance=new A011256Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011255
{
public static readonly long[] Value={ 1L,1L,3L,8L,7L,8L,8L,6L,3L,4L,7L,5L,6L,6L,9L,1L,6L,5L,3L,7L,0L,3L,8L,3L,0L,2L,8L,3L,8L,4L,1L,5L,1L,1L,2L,5L,4L,7L,2L,0L,2L,4L,3L,1L,0L,6L,2L,6L,7L,1L,6L,9L,5L,0L,3L,8L,6L,1L,7L,9L,5L,4L,1L,2L,4L,9L,5L,2L,1L,7L,7L,3L,4L,3L,9L,4L,5L,2L,4L,8L,9L,6L,0L,2L,2L,7L,9L,5L,4L,0L,3L,4L,3L,0L,1L,0L,8L,3L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011255Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011255.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011255Inst : IEnumerable<long>
{
public static readonly long[] Value=A011255.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011255.Bytes);
public long this[int i]=>Value[i];

public static A011255Inst Instance=new A011255Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011254
{
public static readonly long[] Value={ 23760L,59400L,153720L,4563000L,45326160L,113315400L,402831360L,731601000L,803685120L,865950624L,919501200L,1178491680L,3504597120L,3786686400L,6429564000L,14924714400L,25310621952L,26998616736L,53138687040L,86955675840L,513969369984L,1054373308800L,1868445408960L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011254Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011254.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011254Inst : IEnumerable<long>
{
public static readonly long[] Value=A011254.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011254.Bytes);
public long this[int i]=>Value[i];

public static A011254Inst Instance=new A011254Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011253
{
public static readonly long[] Value={ 1L,1L,6L,0L,1L,2L,9L,3L,8L,6L,1L,6L,0L,1L,6L,2L,7L,9L,7L,5L,3L,0L,0L,5L,9L,4L,9L,7L,1L,9L,0L,5L,5L,1L,7L,5L,7L,9L,0L,2L,1L,0L,4L,8L,6L,6L,2L,4L,8L,8L,7L,5L,5L,5L,4L,8L,1L,2L,6L,4L,2L,5L,0L,3L,0L,6L,2L,6L,7L,8L,2L,3L,8L,4L,8L,2L,8L,9L,2L,5L,6L,0L,7L,1L,6L,0L,3L,9L,9L,4L,3L,6L,0L,7L,3L,1L,0L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011253Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011253.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011253Inst : IEnumerable<long>
{
public static readonly long[] Value=A011253.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011253.Bytes);
public long this[int i]=>Value[i];

public static A011253Inst Instance=new A011253Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011252
{
public static readonly long[] Value={ 1L,1L,7L,3L,4L,6L,0L,4L,6L,0L,0L,0L,4L,6L,2L,6L,3L,9L,1L,0L,9L,5L,4L,4L,1L,7L,5L,2L,9L,8L,5L,3L,2L,6L,9L,8L,9L,1L,2L,8L,8L,2L,3L,6L,0L,9L,4L,1L,1L,6L,7L,4L,0L,9L,5L,2L,5L,7L,1L,4L,0L,1L,1L,8L,0L,5L,6L,3L,8L,9L,3L,4L,9L,7L,6L,5L,5L,2L,8L,3L,5L,2L,2L,6L,5L,0L,2L,2L,0L,1L,3L,5L,5L,5L,4L,4L,5L,6L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011252Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011252.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011252Inst : IEnumerable<long>
{
public static readonly long[] Value=A011252.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011252.Bytes);
public long this[int i]=>Value[i];

public static A011252Inst Instance=new A011252Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011251
{
public static readonly long[] Value={ 312L,560L,588L,1400L,85632L,147492L,556160L,569328L,1590816L,2013216L,3343776L,4695456L,9745728L,12558912L,22013952L,23336172L,30002960L,52021242L,75007400L,137617728L,153587720L,699117024L,904683264L,2468053248L,2834395104L,21669802880L,48444151296L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011251Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011251.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011251Inst : IEnumerable<long>
{
public static readonly long[] Value=A011251.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011251.Bytes);
public long this[int i]=>Value[i];

public static A011251Inst Instance=new A011251Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011250
{
public static readonly long[] Value={ 1L,2L,0L,8L,0L,8L,9L,4L,4L,4L,4L,0L,4L,4L,4L,7L,3L,1L,3L,2L,8L,9L,2L,4L,2L,2L,1L,0L,4L,7L,6L,2L,4L,7L,5L,6L,5L,0L,0L,3L,6L,8L,1L,3L,5L,7L,9L,0L,4L,2L,6L,6L,1L,9L,4L,1L,5L,1L,1L,3L,6L,0L,7L,1L,2L,3L,5L,8L,5L,6L,3L,1L,7L,0L,5L,0L,3L,5L,0L,6L,4L,7L,0L,9L,4L,3L,8L,2L,5L,8L,6L,5L,6L,8L,2L,6L,8L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011250Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011250.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011250Inst : IEnumerable<long>
{
public static readonly long[] Value=A011250.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011250.Bytes);
public long this[int i]=>Value[i];

public static A011250Inst Instance=new A011250Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011249
{
public static readonly long[] Value={ 1L,2L,3L,1L,1L,4L,4L,4L,1L,3L,3L,4L,4L,9L,1L,6L,2L,8L,4L,4L,9L,9L,3L,9L,3L,0L,6L,9L,1L,6L,7L,7L,4L,3L,1L,0L,9L,8L,7L,6L,1L,3L,7L,7L,6L,1L,1L,0L,0L,8L,1L,7L,7L,9L,4L,3L,3L,7L,0L,6L,5L,5L,3L,8L,2L,4L,6L,1L,0L,0L,7L,1L,9L,7L,1L,9L,3L,5L,8L,4L,5L,8L,4L,0L,4L,0L,2L,2L,7L,4L,9L,6L,5L,0L,8L,9L,4L,1L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011249Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011249.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011249Inst : IEnumerable<long>
{
public static readonly long[] Value=A011249.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011249.Bytes);
public long this[int i]=>Value[i];

public static A011249Inst Instance=new A011249Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011248
{
public static readonly BigInteger[] Value={ 2L,2L,10L,122L,2770L,101042L,5405530L,398721962L,38783024290L,4809759350882L,740742376475050L,138697748786275802L,BigInteger.Parse("31029068327114173810"),BigInteger.Parse("8174145018586247784722") };
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
public class A011248Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011248.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011248Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A011248.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A011248.Bytes);
public BigInteger this[int i]=>Value[i];

public static A011248Inst Instance=new A011248Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011247
{
public static readonly long[] Value={ 1L,2L,9L,6L,8L,3L,9L,5L,5L,4L,6L,5L,1L,0L,0L,9L,6L,6L,5L,9L,3L,3L,7L,5L,4L,1L,1L,7L,7L,9L,2L,4L,5L,1L,1L,5L,9L,8L,3L,5L,3L,4L,5L,1L,4L,9L,4L,2L,4L,9L,6L,5L,5L,1L,2L,8L,0L,7L,7L,9L,0L,5L,2L,2L,6L,2L,9L,0L,1L,4L,6L,2L,5L,6L,4L,7L,3L,4L,4L,3L,5L,5L,6L,1L,4L,5L,9L,5L,9L,0L,7L,5L,7L,2L,3L,9L,5L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011247Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011247.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011247Inst : IEnumerable<long>
{
public static readonly long[] Value=A011247.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011247.Bytes);
public long this[int i]=>Value[i];

public static A011247Inst Instance=new A011247Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011246
{
public static readonly long[] Value={ 1L,3L,4L,5L,9L,0L,0L,1L,9L,2L,6L,3L,2L,3L,5L,6L,1L,3L,1L,9L,4L,2L,8L,3L,2L,6L,0L,3L,7L,5L,0L,9L,4L,1L,9L,0L,4L,3L,6L,6L,2L,4L,7L,0L,2L,6L,7L,7L,7L,4L,7L,6L,7L,2L,3L,2L,5L,0L,2L,8L,3L,1L,3L,1L,8L,8L,8L,5L,0L,0L,2L,0L,8L,2L,9L,3L,5L,4L,8L,7L,5L,2L,9L,3L,3L,9L,8L,8L,1L,9L,5L,3L,8L,7L,7L,1L,9L,8L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011246Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011246.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011246Inst : IEnumerable<long>
{
public static readonly long[] Value=A011246.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011246.Bytes);
public long this[int i]=>Value[i];

public static A011246Inst Instance=new A011246Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011229
{
public static readonly long[] Value={ 1L,0L,9L,3L,7L,2L,3L,5L,4L,7L,7L,2L,6L,4L,4L,2L,3L,8L,3L,2L,5L,3L,4L,0L,7L,5L,4L,8L,3L,4L,5L,8L,9L,0L,6L,5L,3L,0L,6L,6L,5L,4L,7L,4L,9L,3L,5L,1L,8L,8L,2L,3L,4L,4L,0L,6L,4L,9L,4L,0L,7L,6L,0L,7L,7L,6L,4L,9L,5L,9L,0L,5L,0L,2L,3L,1L,7L,3L,1L,2L,2L,8L,1L,7L,6L,8L,4L,3L,3L,0L,2L,6L,2L,6L,9L,8L,4L,3L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011229Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011229.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011229Inst : IEnumerable<long>
{
public static readonly long[] Value=A011229.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011229.Bytes);
public long this[int i]=>Value[i];

public static A011229Inst Instance=new A011229Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011228
{
public static readonly long[] Value={ 1L,0L,9L,8L,8L,9L,2L,8L,0L,2L,7L,6L,5L,5L,2L,4L,7L,0L,5L,4L,7L,1L,1L,1L,2L,8L,4L,8L,2L,5L,3L,5L,2L,5L,8L,4L,1L,7L,5L,6L,4L,9L,6L,2L,5L,8L,3L,4L,2L,1L,1L,5L,6L,3L,6L,1L,9L,9L,7L,0L,8L,9L,7L,0L,0L,0L,1L,2L,0L,6L,7L,8L,6L,3L,6L,9L,0L,4L,1L,6L,6L,1L,2L,5L,1L,4L,0L,7L,3L,8L,9L,4L,7L,4L,8L,5L,6L,0L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011228Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011228.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011228Inst : IEnumerable<long>
{
public static readonly long[] Value=A011228.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011228.Bytes);
public long this[int i]=>Value[i];

public static A011228Inst Instance=new A011228Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011227
{
public static readonly long[] Value={ 1L,1L,0L,4L,6L,6L,5L,0L,7L,8L,5L,9L,7L,4L,9L,5L,2L,9L,4L,2L,7L,0L,9L,7L,2L,7L,9L,1L,7L,8L,0L,3L,7L,0L,7L,1L,6L,2L,0L,1L,0L,5L,3L,5L,8L,5L,9L,5L,8L,3L,8L,8L,6L,5L,3L,1L,3L,5L,0L,5L,3L,3L,6L,7L,3L,9L,7L,8L,1L,5L,4L,1L,5L,5L,2L,2L,8L,5L,3L,7L,2L,2L,2L,9L,7L,7L,4L,1L,6L,5L,2L,4L,8L,3L,6L,7L,2L,2L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011227Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011227.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011227Inst : IEnumerable<long>
{
public static readonly long[] Value=A011227.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011227.Bytes);
public long this[int i]=>Value[i];

public static A011227Inst Instance=new A011227Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011226
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,5L,2L,3L,3L,4L,2L,9L,7L,0L,4L,2L,5L,1L,8L,7L,6L,3L,3L,1L,7L,4L,9L,3L,8L,3L,1L,8L,3L,9L,1L,0L,1L,1L,0L,9L,2L,2L,8L,7L,4L,1L,7L,9L,4L,6L,7L,7L,4L,7L,1L,7L,8L,4L,5L,8L,5L,7L,3L,0L,3L,4L,9L,6L,4L,3L,3L,6L,9L,0L,3L,1L,5L,0L,6L,7L,0L,2L,1L,0L,6L,6L,2L,4L,7L,8L,3L,0L,4L,9L,3L,0L,5L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011226Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011226.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011226Inst : IEnumerable<long>
{
public static readonly long[] Value=A011226.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011226.Bytes);
public long this[int i]=>Value[i];

public static A011226Inst Instance=new A011226Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011225
{
public static readonly long[] Value={ 1L,1L,1L,8L,4L,9L,6L,0L,4L,5L,9L,7L,3L,8L,2L,1L,8L,5L,9L,9L,2L,8L,7L,5L,5L,8L,0L,6L,5L,9L,9L,5L,4L,2L,3L,1L,6L,1L,0L,4L,6L,3L,6L,8L,2L,0L,5L,6L,7L,5L,7L,7L,3L,4L,8L,5L,6L,3L,5L,1L,5L,0L,1L,6L,7L,9L,9L,7L,8L,7L,0L,0L,4L,7L,9L,7L,5L,2L,6L,0L,0L,4L,6L,4L,1L,1L,0L,1L,2L,1L,5L,6L,8L,3L,4L,4L,4L,1L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011225Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011225.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011225Inst : IEnumerable<long>
{
public static readonly long[] Value=A011225.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011225.Bytes);
public long this[int i]=>Value[i];

public static A011225Inst Instance=new A011225Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011224
{
public static readonly long[] Value={ 1L,1L,2L,6L,8L,7L,7L,6L,1L,0L,1L,9L,0L,8L,2L,6L,4L,2L,4L,8L,3L,0L,0L,9L,1L,3L,9L,0L,1L,5L,3L,1L,0L,5L,7L,3L,9L,4L,6L,5L,0L,2L,8L,5L,8L,3L,5L,9L,1L,9L,6L,2L,3L,9L,1L,8L,0L,3L,5L,1L,7L,7L,0L,5L,7L,0L,3L,0L,3L,1L,8L,5L,2L,5L,0L,2L,2L,8L,7L,1L,9L,9L,3L,2L,6L,5L,2L,0L,1L,7L,1L,2L,5L,8L,0L,5L,3L,1L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011224Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011224.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011224Inst : IEnumerable<long>
{
public static readonly long[] Value=A011224.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011224.Bytes);
public long this[int i]=>Value[i];

public static A011224Inst Instance=new A011224Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011223
{
public static readonly long[] Value={ 1L,1L,3L,6L,5L,3L,3L,4L,7L,6L,0L,0L,9L,7L,2L,4L,3L,2L,0L,1L,7L,8L,0L,6L,0L,1L,1L,0L,6L,3L,8L,8L,1L,4L,3L,7L,0L,8L,6L,9L,0L,8L,5L,1L,0L,0L,1L,9L,6L,8L,9L,5L,2L,2L,3L,2L,0L,2L,0L,3L,9L,1L,2L,3L,2L,5L,6L,3L,3L,2L,3L,5L,4L,5L,4L,3L,1L,8L,1L,0L,9L,1L,7L,6L,7L,0L,4L,0L,0L,5L,6L,9L,8L,8L,2L,9L,7L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011223Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011223.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011223Inst : IEnumerable<long>
{
public static readonly long[] Value=A011223.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011223.Bytes);
public long this[int i]=>Value[i];

public static A011223Inst Instance=new A011223Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011222
{
public static readonly long[] Value={ 1L,1L,4L,7L,7L,7L,7L,7L,1L,5L,4L,3L,4L,7L,9L,8L,6L,0L,3L,0L,5L,8L,7L,6L,5L,7L,4L,2L,5L,3L,2L,6L,0L,1L,6L,4L,1L,2L,2L,7L,3L,9L,2L,4L,5L,7L,1L,1L,5L,2L,7L,2L,4L,5L,0L,6L,3L,0L,6L,2L,9L,1L,9L,0L,7L,6L,6L,8L,1L,5L,4L,8L,9L,9L,3L,1L,9L,6L,8L,7L,1L,7L,3L,2L,6L,2L,7L,0L,0L,9L,4L,6L,1L,0L,9L,7L,5L,6L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011222Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011222.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011222Inst : IEnumerable<long>
{
public static readonly long[] Value=A011222.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011222.Bytes);
public long this[int i]=>Value[i];

public static A011222Inst Instance=new A011222Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011221
{
public static readonly long[] Value={ 1L,1L,6L,1L,0L,3L,6L,6L,7L,2L,3L,7L,3L,9L,9L,4L,2L,5L,1L,9L,3L,7L,9L,6L,3L,1L,6L,7L,7L,2L,1L,7L,3L,4L,9L,8L,1L,0L,3L,8L,2L,9L,3L,8L,6L,4L,0L,5L,2L,9L,1L,7L,2L,3L,0L,3L,5L,1L,6L,7L,8L,8L,3L,5L,9L,6L,5L,6L,1L,5L,7L,3L,0L,2L,0L,1L,3L,7L,4L,6L,1L,7L,4L,6L,7L,1L,0L,2L,0L,1L,9L,3L,8L,3L,0L,6L,8L,9L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011221Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011221.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011221Inst : IEnumerable<long>
{
public static readonly long[] Value=A011221.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011221.Bytes);
public long this[int i]=>Value[i];

public static A011221Inst Instance=new A011221Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011220
{
public static readonly long[] Value={ 1L,1L,7L,6L,9L,0L,3L,9L,5L,6L,2L,4L,2L,8L,5L,2L,7L,0L,8L,9L,2L,5L,3L,2L,6L,4L,2L,1L,6L,8L,1L,7L,9L,7L,8L,5L,2L,8L,3L,1L,9L,3L,7L,8L,1L,2L,9L,3L,8L,4L,4L,4L,3L,1L,3L,4L,0L,3L,0L,2L,7L,0L,1L,8L,9L,6L,9L,9L,7L,9L,2L,8L,9L,8L,5L,4L,3L,0L,0L,5L,2L,0L,3L,9L,5L,4L,6L,1L,6L,0L,4L,3L,9L,3L,9L,4L,6L,9L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011220Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011220.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011220Inst : IEnumerable<long>
{
public static readonly long[] Value=A011220.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011220.Bytes);
public long this[int i]=>Value[i];

public static A011220Inst Instance=new A011220Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011219
{
public static readonly long[] Value={ 1L,1L,9L,6L,2L,3L,1L,1L,9L,8L,8L,5L,1L,3L,1L,5L,4L,8L,9L,7L,3L,3L,8L,1L,9L,1L,4L,3L,4L,1L,3L,7L,7L,3L,6L,7L,1L,5L,3L,7L,5L,4L,9L,9L,1L,7L,4L,1L,1L,5L,8L,7L,1L,1L,5L,7L,5L,5L,6L,7L,5L,7L,6L,1L,7L,8L,5L,2L,8L,5L,5L,7L,0L,5L,6L,6L,2L,9L,9L,4L,1L,7L,6L,8L,2L,0L,2L,4L,4L,6L,8L,9L,9L,3L,4L,9L,0L,2L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011219Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011219.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011219Inst : IEnumerable<long>
{
public static readonly long[] Value=A011219.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011219.Bytes);
public long this[int i]=>Value[i];

public static A011219Inst Instance=new A011219Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011218
{
public static readonly long[] Value={ 1L,2L,2L,0L,2L,8L,4L,9L,3L,5L,8L,7L,2L,8L,1L,0L,4L,5L,6L,0L,5L,7L,9L,5L,4L,8L,5L,1L,0L,1L,1L,8L,3L,8L,3L,2L,4L,0L,1L,7L,3L,5L,8L,4L,6L,9L,3L,2L,6L,1L,3L,2L,5L,0L,7L,0L,1L,9L,7L,3L,6L,0L,1L,4L,7L,6L,3L,2L,7L,7L,5L,9L,7L,0L,5L,7L,7L,3L,2L,4L,7L,4L,2L,8L,9L,1L,2L,0L,0L,9L,8L,4L,8L,9L,7L,6L,6L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011218Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011218.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011218Inst : IEnumerable<long>
{
public static readonly long[] Value=A011218.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011218.Bytes);
public long this[int i]=>Value[i];

public static A011218Inst Instance=new A011218Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011217
{
public static readonly long[] Value={ 1L,2L,5L,1L,0L,3L,3L,4L,0L,4L,8L,5L,9L,0L,7L,3L,8L,2L,3L,6L,7L,8L,0L,4L,3L,7L,1L,7L,7L,7L,9L,8L,4L,7L,2L,5L,2L,8L,8L,8L,5L,6L,1L,0L,6L,1L,8L,6L,1L,1L,5L,2L,4L,2L,3L,8L,5L,8L,8L,7L,9L,6L,6L,2L,6L,3L,3L,3L,1L,4L,6L,0L,5L,0L,4L,5L,4L,0L,0L,3L,9L,1L,1L,7L,7L,6L,7L,3L,0L,4L,4L,3L,7L,5L,6L,5L,8L,5L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011217Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011217.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011217Inst : IEnumerable<long>
{
public static readonly long[] Value=A011217.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011217.Bytes);
public long this[int i]=>Value[i];

public static A011217Inst Instance=new A011217Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011216
{
public static readonly long[] Value={ 1L,2L,9L,1L,7L,0L,8L,3L,4L,2L,0L,9L,0L,7L,4L,6L,6L,0L,6L,8L,2L,7L,5L,0L,9L,7L,5L,5L,3L,6L,5L,4L,7L,7L,9L,8L,1L,9L,0L,7L,0L,6L,8L,7L,3L,3L,4L,5L,9L,7L,3L,7L,3L,6L,2L,8L,1L,1L,4L,5L,6L,0L,7L,1L,9L,0L,8L,5L,0L,5L,1L,7L,8L,4L,9L,0L,8L,8L,1L,2L,1L,6L,6L,6L,9L,3L,4L,0L,3L,4L,4L,4L,0L,9L,5L,0L,8L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011216Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011216.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011216Inst : IEnumerable<long>
{
public static readonly long[] Value=A011216.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011216.Bytes);
public long this[int i]=>Value[i];

public static A011216Inst Instance=new A011216Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011215
{
public static readonly long[] Value={ 1L,3L,4L,8L,0L,0L,6L,1L,5L,4L,5L,9L,7L,2L,7L,7L,6L,6L,7L,3L,7L,4L,2L,3L,6L,3L,1L,3L,9L,0L,3L,0L,7L,8L,6L,7L,5L,5L,3L,6L,4L,9L,7L,8L,3L,0L,2L,6L,6L,4L,6L,2L,2L,8L,4L,6L,6L,6L,3L,0L,1L,8L,8L,3L,3L,6L,7L,2L,7L,5L,7L,7L,8L,7L,7L,6L,5L,5L,4L,8L,1L,4L,9L,2L,6L,8L,6L,8L,0L,2L,3L,8L,4L,2L,4L,1L,3L,5L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011215Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011215.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011215Inst : IEnumerable<long>
{
public static readonly long[] Value=A011215.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011215.Bytes);
public long this[int i]=>Value[i];

public static A011215Inst Instance=new A011215Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011214
{
public static readonly long[] Value={ 1L,0L,8L,3L,7L,9L,8L,3L,8L,6L,7L,3L,4L,3L,6L,8L,1L,3L,9L,8L,3L,9L,2L,3L,3L,4L,8L,4L,9L,2L,6L,4L,8L,6L,5L,5L,5L,4L,7L,3L,3L,8L,7L,2L,8L,4L,3L,3L,5L,9L,7L,0L,5L,6L,7L,2L,7L,7L,1L,1L,6L,9L,8L,6L,5L,7L,6L,4L,5L,8L,8L,6L,5L,6L,1L,5L,7L,5L,0L,3L,1L,2L,5L,1L,0L,8L,5L,0L,0L,6L,8L,4L,3L,2L,1L,2L,1L,7L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011214Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011214.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011214Inst : IEnumerable<long>
{
public static readonly long[] Value=A011214.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011214.Bytes);
public long this[int i]=>Value[i];

public static A011214Inst Instance=new A011214Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011213
{
public static readonly long[] Value={ 1L,0L,8L,8L,3L,9L,8L,4L,0L,0L,7L,3L,0L,3L,8L,7L,2L,4L,2L,0L,7L,5L,6L,9L,1L,6L,8L,0L,2L,9L,2L,1L,5L,5L,7L,2L,7L,6L,3L,6L,0L,9L,1L,8L,6L,6L,3L,1L,5L,2L,2L,2L,4L,8L,9L,9L,1L,9L,1L,0L,8L,7L,7L,6L,9L,7L,6L,5L,7L,1L,1L,9L,1L,8L,0L,9L,1L,0L,4L,6L,9L,2L,8L,3L,5L,0L,2L,4L,7L,4L,9L,6L,8L,1L,3L,7L,5L,8L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011213Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011213.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011213Inst : IEnumerable<long>
{
public static readonly long[] Value=A011213.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011213.Bytes);
public long this[int i]=>Value[i];

public static A011213Inst Instance=new A011213Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011212
{
public static readonly long[] Value={ 1L,0L,9L,3L,5L,3L,2L,4L,2L,9L,5L,6L,0L,4L,5L,9L,7L,8L,5L,0L,2L,2L,9L,5L,2L,0L,8L,5L,5L,0L,4L,9L,2L,0L,1L,0L,8L,5L,5L,9L,7L,8L,1L,5L,3L,3L,9L,5L,8L,3L,7L,1L,6L,0L,5L,0L,6L,9L,4L,4L,9L,9L,5L,0L,8L,2L,4L,9L,8L,6L,8L,9L,1L,5L,2L,0L,1L,2L,9L,9L,9L,1L,5L,0L,5L,5L,1L,4L,4L,1L,0L,1L,4L,3L,2L,0L,4L,7L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011212Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011212.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011212Inst : IEnumerable<long>
{
public static readonly long[] Value=A011212.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011212.Bytes);
public long this[int i]=>Value[i];

public static A011212Inst Instance=new A011212Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011211
{
public static readonly long[] Value={ 1L,0L,9L,9L,2L,9L,9L,1L,2L,5L,8L,1L,0L,3L,7L,9L,5L,3L,3L,4L,7L,8L,4L,2L,2L,2L,4L,2L,4L,8L,0L,9L,4L,1L,6L,7L,8L,2L,4L,3L,1L,5L,3L,9L,7L,7L,1L,2L,3L,9L,0L,3L,2L,5L,7L,3L,4L,2L,7L,2L,4L,7L,8L,4L,2L,9L,8L,9L,4L,7L,8L,2L,5L,3L,6L,4L,6L,6L,7L,2L,8L,2L,6L,6L,5L,4L,2L,2L,7L,7L,5L,1L,5L,6L,2L,1L,0L,2L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011211Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011211.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011211Inst : IEnumerable<long>
{
public static readonly long[] Value=A011211.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011211.Bytes);
public long this[int i]=>Value[i];

public static A011211Inst Instance=new A011211Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011210
{
public static readonly long[] Value={ 1L,1L,0L,5L,8L,2L,3L,0L,1L,7L,0L,3L,0L,2L,3L,5L,1L,9L,6L,7L,3L,2L,3L,1L,3L,1L,7L,6L,9L,0L,4L,2L,2L,0L,5L,8L,2L,8L,9L,0L,9L,6L,6L,9L,9L,0L,1L,4L,7L,5L,0L,3L,2L,7L,6L,4L,1L,8L,0L,6L,5L,3L,9L,1L,8L,5L,5L,3L,4L,5L,3L,4L,5L,1L,8L,3L,9L,9L,3L,4L,6L,0L,0L,1L,3L,4L,6L,6L,1L,1L,2L,8L,2L,6L,2L,5L,6L,1L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011210Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011210.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011210Inst : IEnumerable<long>
{
public static readonly long[] Value=A011210.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011210.Bytes);
public long this[int i]=>Value[i];

public static A011210Inst Instance=new A011210Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011209
{
public static readonly long[] Value={ 1L,1L,1L,3L,2L,6L,3L,5L,7L,6L,8L,4L,4L,8L,0L,3L,3L,9L,4L,1L,4L,5L,9L,8L,7L,2L,8L,1L,9L,4L,0L,2L,3L,0L,5L,5L,6L,7L,5L,7L,9L,2L,2L,2L,1L,3L,8L,6L,4L,3L,1L,1L,9L,0L,7L,3L,4L,6L,2L,1L,0L,7L,9L,0L,3L,1L,0L,5L,9L,1L,6L,8L,8L,1L,1L,6L,1L,3L,7L,0L,0L,9L,3L,7L,5L,4L,6L,6L,4L,2L,4L,2L,2L,4L,7L,0L,2L,9L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011209Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011209.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011209Inst : IEnumerable<long>
{
public static readonly long[] Value=A011209.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011209.Bytes);
public long this[int i]=>Value[i];

public static A011209Inst Instance=new A011209Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011208
{
public static readonly long[] Value={ 1L,1L,2L,1L,8L,2L,8L,3L,9L,6L,2L,5L,4L,0L,0L,2L,2L,7L,0L,2L,9L,3L,8L,7L,3L,9L,0L,2L,7L,3L,5L,1L,5L,2L,2L,4L,7L,8L,1L,1L,0L,5L,5L,9L,6L,6L,2L,2L,7L,6L,1L,3L,2L,0L,2L,5L,6L,0L,0L,3L,6L,4L,7L,2L,7L,1L,0L,7L,0L,4L,1L,5L,9L,3L,5L,3L,3L,8L,4L,9L,3L,5L,0L,1L,6L,9L,5L,6L,4L,0L,6L,5L,5L,4L,2L,6L,7L,4L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011208Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011208.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011208Inst : IEnumerable<long>
{
public static readonly long[] Value=A011208.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011208.Bytes);
public long this[int i]=>Value[i];

public static A011208Inst Instance=new A011208Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011207
{
public static readonly long[] Value={ 1L,1L,3L,1L,7L,9L,2L,7L,9L,1L,1L,5L,2L,7L,8L,6L,6L,3L,2L,6L,0L,5L,7L,8L,2L,2L,7L,7L,6L,4L,2L,9L,7L,9L,7L,9L,0L,1L,7L,9L,8L,6L,6L,9L,6L,3L,6L,2L,9L,4L,7L,9L,0L,0L,7L,9L,3L,0L,9L,8L,2L,3L,7L,0L,2L,5L,1L,3L,6L,1L,9L,7L,5L,4L,1L,8L,7L,4L,4L,2L,8L,5L,4L,5L,8L,6L,5L,4L,7L,2L,0L,8L,6L,9L,1L,7L,0L,3L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011207Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011207.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011207Inst : IEnumerable<long>
{
public static readonly long[] Value=A011207.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011207.Bytes);
public long this[int i]=>Value[i];

public static A011207Inst Instance=new A011207Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011206
{
public static readonly long[] Value={ 1L,1L,4L,3L,5L,2L,9L,8L,3L,6L,0L,8L,2L,9L,2L,0L,3L,0L,9L,2L,2L,6L,7L,8L,7L,8L,1L,6L,2L,5L,5L,0L,7L,8L,8L,9L,7L,8L,7L,4L,8L,3L,3L,8L,9L,5L,3L,0L,8L,8L,4L,1L,3L,5L,2L,7L,1L,9L,8L,5L,0L,2L,0L,7L,6L,6L,9L,9L,1L,3L,5L,6L,3L,2L,1L,5L,3L,6L,3L,0L,4L,2L,1L,1L,2L,2L,3L,6L,7L,1L,3L,8L,5L,3L,7L,9L,3L,4L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011206Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011206.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011206Inst : IEnumerable<long>
{
public static readonly long[] Value=A011206.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011206.Bytes);
public long this[int i]=>Value[i];

public static A011206Inst Instance=new A011206Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011205
{
public static readonly long[] Value={ 1L,1L,5L,7L,5L,5L,7L,9L,1L,1L,7L,7L,0L,6L,5L,4L,5L,6L,8L,6L,4L,2L,7L,2L,5L,7L,8L,0L,4L,7L,9L,1L,2L,7L,3L,2L,3L,2L,0L,4L,6L,5L,5L,3L,4L,7L,5L,1L,5L,2L,3L,6L,6L,4L,3L,4L,5L,7L,7L,5L,6L,7L,8L,8L,0L,4L,5L,7L,1L,2L,8L,9L,8L,9L,9L,0L,5L,8L,4L,2L,1L,3L,1L,2L,8L,7L,3L,6L,7L,0L,6L,8L,7L,2L,5L,5L,4L,4L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011205Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011205.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011205Inst : IEnumerable<long>
{
public static readonly long[] Value=A011205.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011205.Bytes);
public long this[int i]=>Value[i];

public static A011205Inst Instance=new A011205Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011204
{
public static readonly long[] Value={ 1L,1L,7L,4L,6L,1L,8L,9L,4L,3L,0L,8L,8L,0L,1L,9L,0L,0L,5L,9L,1L,4L,4L,6L,3L,6L,6L,5L,6L,9L,1L,8L,9L,8L,9L,0L,1L,6L,7L,3L,7L,2L,3L,0L,1L,8L,7L,5L,7L,3L,7L,4L,6L,6L,9L,6L,8L,1L,5L,8L,6L,2L,1L,9L,3L,7L,1L,7L,3L,3L,3L,1L,0L,8L,4L,3L,8L,0L,2L,0L,7L,8L,5L,8L,8L,3L,0L,3L,4L,6L,7L,0L,8L,8L,5L,4L,9L,7L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011204Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011204.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011204Inst : IEnumerable<long>
{
public static readonly long[] Value=A011204.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011204.Bytes);
public long this[int i]=>Value[i];

public static A011204Inst Instance=new A011204Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011203
{
public static readonly long[] Value={ 1L,1L,9L,5L,8L,1L,3L,1L,7L,4L,5L,0L,0L,4L,0L,1L,9L,4L,1L,4L,6L,0L,0L,4L,8L,4L,0L,0L,2L,5L,3L,5L,9L,5L,6L,2L,2L,3L,4L,3L,9L,4L,8L,2L,6L,4L,2L,7L,7L,8L,9L,6L,9L,7L,2L,4L,4L,5L,6L,9L,7L,9L,1L,7L,0L,1L,9L,5L,2L,2L,0L,3L,0L,3L,3L,0L,5L,6L,9L,5L,3L,0L,4L,9L,3L,4L,7L,9L,2L,5L,0L,3L,7L,5L,0L,4L,3L,1L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011203Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011203.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011203Inst : IEnumerable<long>
{
public static readonly long[] Value=A011203.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011203.Bytes);
public long this[int i]=>Value[i];

public static A011203Inst Instance=new A011203Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011202
{
public static readonly long[] Value={ 1L,2L,2L,2L,8L,4L,4L,5L,4L,4L,9L,9L,3L,8L,5L,1L,8L,4L,1L,9L,4L,1L,1L,4L,4L,3L,6L,4L,4L,6L,7L,6L,0L,1L,5L,3L,1L,4L,2L,2L,4L,2L,1L,5L,5L,2L,3L,5L,4L,0L,8L,0L,2L,3L,3L,9L,8L,5L,8L,2L,5L,1L,6L,9L,8L,5L,1L,6L,5L,2L,9L,7L,5L,6L,9L,3L,6L,5L,4L,7L,5L,2L,6L,4L,1L,7L,1L,7L,4L,0L,4L,6L,0L,2L,4L,8L,7L,0L,8L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011202Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011202.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011202Inst : IEnumerable<long>
{
public static readonly long[] Value=A011202.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011202.Bytes);
public long this[int i]=>Value[i];

public static A011202Inst Instance=new A011202Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011201
{
public static readonly long[] Value={ 1L,2L,5L,8L,4L,9L,8L,9L,5L,0L,6L,4L,1L,8L,2L,6L,7L,3L,4L,9L,9L,2L,7L,8L,7L,1L,7L,1L,1L,7L,7L,7L,1L,3L,8L,9L,4L,8L,1L,8L,6L,8L,0L,4L,8L,1L,5L,0L,6L,7L,1L,8L,1L,9L,6L,7L,0L,7L,4L,7L,2L,5L,7L,8L,5L,6L,2L,5L,5L,8L,2L,5L,4L,5L,9L,2L,3L,4L,8L,5L,7L,1L,1L,5L,6L,4L,5L,9L,3L,6L,3L,4L,7L,8L,8L,6L,4L,9L,2L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011201Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011201.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011201Inst : IEnumerable<long>
{
public static readonly long[] Value=A011201.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011201.Bytes);
public long this[int i]=>Value[i];

public static A011201Inst Instance=new A011201Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011200
{
public static readonly long[] Value={ 1L,3L,0L,7L,6L,6L,0L,4L,8L,6L,0L,1L,1L,8L,3L,0L,5L,9L,1L,2L,2L,9L,2L,3L,1L,6L,9L,4L,3L,4L,0L,2L,0L,3L,1L,2L,5L,1L,6L,1L,7L,8L,4L,5L,4L,9L,3L,2L,3L,5L,8L,9L,8L,1L,1L,0L,7L,5L,3L,6L,8L,9L,5L,9L,7L,4L,2L,4L,6L,9L,8L,2L,9L,1L,2L,3L,2L,4L,7L,0L,4L,4L,2L,5L,4L,3L,3L,9L,9L,2L,5L,9L,1L,6L,5L,0L,7L,0L,9L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011200Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011200.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011200Inst : IEnumerable<long>
{
public static readonly long[] Value=A011200.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011200.Bytes);
public long this[int i]=>Value[i];

public static A011200Inst Instance=new A011200Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011199
{
public static readonly long[] Value={ 1L,24L,105L,280L,585L,1056L,1729L,2640L,3825L,5320L,7161L,9384L,12025L,15120L,18705L,22816L,27489L,32760L,38665L,45240L,52521L,60544L,69345L,78960L,89425L,100776L,113049L,126280L,140505L,155760L,172081L,189504L,208065L,227800L,248745L,270936L,294409L,319200L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011199Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011199.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011199Inst : IEnumerable<long>
{
public static readonly long[] Value=A011199.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011199.Bytes);
public long this[int i]=>Value[i];

public static A011199Inst Instance=new A011199Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011198
{
public static readonly long[] Value={ 1L,0L,7L,5L,6L,9L,0L,5L,8L,6L,2L,2L,0L,1L,8L,2L,4L,7L,4L,2L,3L,1L,4L,0L,0L,7L,7L,6L,4L,6L,4L,0L,9L,2L,1L,3L,5L,1L,3L,3L,7L,5L,9L,9L,0L,3L,3L,5L,5L,6L,4L,0L,1L,9L,9L,4L,2L,0L,4L,1L,2L,3L,7L,1L,6L,2L,2L,9L,0L,4L,9L,7L,7L,0L,6L,5L,5L,1L,5L,0L,6L,9L,2L,6L,0L,9L,4L,0L,0L,7L,5L,7L,1L,3L,2L,3L,0L,6L,7L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011198Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011198.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011198Inst : IEnumerable<long>
{
public static readonly long[] Value=A011198.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011198.Bytes);
public long this[int i]=>Value[i];

public static A011198Inst Instance=new A011198Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011181
{
public static readonly long[] Value={ 2L,4L,9L,1L,4L,6L,1L,8L,7L,9L,2L,3L,1L,0L,3L,4L,6L,5L,1L,9L,3L,3L,3L,6L,0L,6L,7L,3L,2L,8L,0L,6L,1L,0L,1L,6L,1L,8L,7L,8L,6L,1L,9L,9L,8L,6L,1L,3L,7L,5L,5L,9L,6L,2L,2L,0L,9L,2L,3L,4L,6L,0L,2L,8L,7L,2L,1L,4L,9L,3L,3L,0L,7L,5L,5L,0L,9L,8L,7L,1L,3L,3L,2L,1L,1L,7L,9L,0L,2L,8L,9L,1L,7L,6L,2L,4L,6L,8L,5L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011181Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011181.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011181Inst : IEnumerable<long>
{
public static readonly long[] Value=A011181.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011181.Bytes);
public long this[int i]=>Value[i];

public static A011181Inst Instance=new A011181Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011180
{
public static readonly long[] Value={ 2L,4L,8L,6L,2L,4L,9L,5L,7L,0L,2L,1L,2L,1L,0L,1L,9L,3L,8L,2L,5L,3L,5L,8L,1L,8L,8L,8L,7L,3L,9L,3L,2L,0L,9L,3L,5L,5L,0L,6L,1L,7L,0L,9L,4L,6L,8L,5L,7L,3L,4L,9L,1L,9L,8L,3L,5L,7L,9L,5L,8L,7L,7L,9L,4L,4L,9L,6L,4L,4L,3L,8L,9L,8L,0L,4L,9L,3L,1L,4L,5L,6L,5L,5L,3L,2L,7L,9L,8L,2L,6L,3L,1L,6L,1L,2L,3L,2L,1L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011180Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011180.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011180Inst : IEnumerable<long>
{
public static readonly long[] Value=A011180.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011180.Bytes);
public long this[int i]=>Value[i];

public static A011180Inst Instance=new A011180Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A011179
{
public static readonly long[] Value={ 2L,4L,8L,0L,9L,9L,3L,1L,8L,1L,5L,8L,7L,0L,6L,9L,0L,3L,9L,1L,3L,9L,3L,1L,0L,1L,8L,7L,0L,8L,3L,4L,8L,6L,4L,2L,3L,5L,0L,8L,9L,8L,2L,9L,5L,6L,4L,7L,3L,4L,5L,0L,0L,1L,9L,1L,9L,0L,1L,4L,6L,8L,0L,9L,6L,3L,3L,4L,1L,6L,3L,3L,7L,9L,3L,5L,1L,6L,3L,7L,8L,3L,6L,4L,5L,4L,9L,8L,2L,5L,6L,6L,6L,6L,1L,1L,1L,9L,4L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A011179Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A011179.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A011179Inst : IEnumerable<long>
{
public static readonly long[] Value=A011179.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A011179.Bytes);
public long this[int i]=>Value[i];

public static A011179Inst Instance=new A011179Inst();

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